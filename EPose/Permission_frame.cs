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
    public partial class Permission_frame : Layout_Frame
    {
        Invoice_Frame invoice = null;
        public  Permission_frame(Invoice_Frame invoice)
        {
            InitializeComponent();
            this.invoice = invoice;
        }

        public static string password;

        private void Permission_frame_Load(object sender, EventArgs e)
        {
            setTitle("Manager Permission");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) {
                 password = textBox1.Text;
                 if (checkPassword())
                 {
                     this.invoice.SaveChangePriceToDatabase();
                 }
                 else {
                     MessageBox.Show("Incorret Password");
                     this.invoice.changeCellValue();
                 }
                 this.Close();
            }
        }

        public static bool checkPassword() {

            if (password == "12345")
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
