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
    public partial class PurchaseReturn_Frame : Layout_Frame
    {
        public PurchaseReturn_Frame()
        {
            InitializeComponent();
            this.setTitle("Purchase Order Window");
        }

        private void PurchaseReturn_Load(object sender, EventArgs e)
        {

        }

        private void employeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
