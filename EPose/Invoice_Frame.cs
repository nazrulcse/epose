using EPose.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        double sumOfprice = 0.0;
        double sumOfVat = 0.0;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barcodeInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return) {
                if (barcodeInput.Text == "")
                {
                    receivedAmount.Focus();
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
                    else {
                        MessageBox.Show("Product Not Available");
                    }
                }
            }
        }

        public void addProduct(dynamic product)
        {
            topDisplay.Text = "1" + product.unit + " @ " + product.sale_price + " Tk";
            double total = product.sale_price * 1;
            sumOfprice += total;
            //calculate vat per product
            double vat = product.sale_price * (product.vat/100);
            //add per product vat to total vat
            sumOfVat += vat;
            this.invoiceItems.Rows.Add(product.barcode, product.name, product.unit, product.sale_price, product.vat + "%", "0%", total);
            barcodeInput.Text = "";
            totalTextBox.Text = "" + sumOfprice;
            textBoxVat.Text = "" + sumOfVat;
            textBoxNetDue.Text = "" + (sumOfprice + sumOfVat);
            createLineItem(product);
        }

        public void createLineItem(dynamic product) {
            InvoiceItemModel inv_item = new InvoiceItemModel();
            var ms = (DateTime.Now - DateTime.MinValue).TotalMilliseconds * 10;
            inv_item.id = "INT" + ms.ToString();
            inv_item.quantity = 1;
            inv_item.unit = product.unit;
            inv_item.price = product.sale_price;
            inv_item.vat = product.vat;
            inv_item.total = product.sale_price;
            inv_item.name = product.name;
            inv_item.invoice_id = this.inv.id;
            //inv_item.date = DateTime.Today;
            inv_item.create(inv_item);
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
                        MessageBox.Show("Complete Current Invoice");
                    }
                    break;
                case (Keys.Control | Keys.M):
                    MemberShip_Frame memberShip = new MemberShip_Frame(sumOfprice);
                    memberShip.Show();
                    break;
                case (Keys.Control | Keys.A):
                    if (this.inv != null)
                    {
                        payment_Frame payment = new payment_Frame(this.inv, this);
                        payment.Show();
                    }
                    else {
                        MessageBox.Show("Invoice not initialize");
                    }
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            payment_Frame payment = new payment_Frame(this.inv, this);
            payment.Show();
        }

        public void setWindowSize() {
            int windowWidth = Screen.PrimaryScreen.Bounds.Width;
            int windowHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Width = (windowWidth - 200);
            this.Height = (windowHeight - 100);
            invoicePanel.Width = Convert.ToInt32(this.Width - 320);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedRow = invoiceItems.SelectedRows[0].Index; ;
                dynamic cellValue = invoiceItems.Rows[SelectedRow].Cells["total"].Value;
                double total = Convert.ToDouble(Convert.ToString(cellValue));
                sumOfprice -= total;
                totalTextBox.Text = "" + sumOfprice;
                invoiceItems.Rows.RemoveAt(SelectedRow);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please Select a Row");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new payment_Frame(inv, this).Show();
        }

        public void paidAmount(String amount) {
            this.totalTextBox.Text = amount;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            PosReceipt psr = new PosReceipt(this.inv);
            psr.print();
        }

        public void createInvoice() {
            try
            {
                this.inv = new InvoiceModel();
                var ms = (DateTime.Now - DateTime.MinValue).TotalMilliseconds * 10;
                inv.id = ms.ToString();
                inv.number = "IN" + ms.ToString();
                inv.date = DateTime.Today;
                inv.department_id = "1";
                dynamic invoice = inv.create(inv);
                if (invoice != null)
                {
                    TrackLog();
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

        public void TrackLog() {
            ActivityLogModel log = new ActivityLogModel();
            log.model = "invoice";
            log.action = "create";
            log.date = DateTime.Now;
            log.ref_id = inv.id;
            log.department_id = inv.department_id;
            log.create(log);
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
                String name = textBoxCustomer.Text;
                String aaa = name.Substring(name.IndexOf('(') + 1);
                String id = aaa.Substring(0, aaa.IndexOf(')'));
               
               CustomerModel cust = new CustomerModel();
               dynamic customers = cust.where(cust,"id = "+id);
               textBoxCreditLimit.Text = ""+customers[0].credit_limit;
               textBoxBalance.Text = ""+customers[0].initial_balance;

               inv.update_attribute(inv, "customer_id",id,inv.id);
                 
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

        private void textBoxDiscount_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {   //take the discount amount from the text box
                double discountAmount = Convert.ToDouble(textBoxDiscount.Text);
                double totalamount = sumOfVat+sumOfprice;
                double amountAfterDisount = totalamount - discountAmount;
                textBoxNetDue.Text = "" + amountAfterDisount;
                textBoxDiscount.BackColor = Color.LawnGreen;
            }

        }

        private void receivedAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double amountReceived = Convert.ToDouble(receivedAmount.Text);
                double netDueAmount = Convert.ToDouble(textBoxNetDue.Text);
                textBoxChange.Text = "" + (amountReceived - netDueAmount);
                textBoxChange.BackColor = Color.Red;
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
            //textBoxDiscount.Text = "";
            changeColor(textBoxDiscount, "enter");
        }

        private void textBoxDiscount_Leave(object sender, EventArgs e)
        {
            changeColor(textBoxDiscount, "out");
        }
    }

       
}
