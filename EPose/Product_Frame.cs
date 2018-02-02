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

            ProductModel pro = new ProductModel();
            dynamic products = pro.all(pro);

            foreach( var product in products){

                productList.Rows.Add(product.id, product.barcode,product.name,product.description,product.department,product.category,product.sub_category,product.model,product.brand, product.re_order_level,product.cost_price,product.sale_price,product.expirable,product.discountable,product.stock);
            }

        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            String searchValue = searchBox.Text;
            ProductModel pro = new ProductModel();
            dynamic products = pro.where(pro, "name like '%" + searchValue + "%'");
            if (products.Count > 0)
            {

                this.employeeLabel.Text = "" + products.Count;
                productList.Rows.Clear();
                foreach (var product in products)
                {
                    productList.Rows.Add(product.id, product.barcode, product.name, product.description, product.department, product.category, product.sub_category, product.model, product.brand, product.re_order_level, product.cost_price, product.sale_price, product.expirable, product.discountable, product.stock);
                }
            }
        }
    }
}
  