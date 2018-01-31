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
    public partial class ProductSearch_Frame : Form
    {
        public ProductSearch_Frame()
        {
            InitializeComponent();
        }

        private void barcode_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String barcod = barcode.Text;
            ProductModel pm = new ProductModel();
            dynamic products = pm.where(pm, "barcode = '" + barcod + "'");
            if (products.Count > 0)
            {

                Invoice_Frame inv = new Invoice_Frame();
                inv.addProduct(products[0]);
            }
            else
            {
                MessageBox.Show("Product Not Available");

            }
        }

       
    }
}
