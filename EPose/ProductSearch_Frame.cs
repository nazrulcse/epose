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
    public partial class ProductSearch_Frame : Layout_Frame
    {
        Invoice_Frame invoice;
        public ProductSearch_Frame(Invoice_Frame inv)
        {
            InitializeComponent();
            this.invoice = inv;
        }

        private void barcode_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                String barcod = barcode.Text;
                ProductModel pm = new ProductModel();
                dynamic products = pm.where(pm, "barcode = '" + barcod + "'");
                if (products.Count > 0)
                {
                    this.invoice.addProduct(products[0]);
                    add(products[0]);
                }
                else
                {
                    MessageBox.Show("Product Not Available");
                }
            }
        }

        public void add(dynamic product)
        {
            productItems.Rows.Add(product.barcode, product.name, "10", product.sale_price, "15%", "2%", product.sale_price * 1);
            barcode.Text = "";

        }

       

       
    }
}
