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
    public partial class Customer_Frame : Layout_Frame
    {
        public Customer_Frame()
        {
            InitializeComponent();
            this.setTitle("Customer Window");
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            CustomerModel cust = new CustomerModel();
            dynamic customers = cust.all(cust);
            foreach( var customer in customers){
                customerList.Rows.Add(customer.id, customer.name, customer.company, customer.address, customer.city, customer.email, customer.mobile, customer.department_id, customer.initial_balance, customer.credit_limit);
            }
            this.totalCustomerLevel.Text = "" + customers.Count;
          

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            String searchValue = this.textBoxSearch.Text;
            string selected = this.comboBoxCategory.GetItemText(this.comboBoxCategory.SelectedItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
