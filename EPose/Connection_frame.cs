using EPose.Orm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;
using System.Diagnostics;
using System.Xml.Linq;
using System.IO;

namespace EPose
{
    public partial class Connection_frame : Layout_Frame
    {
        public Connection_frame()
        {
            InitializeComponent();
            this.setTitle("Connect Database");
        }

        private string TstServerMySQL;
        private string TstPortMySQL;
        private string TstUserNameMySQL;
        private string TstPwdMySQL;
        private string TstDBNameMySQL;
        Image i;
        Bitmap bitmap;

        private void Connection_frame_Load(object sender, EventArgs e)
        {
            SQLConn.getData();
            DepartmentSettings.getData();
            txtServerHost.Text = SQLConn.ServerMySQL;
            txtPort.Text = SQLConn.PortMySQL;
            txtUserName.Text = SQLConn.UserNameMySQL;
            txtPassword.Text = SQLConn.PwdMySQL;
            txtDatabase.Text = SQLConn.DBNameMySQL;
            txtDepartmentId.Text = DepartmentSettings.DepartmentId;
            txtTillId.Text = DepartmentSettings.TillId;
            textBoxVatChalan.Text = DepartmentSettings.vatChalan;
            textBoxVatRegestration.Text = DepartmentSettings.vatRegstration;
            textBoxBranchName.Text = DepartmentSettings.branchName;
            textBoxAdress.Text = DepartmentSettings.address;
            branch_logo.Image = new Bitmap(DepartmentSettings.logo);
            master_till.Checked = DepartmentSettings.is_master_till();
        }


        private void cmdTest_Click_1(object sender, System.EventArgs e)
        {
            //Test database connection

            TstServerMySQL = txtServerHost.Text;
            TstPortMySQL = txtPort.Text;
            TstUserNameMySQL = txtUserName.Text;
            TstPwdMySQL = txtPassword.Text;
            TstDBNameMySQL = txtDatabase.Text;
            if (TstServerMySQL == "" || TstPortMySQL == "" || TstUserNameMySQL == "" || TstDBNameMySQL == "")
            {
                MessageBox.Show("Please Fill the input Box properly");
            }

            else
            {
                try
                {
                    SQLConn.conn.ConnectionString = "Server = '" + TstServerMySQL + "';  " + "Port = '" + TstPortMySQL + "'; " + "Database = '" + TstDBNameMySQL + "'; " + "user id = '" + TstUserNameMySQL + "'; " + "password = '" + TstPwdMySQL + "'";
                    SQLConn.conn.Open();
                    Interaction.MsgBox("Test connection successful", MsgBoxStyle.Information, "Database Settings");
                }
                catch
                {
                    Interaction.MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings");
                }
                SQLConn.DisconnMy();
            }
        }

        private void cmdClose_Click_1(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click_1(object sender, System.EventArgs e)
        {
            TstServerMySQL = txtServerHost.Text;
            TstPortMySQL = txtPort.Text;
            TstUserNameMySQL = txtUserName.Text;
            TstPwdMySQL = txtPassword.Text;
            TstDBNameMySQL = txtDatabase.Text;

            String departmentId = txtDepartmentId.Text;

            if (TstServerMySQL == "" || TstPortMySQL == "" || TstUserNameMySQL == "" || TstDBNameMySQL == "")
            {
                MessageBox.Show("Please Fill the input Box properly");
            }

            else
            {
                try
                {
                    SQLConn.conn.ConnectionString = "Server = '" + TstServerMySQL + "';  " + "Port = '" + TstPortMySQL + "'; " + "Database = '" + TstDBNameMySQL + "'; " + "user id = '" + TstUserNameMySQL + "'; " + "password = '" + TstPwdMySQL + "'";
                    SQLConn.conn.Open();

                    SQLConn.DBNameMySQL = txtDatabase.Text;
                    SQLConn.ServerMySQL = txtServerHost.Text;
                    SQLConn.UserNameMySQL = txtUserName.Text;
                    SQLConn.PortMySQL = txtPort.Text;
                    SQLConn.PwdMySQL = txtPassword.Text;
                    SQLConn.SaveData();

                    MessageDialog.ShowAlert("Settings saved successfully");
                }
                catch
                {
                    Interaction.MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings");
                }
                SQLConn.DisconnMy();
                //save database
            }
        }

        private void exitForm_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void saveDepartment_Click(object sender, System.EventArgs e)
        {
            DepartmentSettings.DepartmentId = txtDepartmentId.Text;
            DepartmentSettings.TillId = txtTillId.Text;
            DepartmentSettings.vatChalan = textBoxVatChalan.Text;
            DepartmentSettings.vatRegstration = textBoxVatRegestration.Text;
            DepartmentSettings.branchName = textBoxBranchName.Text;
            DepartmentSettings.address = textBoxAdress.Text;
            DepartmentSettings.master_till = master_till.Checked ? "1" : "0";
            DepartmentSettings.SaveData();
        }
       
         
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                try
                {
                    i = Image.FromFile(ofd.FileName);
                    bitmap = (Bitmap)i;
                    branch_logo.Image = bitmap;
                }
                catch (IOException)
                {
                }
            }
           
        }

        private void logoUploader_FileOk(object sender, CancelEventArgs e)
        {
              
        }

        private void upload_logo_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                branch_logo.Image = new Bitmap(open.FileName);
                // image file path  
                DepartmentSettings.logo = open.FileName;
            }  
        }
       
    }
}
