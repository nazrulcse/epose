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
    public partial class Product_Frame : Layout_Frame
    {
        public Product_Frame()
        {
            InitializeComponent();
            this.setTitle("Product Window");

            this.ActiveControl = searchBox;

            ProductModel pro = new ProductModel();
            dynamic products = pro.all(pro);

            foreach( var product in products){

                productList.Rows.Add(product.barcode, product.name, product.category, product.sub_category, product.model, product.brand, product.re_order_level, product.cost_price, product.sale_price, product.expirable, product.discountable, product.stock, product.product_code);
            }
            this.productLabel.Text = "" + products.Count;
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            String searchValue = searchBox.Text;
            ProductModel pro = new ProductModel();
            dynamic products = pro.where(pro, "name like '%" + searchValue + "%' or barcode like'%" + searchValue + "%'  or product_code like'%" + searchValue + "%'");
            
            if (products.Count > 0)
            {

                this.productLabel.Text = "" + products.Count;
                productList.Rows.Clear();
                foreach (var product in products)
                {
                    productList.Rows.Add(product.barcode, product.name, product.category, product.sub_category, product.model, product.brand, product.re_order_level, product.cost_price, product.sale_price, product.expirable, product.discountable, product.stock, product.product_code);
                }
            }
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
           // searchBox.Text = "";
            changeColor(searchBox, "enter");
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            changeColor(searchBox, "out");
        }
    }
}
  