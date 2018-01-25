using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Service
{
    class WebAPI
    {
        public const string API = "http://accounts.tangailenterprise.com";
        //public const string API = "http://192.168.0.113:3001";
        public HttpResponseMessage getRequest(String api, String model)
        {
            const string URL = API + "/api/users";
            string urlParameters = "?api_key=123";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            return response;
        }

        public IEnumerable<Employee> syncEmployee()
        {
            HttpResponseMessage response = this.getRequest("/api/users", "users");  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Employee>>().Result;
                //Console.WriteLine("" + dataObjects.GetType());
                //foreach (var obj in dataObjects)
                //{
                    //Console.WriteLine("" + obj.id);
                //}
            }
            else
            {
                MessageBox.Show("Api response with status: " + (int)response.StatusCode);
                return response.Content.ReadAsAsync<IEnumerable<Employee>>().Result;
            }
        }

    }
}
