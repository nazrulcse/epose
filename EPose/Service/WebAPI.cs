using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Data.SqlClient;
using EPose.Model;
using EPose;
using Newtonsoft.Json.Linq;

namespace Service
{
    class WebAPI
    {

        public const string API = "http://a422bb11.ngrok.io/api/v1/";
        public static HttpResponseMessage getRequest(String action_url, String model)
        {
            DepartmentSettings.getData();
            string URL = API + "" + action_url;
            string urlParameters = "?department_id=" + DepartmentSettings.DepartmentId;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            Console.WriteLine("API URL: " + URL);
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            // List data response.
            try
            {
                HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
                return client.GetAsync(urlParameters).Result;
            }
        }

        public static string postRequest(String action_url, String data)
        {
            string URL = API + "" + action_url;
            var client = new HttpClient();
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(URL, content).Result;

            if (response.IsSuccessStatusCode) {
                string contentx = response.Content.ReadAsStringAsync().Result;
                return contentx;
            }
            return "";
        }
    }
}