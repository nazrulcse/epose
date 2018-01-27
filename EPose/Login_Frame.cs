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
    public partial class Login_Frame : Form
    {
        private bool mouseDown;
        public Point mouseLocation;

        public Login_Frame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Frame main = new Main_Frame();
            main.Show();
            this.Hide();

            String userid = this.userid.Text;
            String password = this.password.Text;
            String branch = this.branch.Text;

            //string selected = this.company.GetItemText(this.company.SelectedItem);
            

        }

        private void cancle_Click(object sender, EventArgs e)
        {
          //  Application.Exit();
           //supplier supplier = new supplier();
            //supplier.Show();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
               Point mousePos = Control.MousePosition;
               mousePos.Offset(mouseLocation.X - 110, mouseLocation.Y);
               Location = mousePos;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void poweroff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Main_Frame main = new Main_Frame();
            main.Show();
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
