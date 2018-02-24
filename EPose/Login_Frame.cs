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
using System.IO;
using EPose.Service.Sync;
using EPose.Service.WebService;
using System.Timers;

namespace EPose
{
    public partial class Login_Frame : Form
    {
        private bool mouseDown;
        public Point mouseLocation;

        public Login_Frame()
        {
            InitializeComponent();
            this.ActiveControl = userid;
        }

        private void Login_Frame_Load(object sender, EventArgs e)
        {
           DepartmentSettings.getData();
           branch.Text = DepartmentSettings.branchName;
           branch.Enabled = false;
           userid.Focus();
           //MessageBox.Show("path: " + AppDomain.CurrentDomain.BaseDirectory + "../../");
           //loadDatabaseSettings();
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
            if (userId == "" || userPassword == "")
            {
                MessageBox.Show("Please input your user ID and Password");
                userid.Focus();
                return;
            }
            else
            {
                authenticateUser(userId, userPassword);
            }
            //InvoiceModel inv = new InvoiceModel();
            //dynamic invoice = inv.find(inv, "636548960494211");
            //InvoiceReport_Frame ir = new InvoiceReport_Frame(invoice);
            //ir.Show();
            //Main_Frame main = new Main_Frame();
            //main.Show();
            //this.Hide();
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Syns started...........");
            DownStream.perform();
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

        public void loadFromFile() { 
        
        }

        private void authenticateUser(String userId, String userPassword) {
            EmployeeModel em = new EmployeeModel();
            dynamic employee = em.find_by(em, "user_id", userId);
            if (employee != null)
            {
                Boolean matchPassword = BCryptHelper.CheckPassword(userPassword, employee.password);
                if (matchPassword)
                {
                  Main_Frame main = new Main_Frame();
                  main.Show();
                  if (DepartmentSettings.is_master_till())
                  {
                      System.Timers.Timer aTimer = new System.Timers.Timer();
                      aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                      aTimer.Interval = 900000;
                      aTimer.Enabled = true;
                  }
                  this.Hide();
                }
                else 
                {
                    password.Focus();
                  MessageBox.Show("Invalid password for login ID: " + userId, "Invalid password");
                }
            }
            else 
            {
                userid.Focus();
                MessageBox.Show("No employee found with ID: " + userId, "Invalid Login");
            }
        }

        private void userid_Enter(object sender, EventArgs e)
        {
            userid.BackColor = Color.Aqua;
        }
        private void userid_Leave(object sender, EventArgs e)
        {
            userid.BackColor = Color.FromName("white");
        }

        private void password_Enter(object sender, EventArgs e)
        {
            password.BackColor = Color.Aqua;
        }

        private void password_Leave(object sender, EventArgs e)
        {
            password.BackColor = Color.FromName("white");
        }

        private void userid_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return) {
              String userId = userid.Text;
              String userPassword = password.Text;
              if (userId != "" && userPassword != "")
              {
                  authenticateUser(userId, userPassword);
              }
              else if(userId != "") {
                  password.Focus();
              }
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                String userId = userid.Text;
                String userPassword = password.Text;
                if (userId != "" && userPassword != "")
                {
                    authenticateUser(userId, userPassword);
                }
                else if (userPassword != "")
                {
                    userid.Focus();
                }
            }
        }

        private void loadDatabaseSettings() {
            List<string> value = new List<string>();
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            foreach (var line in File.ReadAllLines(startupPath + "/DatabaseConnectionFile.txt"))
            {
                value.Add(line);
            }
            string[] databaseInformation = value.ToArray();
            SQLConn.ServerMySQL = databaseInformation[0];
            SQLConn.PortMySQL = databaseInformation[1];
            SQLConn.UserNameMySQL = databaseInformation[2];
            SQLConn.PwdMySQL = databaseInformation[3];
            SQLConn.DBNameMySQL = databaseInformation[4];
            SQLConn.SaveData();
            userid.Focus();
        }
    }
}
