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
            this.ActiveControl = searchBox;
            customerList.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            CustomerModel cust = new CustomerModel();
            dynamic customers = cust.all(cust);
            foreach( var customer in customers){
                customerList.Rows.Add(customer.id, customer.name, customer.company, customer.address, customer.city, customer.email, customer.mobile, customer.initial_balance, customer.credit_limit);
            }
            this.customerLabel.Text = "" + customers.Count;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            String searchValue = searchBox.Text;
            CustomerModel cus = new CustomerModel();
            dynamic customers = cus.where(cus, "name like '%" + searchValue + "%' or email like '%" + searchValue + "%' or mobile like '%"+ searchValue + "%'");
            if (customers.Count > 0)
            {

                this.customerLabel.Text = "" + customers.Count;
                customerList.Rows.Clear();
                foreach (var customer in customers)
                {
                    customerList.Rows.Add(customer.id, customer.name, customer.company, customer.address, customer.city, customer.email, customer.mobile, customer.initial_balance, customer.credit_limit);
                }
            }
            
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            changeColor(searchBox, "enter");
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
          changeColor(searchBox, "out");
        }
    }
}
