using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPose.Model;
using System.Net.Http;
using Service;
using System.Windows.Forms;
using System.Threading;
using EPose.Service.WebService;

namespace EPose.Service.Sync
{
    class DownStream
    {
        public static IEnumerable<DepartmentModel> syncDepartment(string url)
        {
            HttpResponseMessage response = WebAPI.getRequest(url, "deparments");  // Blocking call!
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

        public static IEnumerable<EmployeeModel> syncEmployee(string url)
        {
            HttpResponseMessage response = WebAPI.getRequest(url, "employees");  // Blocking call!
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

        public static IEnumerable<SupplierModel> syncSupplier(string url)
        {
            HttpResponseMessage response = WebAPI.getRequest(url, "suppliers");  // Blocking call!
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
        public static IEnumerable<ProductModel> syncProduct(string url)
        {
            HttpResponseMessage response = WebAPI.getRequest(url, "products");  // Blocking call!
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

        public static IEnumerable<MemberShipModel> syncMemberships(string url)
        {
            HttpResponseMessage response = WebAPI.getRequest(url, "memberships");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<MemberShipModel>>().Result;
            }
            else
            {
                MessageBox.Show("Api response with status: " + (int)response.StatusCode);
                return response.Content.ReadAsAsync<IEnumerable<MemberShipModel>>().Result;
            }
        }



        public static IEnumerable<CustomerModel> syncCustomer(string url)
        {
            HttpResponseMessage response = WebAPI.getRequest(url, "customers");  // Blocking call!
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



        public static void perform()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Console.WriteLine("Thread running......");
               CustomerService.perform();
               DepartmentService.perform();
               EmployeeService.perform();
                MemberShipWebService.perform();
               ProductService.perform();
               SupplierService.perform();
            }).Start();
        }
    }
}
