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
        private string DepartmentId;
        private string vatChalan;
        private string vatRegestration;
        private string vatAdress;
        

        private void Connection_frame_Load(object sender, EventArgs e)
        {
            txtServerHost.Text = SQLConn.ServerMySQL;
            txtPort.Text = SQLConn.PortMySQL;
            txtUserName.Text = SQLConn.UserNameMySQL;
            txtPassword.Text = SQLConn.PwdMySQL;
            txtDatabase.Text = SQLConn.DBNameMySQL;
            txtDepartmentId.Text = DepartmentSettings.DepartmentId;
            txtTillId.Text = DepartmentSettings.TillId;
            textBoxVatChalan.Text = DepartmentSettings.vatChalan;
            textBoxVatRegestration.Text = DepartmentSettings.vatRegstration;
            textBoxAdress.Text = DepartmentSettings.address;
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
                   //SQLConn.department_Id = txtDepartmentId.Text;

                   SQLConn.SaveData();
                    string startupPath = System.IO.Directory.GetCurrentDirectory();
                    using (StreamWriter objWriter = new StreamWriter(startupPath+"/DatabaseConnectionFile.txt"))
                    {
                        objWriter.WriteLine(txtServerHost.Text);
                        objWriter.WriteLine(txtPort.Text);
                        objWriter.WriteLine(txtUserName.Text);
                        objWriter.WriteLine(txtPassword.Text);
                        objWriter.WriteLine(txtDatabase.Text);
                    
                        MessageBox.Show("Details have been saved to file");
                    }



                    this.Close();
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
            DepartmentSettings.address = textBoxAdress.Text;
            DepartmentSettings.SaveData();
        }

       
    }
}
