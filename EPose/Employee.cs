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
    public partial class Employee : Layout
    {
        public Employee()
        {
            InitializeComponent();
            WebAPI wp = new WebAPI();
            var employees = wp.syncEmployee();
            foreach (var employee in employees)
            {
                employeeList.Rows.Add(employee.id, employee.departmentId, employee.employee);
            }
        }

        private void employeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
