using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPose.Model;
using System.Net.Http;
using Service;
using System.Windows.Forms;

namespace EPose.Service.Sync
{
    class DownStream
    {
        public static IEnumerable<DepartmentModel> syncDepartment()
        {
            HttpResponseMessage response = WebAPI.getRequest("departments", "deparments");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<DepartmentModel>>().Result;
            }
            else
            {
                MessageBox.Show("Api response with status: " + (int)response.StatusCode);
                return response.Content.ReadAsAsync<IEnumerable<DepartmentModel>>().Result;
            }
        }

        public static IEnumerable<EmployeeModel> syncEmployee()
        {
            HttpResponseMessage response = WebAPI.getRequest("/api/users", "users");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<EmployeeModel>>().Result;
            }
            else
            {
                MessageBox.Show("Api response with status: " + (int)response.StatusCode);
                return response.Content.ReadAsAsync<IEnumerable<EmployeeModel>>().Result;
            }
        }
    }
}
