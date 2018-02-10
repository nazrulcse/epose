using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPose.Orm;
using EPose.Model;
using EPose.Service;
using DevOne.Security.Cryptography.BCrypt;

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

        private void Login_Frame_Load(object sender, EventArgs e)
        {
           //SyncService.run();
           DepartmentSettings.getData();
           branch.Text = DepartmentSettings.DepartmentId;
           branch.Enabled = false;
        }

        private void topHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void topHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X - 110, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void topHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void poweroff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String userId = userid.Text;
            String userPassword = password.Text;


            //InvoiceModel inv = new InvoiceModel();
            //dynamic invoice = inv.find(inv, "636538841229883");
            //InvoiceItemModel invi = new InvoiceItemModel();
            //dynamic items = invi.where(invi, "invoice_id = '" + invoice.id + "'");
            //Console.WriteLine("" + invoice.id);
            //Console.WriteLine(items);
            //MessageBox.Show("dsf");
            //PosReceipt ps = new PosReceipt(invoice);
            //ps.print();

            //EmployeeModel em = new EmployeeModel();
            //dynamic employee = em.find_by(em, "login_id", userId);
            //if(userId == "" || userPassword == "") {
              //  MessageBox.Show("Please input your user ID and Password");
                //return;
            //}
            //if (employee != null)
            //{
              //  Boolean matchPassword = BCryptHelper.CheckPassword(userPassword, employee.password);
                //if (matchPassword)
                //{
                    Main_Frame main = new Main_Frame();
                    main.Show();
                    this.Hide();
                //}
                //else {
                  //  MessageBox.Show("Invalid password for login ID: " + userId, "Invalid password");
                //}
            //}
            //else {
              //  MessageBox.Show("No employee found with ID: " + userId, "Invalid Login");
            //}
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Connection_frame cnf = new Connection_frame();
            cnf.Show();
        }
    }
}
