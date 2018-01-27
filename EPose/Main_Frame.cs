using EPose.Service;
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
    public partial class Main_Frame : Form
    {
        public Main_Frame()
        {
            InitializeComponent();
            //SyncService.run();
        }

        private void poweroff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void poweroff_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            new Invoice_Frame().Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Employee_Frame emp = new Employee_Frame();
            emp.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new Settings_Frame().Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product_Frame product_Frame = new Product_Frame();
            product_Frame.Show();
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            new DailyHighlights_Frame().Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            new ProductCategory_Frame().Show();
        }
    }
}
