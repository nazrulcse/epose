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
    class InvoiceService
    {
        public static void perform(dynamic objInvoice = null)
        {
            ActivityLogModel objLog = new ActivityLogModel();
            dynamic log_invoices = null;
            if (objInvoice != null)
            {
                log_invoices = objLog.where(objLog, "invoice_id='" + objInvoice.id + "'");
            }
            else
            {
                log_invoices = objLog.where(objLog, "model='invoice'");
            }
            if (log_invoices.Count > 0)
            {
                List<string> activites = new List<string>();
                dynamic activityObject = new ExpandoObject();
                foreach (var log_invoice in log_invoices)
                {
                    String activity = invoiceData(log_invoice);
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

        public static string invoiceData(dynamic log_invoice)
        {
            string json = "";
            InvoiceModel inv = new InvoiceModel();
            dynamic invoice = inv.find(inv, log_invoice.ref_id);
            if (invoice != null)
            {
                dynamic dataObject = new ExpandoObject();
                dataObject.id = log_invoice.id;
                dataObject.key = log_invoice.action;
                dataObject.trackable_id = invoice.id;
                dataObject.trackable_type = log_invoice.model;
                if (log_invoice.action != "delete")
                {
                    dynamic data = new ExpandoObject();
                    data.global_id = invoice.id;
                    data.number = invoice.number;
                    data.date = invoice.date;
                    data.invoice_total = invoice.invoice_total;
                    data.discount = invoice.discount;
                    data.vat = invoice.vat;
                    data.till_id = invoice.till_id;
                    data.net_total = invoice.net_total;
                    data.department_id = invoice.department_id;
                    data.customer_id = invoice.customer_id;
                    dataObject.data = data;
                }
                json = JsonConvert.SerializeObject(dataObject);
            }
            return json;
        }
    }
}
