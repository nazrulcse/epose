using EPose.Model;
using Service;
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
    public partial class Employee_Frame : Layout_Frame
    {
        public Employee_Frame()
        {
            InitializeComponent();
            this.setTitle("Employee Window");
            //WebAPI wp = new WebAPI();
            //var employees = wp.syncEmployee();
            EmployeeModel emp = new EmployeeModel();
            dynamic employees = emp.all(emp);
            foreach (var employee in employees)
            {
                employeeList.Rows.Add(employee.name, employee.designation, employee.email, employee.mobile, employee.present_address, employee.country, employee.department, employee.joining_date);
            }

            this.employeeLabel.Text = "" + employees.Count;
        }

         private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String searchValue = searchBox.Text;
            EmployeeModel emp = new EmployeeModel();
                dynamic employees = emp.where(emp, "name like '%" + searchValue + "%'");
                if (employees.Count > 0)
                {
                    
                    this.employeeLabel.Text = "" + employees.Count;
                    employeeList.Rows.Clear();
                    foreach (var employee in employees)
                    {
                        employeeList.Rows.Add(employee.name, employee.designation, employee.email, employee.mobile, employee.present_address, employee.country, employee.department, employee.joining_date);
                    }
                }
            
        }
  
    }
}
