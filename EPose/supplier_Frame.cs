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

                supplierList.Rows.Add(supplier.id, supplier.name, supplier.company,supplier.address,supplier.city,supplier.email,supplier.mobile,supplier.department_id);

            }

        }

        private void supplier_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            String searchValue = this.textBoxSearch.Text;
        }
    }
}
