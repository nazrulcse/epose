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
            SyncService.run();
        }

        private void poweroff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void poweroff_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Employee_Frame emp = new Employee_Frame();
            emp.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            new Invoice_Frame().Show();
        }

        private void btnDatabaseConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnStocksReport_Click(object sender, EventArgs e)
        {

        }
    }
}
