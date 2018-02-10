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

namespace Service
{
    class WebAPI
    {
        //public const string API = "http://accounts.tangailenterprise.com";
        public const string API = "http://159.89.170.58/api/v1/";
        public static HttpResponseMessage getRequest(String action_url, String model)
        {
            string URL = API + "" + action_url;
            string urlParameters = "?department_id=1";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            Console.WriteLine("API URL: " + URL);
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            // List data response.
            try {
                HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
                return response;
            }
            catch( Exception ex){
                MessageBox.Show("Error: " + ex.Message.ToString());
                return client.GetAsync(urlParameters).Result;
            }
        }
    }
}
