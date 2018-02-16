using EPose.Service.WebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPose
{
    public partial class AdminSettings : Layout_Frame
    {
        public AdminSettings()
        {
            InitializeComponent();
            setTitle("Admin Settings");
        }
        private void getProductButton_Click(object sender, EventArgs e)
        {
            lodingButton.Show();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                ProductService.perform("pos/products");
                lodingButton.BeginInvoke(
             ((Action)(() => lodingButton.Hide())));
            }).Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lodingButton1.Show();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                EmployeeService.perform("employees");
                lodingButton1.BeginInvoke(
             ((Action)(() => lodingButton1.Hide())));
            }).Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lodingButton2.Show();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                MemberShipWebService.perform("members");
                lodingButton2.BeginInvoke(
             ((Action)(() => lodingButton2.Hide())));
            }).Start();
           
        }

        private void getSupplierButton_Click(object sender, EventArgs e)
        {
            lodingButton3.Show();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                SupplierService.perform("pos/suppliers");
                lodingButton3.BeginInvoke(
             ((Action)(() => lodingButton3.Hide())));
            }).Start();
            
        }

        private void getDepartmentButton_Click(object sender, EventArgs e)
        {

            lodingButton4.Show();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                DepartmentService.perform("departments");
                lodingButton4.BeginInvoke(
             ((Action)(() => lodingButton4.Hide())));
            }).Start();
            
        }

        private void getCustomerButton_Click(object sender, EventArgs e)
        {
            lodingButton5.Show();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                CustomerService.perform("pos/customers");
                lodingButton4.BeginInvoke(
             ((Action)(() => lodingButton5.Hide())));
            }).Start();
           
        }
    }
}
