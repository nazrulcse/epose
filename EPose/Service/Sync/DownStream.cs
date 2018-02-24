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
        public static object syncDepartment(string url)
        {
            HttpResponseMessage response = WebAPI.getRequest(url, "deparments");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<DepartmentModel>>().Result;
            }
            else
            {
                Console.WriteLine("Api response with status: " + (int)response.StatusCode);
                return  new List<DepartmentModel>();;
            }
        }

        public static object syncEmployee(string url)
        {
            HttpResponseMessage response = WebAPI.getRequest(url, "employees");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<EmployeeModel>>().Result;
            }
            else
            {
                Console.WriteLine("Api response with status: " + (int)response.StatusCode);
                return new List<EmployeeModel>();
            }
        }

        public static object syncSupplier(string url)
        {
            HttpResponseMessage response = WebAPI.getRequest(url, "suppliers");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<SupplierModel>>().Result;
            }
            else
            {
                Console.WriteLine("Api response with status: " + (int)response.StatusCode);
                return new List<SupplierModel>();
            }
        }
        public static object syncProduct(string url)
        {
            HttpResponseMessage response = WebAPI.getRequest(url, "products");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<ProductModel>>().Result;
            }
            else
            {
                Console.WriteLine("Api response with status: " + (int)response.StatusCode);
                return new List<ProductModel>();
            }
        }

        public static object syncMemberships(string url)
        {
            HttpResponseMessage response = WebAPI.getRequest(url, "memberships");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<MemberShipModel>>().Result;
            }
            else
            {
                Console.WriteLine("Api response with status: " + (int)response.StatusCode);
                return new List<MemberShipModel>();
            }
        }

        public static object syncCustomer(string url)
        {
            HttpResponseMessage response = WebAPI.getRequest(url, "customers");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<CustomerModel>>().Result;
            }
            else
            {
                Console.WriteLine("Api response with status: " + (int)response.StatusCode);
                return new List<CustomerModel>();
            }
        }

        public static void perform()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Console.WriteLine("Thread running......");
                //CustomerService.perform();
                //DepartmentService.perform();
                //EmployeeService.perform();
                //MemberShipWebService.perform();
                ProductService.perform();
                //SupplierService.perform();
            }).Start();
        }
    }
}
