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
    public partial class Main : Form
    {
        public Main()
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
            Employee emp = new Employee();
            emp.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            new Invoice().Show();
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
