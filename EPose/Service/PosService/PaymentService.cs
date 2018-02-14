using EPose.Model;
using Newtonsoft.Json;
using Service;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Service.PosService
{
    class PaymentService
    {
        public static void perform(dynamic objInvoice = null)
        {
            ActivityLogModel objLog = new ActivityLogModel();
            dynamic log_invoices = null;
            log_invoices = objLog.where(objLog, "model='payment'");
            
            if (log_invoices.Count > 0)
            {
                List<string> activites = new List<string>();
                dynamic activityObject = new ExpandoObject();
                foreach (var log_invoice in log_invoices)
                {
                    String activity = paymentData(log_invoice);
                    activites.Add(activity);
                }

                dynamic postData = new ExpandoObject();
                postData.activities = activites;
                string json = JsonConvert.SerializeObject(postData);
                string response = WebAPI.postRequest("activities/offline_changes", json);
                ActivityLogModel.remove(response);
            }
            else
            {
                Console.WriteLine("Everything sync");
            }
        }

        public static string paymentData(dynamic log_invoice)
        {
            string json = "";
            PaymentModel pay = new PaymentModel();
            dynamic payment = pay.find(pay, log_invoice.ref_id);
            if (payment != null)
            {
                dynamic dataObject = new ExpandoObject();
                dataObject.id = log_invoice.id;
                dataObject.key = log_invoice.action;
                dataObject.trackable_id = payment.id;
                dataObject.trackable_type = log_invoice.model;
                if (log_invoice.action != "delete")
                {
                    dynamic data = new ExpandoObject();
                    data.global_id = payment.id;
                    data.payment_method = payment.payment_method;
                    data.department_id = payment.department_id;
                    data.customer_id = payment.customer_id;
                    data.invoice_global_id = payment.invoice_id;
                    data.amount = payment.amount;
                    data.transaction_token = payment.transaction_token;
                    data.date = payment.date;
                    dataObject.data = data;
                }
                json = JsonConvert.SerializeObject(dataObject);
            }
            return json;
        }
    }
}
