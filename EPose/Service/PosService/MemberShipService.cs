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
    class MemberShipService
    {
        public static void perform(dynamic objInvoice = null)
        {
            ActivityLogModel objLog = new ActivityLogModel();
            dynamic log_invoices = null;
            
                log_invoices = objLog.where(objLog, "model='membership'");
           
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
            MemberShipModel member = new MemberShipModel();
            dynamic membership = member.find(member, log_invoice.ref_id);
            if (membership != null)
            {
                dynamic dataObject = new ExpandoObject();
                dataObject.id = log_invoice.id;
                dataObject.key = log_invoice.action;
                dataObject.trackable_id = membership.id;
                dataObject.trackable_type = log_invoice.model;
                if (log_invoice.action != "delete")
                {
                    dynamic data = new ExpandoObject();
                    data.point = membership.point;
                    data.last_point = membership.last_point;
                    dataObject.data = data;
                }
                json = JsonConvert.SerializeObject(dataObject);
            }
            return json;
        }
    }
}
