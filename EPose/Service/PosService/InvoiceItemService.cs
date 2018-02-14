using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPose.Orm;
using EPose.Model;
using Newtonsoft.Json;
using System.Dynamic;
using Service;

namespace EPose.Service.PosService
{
    class InvoiceItemService
    {
        public static void perform(dynamic objInvoice = null)
        {
            ActivityLogModel objLog = new ActivityLogModel();
            dynamic log_invoices = null;
            log_invoices = objLog.where(objLog, "model='invoice_item'");
            if (log_invoices.Count > 0)
            {
                List<string> activites = new List<string>();
                dynamic activityObject = new ExpandoObject();
                foreach (var log_invoice in log_invoices)
                {
                    String activity = invoiceItemData(log_invoice);
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

        public static string invoiceItemData(dynamic log_invoice)
        {
            string json = "";
            InvoiceItemModel invitem = new InvoiceItemModel();
            dynamic invoice_item = invitem.find(invitem, log_invoice.ref_id);
            if (invoice_item != null)
            {
                dynamic dataObject = new ExpandoObject();
                dataObject.id = log_invoice.id;
                dataObject.key = log_invoice.action;
                dataObject.trackable_id = invoice_item.id;
                dataObject.trackable_type = log_invoice.model;
                if (log_invoice.action != "delete")
                {
                    dynamic data = new ExpandoObject();
                    data.global_id = invoice_item.id;
                    data.name = invoice_item.name;
                    data.date = invoice_item.date;
                    data.invoice_global_id = invoice_item.invoice_id;
                    data.product_id = invoice_item.product_id;
                    data.price = invoice_item.price;
                    data.total = invoice_item.total;
                    data.quantity = invoice_item.quantity;
                    data.unit = invoice_item.unit;
                    data.vat = invoice_item.vat;
                    data.discount = invoice_item.discount;
                    dataObject.data = data;
                }
                json = JsonConvert.SerializeObject(dataObject);
            }
            return json;
        }
    }
}
