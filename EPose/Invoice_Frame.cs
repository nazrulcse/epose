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
        public Invoice_Frame()
        {
            InitializeComponent();
            this.setTitle("Invoice Form");
            this.ActiveControl = barcodeInput;
        }

            private void Invoice_Frame_Load(object sender, EventArgs e)
        {
            setWindowSize(); 
            try
            {
               this.inv = new InvoiceModel();
                var ms = (DateTime.Now - DateTime.MinValue).TotalMilliseconds;
                inv.id = ms.ToString();
                inv.number = "inv-" + ms.ToString();
                inv.date = DateTime.Today;
                inv.department_id = "1";
                dynamic invoice = inv.create(inv);
                if (invoice != null)
                {
                    invoiceNumber.Text = "" + invoice.number;
                }
                else
                {
                   invoiceNumber.Text = "Unable to create Invoice";
                }
            }
            catch (Exception ex) {
                invoiceNumber.Text = "Error: " + ex.Message.ToString();
            }
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

            topDisplay.Text = "1 " + product.unit + " @ " + product.sale_price + " Tk";
            double total = product.sale_price*1;
            sumOfprice += total;
            this.invoiceItems.Rows.Add(product.barcode, product.name, product.unit, product.sale_price, "15%", "2%", total);
            barcodeInput.Text = "";
            totalTextBox.Text = "" + sumOfprice;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                new ProductSearch_Frame(this).Show();
                return true;
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
            this.textBoxPaid.Text = amount;
        }

        private void receivedAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                double amountReceived = Convert.ToDouble(receivedAmount.Text);
                double paidAmount = Convert.ToDouble(textBoxPaid.Text);
                textBoxChange.Text = "" + (amountReceived - paidAmount);
            }
            
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            new InvoiceReport_Frame().Show();
        }

      
    }

       
}
