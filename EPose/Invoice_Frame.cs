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
        public Invoice_Frame()
        {
            InitializeComponent();
            this.setTitle("Invoice Form");
            this.ActiveControl = barcodeInput;
        }

        private void Invoice_Frame_Load(object sender, EventArgs e)
        {
           
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
                    receiptAmount.Focus();
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
           this.invoiceItems.Rows.Add(product.barcode, product.name, "10", product.sale_price, "15%", "2%", product.sale_price*1);
            barcodeInput.Text = "";

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
            payment_Frame payment = new payment_Frame(this.inv);
            payment.Show();
        }
    }
}
