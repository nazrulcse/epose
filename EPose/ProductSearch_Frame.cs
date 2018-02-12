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
        dynamic search_products; 
        public ProductSearch_Frame(Invoice_Frame inv)
        {
            InitializeComponent();
            this.invoice = inv;
        }

        public void add(dynamic products)
        {
            productItems.Rows.Clear();
            this.search_products = products;
            foreach(var p in products){
                productItems.Rows.Add(p.barcode, p.name, "10", p.sale_price, p.vat+"%", "2%", p.sale_price * 1);
            }
        }

        private void barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                productItems.Rows[0].Selected = true;
                productItems.Focus();
            }
        }

        private void barcode_TextChanged(object sender, EventArgs e)
        {
            String barcod = barcode.Text;
            if (barcod == "")
            {
                search_products = null;
                productItems.Rows.Clear();
            }
            else
            {
                ProductModel pm = new ProductModel();
                dynamic products = pm.where(pm, "barcode like '%" + barcod + "%'");
                if (products.Count > 0)
                {
                    add(products);
                }
                else
                {
                    productItems.Rows.Clear();
                    search_products = null;
                }
            }
        }

        private void productItems_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                MessageBox.Show("" + search_products.Count);
                if (search_products != null && search_products.Count > 0 && productItems.SelectedRows[0].Index < search_products.Count)
                {
                    this.invoice.addProduct(search_products[productItems.SelectedRows[0].Index]);
                    this.Close();
                }
                else {
                    MessageBox.Show("No product found");
                }
            }
        }

    }
}
