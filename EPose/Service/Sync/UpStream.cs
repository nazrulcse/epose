using EPose.Service.PosService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EPose.Service.Sync
{
    class UpStream
    {
        public static void webAcknowledgement(String log_ids) {
            if (log_ids != "")
            {
                log_ids = log_ids.Substring(0, (log_ids.Length - 1));
                DepartmentSettings.getData();
                String API = "http://159.89.170.58/api/v1";
                string URL = API + "" + "/activities/remove";
                string urlParameters = "?department_id=" + DepartmentSettings.DepartmentId + "&activity_ids=" + log_ids;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(URL);
                Console.WriteLine("API URL: " + URL + urlParameters);
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                // List data response.
                try
                {
                    HttpResponseMessage response = client.DeleteAsync(urlParameters).Result;  // Blocking call!
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message.ToString());
                }
            }
        }

        public static void perform() {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Console.WriteLine("Thread running......");
                InvoiceService.perform();
                InvoiceItemService.perform();
                PaymentService.perform();
                MemberShipService.perform();
            }).Start();
        }
    }
}
