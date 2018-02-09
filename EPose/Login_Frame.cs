﻿using System;
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
           SyncService.run();
           DepartmentSettings.getData(); 
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
            Main_Frame main = new Main_Frame();
            main.Show();
            this.Hide();

            //EmployeeModel em = new EmployeeModel();
            //dynamic employee = em.find(em, "315");
            //Console.WriteLine("Employee.name: " + employee.name);

            //EmployeeModel em = new EmployeeModel();
            //em.name = "Md Nazrul Islam";
            //em.id = DateTime.Now.Millisecond.ToString();
            //em.is_active = false;
            //em.create(em);
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
