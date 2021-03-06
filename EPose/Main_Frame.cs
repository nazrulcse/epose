﻿using EPose.Service;
using Microsoft.Reporting.WinForms;
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
            Application.Exit();
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
            new DailySale_Frame().Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            new ProductCategory_Frame().Show();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            new supplier_Frame().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Employee_Frame().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Customer_Frame().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new ActivityLog_Frame().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Product_Frame().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Settings_Frame().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new PaymentList_Frame().Show();
        }

        private void btnDatabaseConfig_Click(object sender, EventArgs e)
        {
            new Connection_frame().Show(); 
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.P))
            {
                new Product_Frame().Show();
                return true;
            }
            else if(keyData == (Keys.Control | Keys.C)){
                new Customer_Frame().Show();
            }
            else if(keyData == (Keys.Control | Keys.I)){
                new Invoice_Frame().Show();
            }
            else if(keyData == (Keys.Control | Keys.S)){
                new Settings_Frame().Show();
            }
            else if (keyData == (Keys.Control | Keys.D))
            {
                new Connection_frame().Show();
            }
            else{
            
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tillClosingButton_Click(object sender, EventArgs e)
        {
            new TillClosing_Frame().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminSettings().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
