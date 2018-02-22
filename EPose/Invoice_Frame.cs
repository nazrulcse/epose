 using EPose.Model;
using EPose.Service.Sync;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPose
{
    public partial class Invoice_Frame : Layout_Frame
    {
        Product_Frame pro = new Product_Frame();
        InvoiceModel inv;
        public Invoice_Frame()
        {
            InitializeComponent();
            this.setTitle("Invoice Form");
            this.ActiveControl = barcodeInput;
        }

        private void Invoice_Frame_Load(object sender, EventArgs e)
        {
            setWindowSize();
            textBoxCustomer.AutoCompleteCustomSource = this.getCustomerName();
            DepartmentSettings.getData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barcodeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (barcodeInput.Text == "")
                {
                    if (invoiceItems.RowCount > 1)
                    {
                        textBoxCustomer.Focus();
                    }
                    return;
                }
                else
                {
                    String barcode = barcodeInput.Text;
                    ProductModel pm = new ProductModel();
                    dynamic products = pm.where(pm, "barcode = '" + barcode + "'");
                    if (products.Count > 0)
                    {
                        addProduct(products[0]);
                    }
                    else
                    {
                        MessageBox.Show("Product Not Available");
                    }
                }
            }
        }

        public void addProduct(dynamic product)
        {
            if (this.inv != null)
            {
                topDisplay.Text = "1" + product.unit + " @ " + product.sale_price + " Tk";
                double total = product.sale_price * 1;
                this.inv.invoice_total += total;
                //calculate vat per product
                double vat = product.sale_price * (product.vat / 100);
                //add per product vat to total vat
                this.inv.vat += vat;
                this.invoiceItems.Rows.Add(product.barcode, product.name, product.unit, product.sale_price, product.vat + "%", "0%", total);
                barcodeInput.Text = "";
                updateAmount();
                createLineItem(product);
            }
            else {
                MessageBox.Show("Invoice not initialize", "No invoice");
            }
        }

        public void createLineItem(dynamic product) {
            InvoiceItemModel inv_item = new InvoiceItemModel();
            var ms = (DateTime.Now - DateTime.MinValue).TotalMilliseconds * 10;
            inv_item.id = "INT" + ms.ToString();
            inv_item.quantity = 1;
            inv_item.product_id = product.id;
            inv_item.unit = product.unit;
            inv_item.price = product.sale_price;
            inv_item.vat = product.vat;
            inv_item.total = product.sale_price;
            inv_item.name = product.name;
            inv_item.invoice_id = this.inv.id;
            inv_item.date = DateTime.Now.ToString("yyyy-MM-dd");
            inv_item.create(inv_item);
            ActivityLogModel.track("invoice_item", "create", inv_item.id);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData) { 
                case (Keys.Control | Keys.S):
                    new ProductSearch_Frame(this).Show();
                    return true;
                case (Keys.Control | Keys.N):
                    if (this.inv == null)
                    {
                        createInvoice();
                    }
                    else {
                        MessageDialog.ShowAlert("Complete Current Invoice First", "Alert Message", "warning");
                    }
                    break;
                case (Keys.Control | Keys.M):
                    if( this.inv != null){
                        if (inv.invoice_total > 0)
                        {
                            MemberShip_Frame memberShip = new MemberShip_Frame(this.inv.invoice_total);
                            memberShip.Show();
                        }
                        else {
                            MessageBox.Show("Please Select Some Product First");
                        }
                    }
                    else{
                        MessageDialog.ShowAlert("No invoice found", "Alert Message", "warning");
                    }
                    
                    break;
                case (Keys.Control | Keys.A):
                    if (this.inv != null)
                    {
                        payment_Frame payment = new payment_Frame(this.inv, this);
                        payment.Show();
                        updateInvoice();
                    }
                    else {
                        MessageDialog.ShowAlert("No invoice found", "Alert Message", "warning");
                    }
                    break;
                case (Keys.Return):
                    checkForInvoice();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            payment_Frame payment = new payment_Frame(this.inv, this);
            payment.Show();
            updateInvoice();
        }

        public void setWindowSize() {
            int windowWidth = Screen.PrimaryScreen.Bounds.Width;
            int windowHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Width = (windowWidth - 200);
            this.Height = (windowHeight - 100);
            invoicePanel.Width = Convert.ToInt32(this.Width - 320);
        }

        // Remove invoice item
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedRow = invoiceItems.SelectedRows[0].Index; ;
                dynamic cellValue = invoiceItems.Rows[SelectedRow].Cells["total"].Value;
                float total = Convert.ToDouble(Convert.ToString(cellValue));
                this.inv.invoice_total -= total;
                updateAmount();
                invoiceItems.Rows.RemoveAt(SelectedRow);
            }
            catch (Exception exception)
            {
                MessageDialog.ShowAlert("Please Select a row", "Alert Message", "warning");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.inv != null)
            {
                updateInvoice();
                new payment_Frame(inv, this).Show();
            }
            else {
                MessageDialog.ShowAlert("No invoice found", "Alert Message", "warning");
            }
        }

        public void paidAmount(String amount) {
            this.totalTextBox.Text = amount;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageDialog.Show("Print!", "Are you want to print the receipt now!", "print");
            if (result == DialogResult.Yes)
            {
                PosReceipt psr = new PosReceipt(this.inv);
                psr.print();
            }
            result = MessageDialog.Show("Next Invoice!", "Is this invoice close and process next invoice?");
            if (result == DialogResult.Yes)
            {
                resetInvoice();
            }
        }

        public void updateAmount() {
            totalTextBox.Text = "" + this.inv.invoice_total;
            textBoxVat.Text = "" + this.inv.vat;
            textBoxDiscount.Text = "" + this.inv.discount;
            this.inv.net_total = (this.inv.invoice_total + this.inv.vat - this.inv.discount);
            textBoxNetDue.Text = "" + this.inv.net_total;
        }

        public void createInvoice() {
            try
            {
               // UpStream.perform();
                this.inv = new InvoiceModel();
                var ms = (DateTime.Now - DateTime.MinValue).TotalMilliseconds * 10;
                inv.id = ms.ToString();
                inv.number = "IN" + ms.ToString();
                inv.date = DateTime.Now.ToString("yyyy-MM-dd");
                inv.department_id = DepartmentSettings.DepartmentId;
                inv.till_id = DepartmentSettings.TillId;
                dynamic invoice = inv.create(inv);
                if (invoice != null)
                {
                    ActivityLogModel.track("invoice", "create", this.inv.id);
                    invoiceNumber.Text = "" + invoice.number;
                }
                else
                {
                    invoiceNumber.Text = "Unable to create Invoice";
                }
            }
            catch (Exception ex)
            {
                invoiceNumber.Text = "Error: " + ex.Message.ToString();
           }
        }

        public Boolean deleteInvoiceLog()
        {
            return false;
        }

        public void paymentCompleted() {
            updateInvoice();
            //UpStream.perform();
        }

        public void resetInvoice(Boolean create = true) {
            this.inv = null;
            this.receivedAmount.Text = "0.0";
            this.textBoxCustomer.Text = "";
            this.textBoxCreditLimit.Text = "0.0";
            this.textBox12.Text = "0.0";
            this.textBoxBalance.Text = "0.0";
            this.totalTextBox.Text = "0.0";
            this.textBoxVat.Text = "0.0";
            this.textBoxDiscount.Text = "0.0";
            this.textBoxNetDue.Text = "0.0";
            this.textBoxChange.Text = "0.0";
            this.textBox9.Text = "0.0";
            this.barcodeInput.Text = "";
            this.invoiceItems.Rows.Clear();
            this.barcodeInput.Focus();
            if (create)
            {
                createInvoice();
            }
            else {
                invoiceNumber.Text = "Create Invoice(Ctrl + N)";
            }
        }

        public void updateInvoice() {
            this.inv.save(this.inv);
            ActivityLogModel.track("invoice", "update", this.inv.id);
        }

        public AutoCompleteStringCollection getCustomerName()
        {
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            CustomerModel cust = new CustomerModel();
            dynamic customers = cust.all(cust);

            foreach (var customer in customers)
            {
                col.Add(customer.name +" (" +customer.id+")");
            }

            return col;
        }

        private void textBoxCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxCustomer.Text != "")
                {
                    String id = "";
                    String name = textBoxCustomer.Text;
                    String aaa = name.Substring(name.IndexOf('(') + 1);
                    if (aaa.IndexOf(')') != -1)
                    {
                        id = aaa.Substring(0, aaa.IndexOf(')'));
                        this.inv.customer_id = id;
                    }
                    else {
                        MessageDialog.ShowAlert("Invalid Customer", "Alert Message", "warning");
                        return;
                    }
                   
                    CustomerModel cust = new CustomerModel();
                    dynamic customers = cust.where(cust, "id = " + id);
                    if (customers.Count > 0)
                    {
                        if (this.inv != null)
                        {
                            textBoxCreditLimit.Text = "" + customers[0].credit_limit;
                            textBoxBalance.Text = "" + customers[0].initial_balance;
                            inv.update_attribute(inv, "customer_id", id, inv.id);
                        }
                        else {
                            MessageDialog.ShowAlert("Invoice not initialized", "Alert Message", "warning");
                        }
                    }
                    else {
                        MessageDialog.ShowAlert("Customer Not Found", "Alert Message", "warning");
                        return;
                    }
                }
                textBoxDiscount.Focus();
            }
        }

        private void barcodeInput_Enter(object sender, EventArgs e)
        {
            changeColor(barcodeInput, "enter");
        }

        private void barcodeInput_Leave(object sender, EventArgs e)
        {
            changeColor(barcodeInput, "out");
        }

        private void textBoxDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {   //take the discount amount from the text box
                double discountAmount = Convert.ToDouble(textBoxDiscount.Text);
                this.inv.discount = discountAmount;
                updateAmount();
                receivedAmount.Focus();
                payment_Frame pf = new payment_Frame(this.inv, this);
                pf.Show();
            }
        }

        private void receivedAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double amountReceived = Convert.ToDouble(receivedAmount.Text);
                double netDueAmount = Convert.ToDouble(textBoxNetDue.Text);
                double changeAmount = (amountReceived - this.inv.net_total);
                textBoxChange.Text = changeAmount > 0 ? "" + changeAmount : "0";
                textBoxChange.Focus();
            }
        }

        private void textBoxCustomer_Enter(object sender, EventArgs e)
        {
            changeColor(textBoxCustomer, "enter");
        }

        private void textBoxCustomer_MouseLeave(object sender, EventArgs e)
        {
            changeColor(textBoxCustomer, "out");
        }

        private void textBoxDiscount_Enter(object sender, EventArgs e)
        {
            changeColor(textBoxDiscount, "enter");
        }

        private void textBoxDiscount_Leave(object sender, EventArgs e)
        {
            changeColor(textBoxDiscount, "out");
        }

        private void receivedAmount_Enter(object sender, EventArgs e)
        {
            changeColor(receivedAmount, "enter");
        }

        private void receivedAmount_Leave(object sender, EventArgs e)
        {
            changeColor(receivedAmount, "out");
        }

        private void textBoxChange_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return) {
                DialogResult result = MessageDialog.Show("Print!", "Are you want to print the receipt now!");
                if (result == DialogResult.Yes)
                {
                    PosReceipt ps = new PosReceipt(this.inv);
                    ps.print();
                }
                result = MessageDialog.Show("Next Invoice!", "Is this invoice close and process next invoice?");
                if (result == DialogResult.Yes)
                {
                    resetInvoice();
                }
            }
        }

        private void textBoxChange_Enter(object sender, EventArgs e)
        {
            changeColor(textBoxChange, "enter");
        }

        private void textBoxChange_Leave(object sender, EventArgs e)
        {
            changeColor(textBoxChange, "out");
        }

        private void voidInvoice_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageDialog.Show("Delete Invoice!", "Are you sure want to delete invoice", "warning");
            if (result == DialogResult.Yes)
            {
                if(checkForInvoice()) {
                    InvoiceItemModel invitem = new InvoiceItemModel();
                    invitem.delete(invitem, "invoice_id='" + this.inv.id + "'");
                    PaymentModel payment = new PaymentModel();
                    payment.delete(payment, "invoice_id='" + this.inv.id + "'");
                    inv.delete(this.inv);
                    resetInvoice(false);
                }
            }
        }

        private Boolean checkForInvoice() {
            if (this.inv == null)
            {
                DialogResult result = MessageDialog.Show("New Invoice!", "Invoice not initialize! Do you want to create new Invoice?");
                if (result == DialogResult.Yes)
                {
                    createInvoice();
                }
                return false;
            }
            else {
                return true;
            }
        }

        private void nextInvoice_Click(object sender, EventArgs e)
        {
            if (this.inv != null)
            {
                DialogResult result = MessageDialog.Show("New Invoice!", "Do you want to complete current invoice and process next invoice?");
                if (result == DialogResult.Yes)
                {
                    resetInvoice();
                }
            }
        }

        private void recepentA4Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageDialog.Show("Print A4 Recepent!", "Are you want to print the A4 receipt now!", "print");
            if (result == DialogResult.Yes)
            {
               InvoiceReport_Frame recept = new InvoiceReport_Frame(this.inv);
              recept.Show();
            }
        }

        private void sales_return_Click(object sender, EventArgs e)
        {
            PurchaseReturn_Frame pf = new PurchaseReturn_Frame();
            pf.Show();
        }                                                                                                                                                                                                                                                                                                                                                                                                                                          
    }
}
