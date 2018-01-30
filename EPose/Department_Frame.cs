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
    public partial class Department_Frame : Layout_Frame
    {
        public Department_Frame()
        {
            InitializeComponent();
            this.setTitle("Department Window");
           
            //var employees = wp.syncEmployee();
            DepartmentModel depart = new DepartmentModel();
            dynamic departments = depart.all(depart);

            foreach (var department in departments) {

                departmentList.Rows.Add(department.id, department.name, department.description);
              
            }
            this.labelDepartment.Text = "" + departments.Count;
                       //  WebAPI wp = new WebAPI();


            // dynamic departments = wp.syncDepartment("/departments?company_id=1");

            //foreach( var department in departments) {
              //  departmentList.Rows.Add(department.id, department.name, department.description, department.company_id);
            //}

        }

        private void Department_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void employeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
