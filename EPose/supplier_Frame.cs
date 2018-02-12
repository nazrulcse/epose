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
    public partial class supplier_Frame :Layout_Frame
    {
        public supplier_Frame()
        {
            InitializeComponent();
            this.setTitle("Supplier Window");

           SupplierModel sup = new SupplierModel();
           dynamic suppliers = sup.all(sup);

           foreach (var supplier in suppliers)
            {
                this.employeeLabel.Text = "" + suppliers.Count;
                supplierList.Rows.Add(supplier.id, supplier.name, supplier.company,supplier.address,supplier.city,supplier.email,supplier.mobile);

            }

        }

        private void supplier_Load(object sender, EventArgs e)
        {
            this.ActiveControl = searchBox;
        }

               private void searchBox_TextChanged(object sender, EventArgs e)
        {
            String searchValue = searchBox.Text;
            SupplierModel sup = new SupplierModel();
            dynamic suppliers = sup.where(sup, "name like '%" + searchValue + "%'  or email like '%" + searchValue + "%' or mobile like '%"+ searchValue + "%'");

            if (suppliers.Count > 0)
            {
                this.employeeLabel.Text = "" + suppliers.Count;
                supplierList.Rows.Clear();
                foreach (var supplier in suppliers)
                {
                    supplierList.Rows.Add(supplier.id, supplier.name, supplier.company, supplier.address, supplier.city, supplier.email, supplier.mobile);
                }
            }
        }

               private void searchBox_Leave(object sender, EventArgs e)
               {
                   changeColor(searchBox, "out");
               }

               private void searchBox_Enter(object sender, EventArgs e)
               {
                   changeColor(searchBox, "enter");
               }
    }
}
