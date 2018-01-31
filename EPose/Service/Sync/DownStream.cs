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
            HttpResponseMessage response = WebAPI.getRequest("employees", "employees");  // Blocking call!
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

        public static IEnumerable<SupplierModel> syncSupplier()
        {
            HttpResponseMessage response = WebAPI.getRequest("pos/suppliers", "suppliers");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<SupplierModel>>().Result;
            }
            else
            {
                MessageBox.Show("Api response with status: " + (int)response.StatusCode);
                return response.Content.ReadAsAsync<IEnumerable<SupplierModel>>().Result;
            }
        }
        public static IEnumerable<ProductModel> syncProduct()
        {
            HttpResponseMessage response = WebAPI.getRequest("pos/products", "products");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<ProductModel>>().Result;
            }
            else
            {
                MessageBox.Show("Api response with status: " + (int)response.StatusCode);
                return response.Content.ReadAsAsync<IEnumerable<ProductModel>>().Result;
            }
        }

        public static IEnumerable<CustomerModel> syncCustomer()
        {
            HttpResponseMessage response = WebAPI.getRequest("pos/customers", "customers");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<CustomerModel>>().Result;
            }
            else
            {
                MessageBox.Show("Api response with status: " + (int)response.StatusCode);
                return response.Content.ReadAsAsync<IEnumerable<CustomerModel>>().Result;
            }
        }


       


    }
}
