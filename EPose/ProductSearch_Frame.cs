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
                productItems.Rows.Add(p.barcode, p.name, p.unit, Math.Round(p.sale_price, 2), p.vat + "%", "2%", Math.Round(p.sale_price, 2));
            }
        }

        private void barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && productItems.RowCount>1)
            {
                productItems.Rows[0].Selected = true;
                productItems.Focus();
            }
        }

        private void barcode_TextChanged(object sender, EventArgs e)
        {
            String inputVal = barcode.Text;
            if (inputVal == "")
            {
                search_products = null;
                productItems.Rows.Clear();
            }
            else
            {
                ProductModel pm = new ProductModel();
                dynamic products = pm.where(pm, "barcode like '%" + inputVal + "%' OR name like '%" + inputVal + "%'");
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
                if (search_products != null && search_products.Count > 0 && productItems.SelectedRows[0].Index < search_products.Count)
                {
                    this.invoice.addProduct(search_products[productItems.SelectedRows[0].Index]);
                    this.Close();
                }
                else {
                    MessageDialog.ShowAlert("No Product found", "Alert Message", "warning");
                }
            }
        }

        private void barcode_Leave(object sender, EventArgs e)
        {
            changeColor(barcode, "out");
        }

        private void barcode_Enter(object sender, EventArgs e)
        {
            changeColor(barcode, "enter");
        }

    }
}
