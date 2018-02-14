using EPose.Orm;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Model
{
    class ActivityLogModel : ActiveRecord
    {
        public int id { get; set; }
        public string model { get; set; }
        public string action { get; set; }
        public dynamic date { get; set; }
        public string ref_id { get; set; }
        public string department_id { get; set; }

        public string getTable()
        {
            return "activity_logs";
        }

        public static Boolean track(String model, String action, String ref_id) {
            ActivityLogModel log = new ActivityLogModel();
            log.model = model;
            log.action = action;
            log.date = DateTime.Now;
            log.ref_id = ref_id;
            log.department_id = DepartmentSettings.DepartmentId;
            dynamic status = log.create(log);
            return status != null;
        }

        public static void remove(string responseObject) {
            try {
                JObject json = JObject.Parse(responseObject);
                //string ids = responseObject.data;
                Console.WriteLine("Response data: " + json.GetValue("data"));
            }
            catch(Exception ex) {

            }
        }

        public Array attrAccess()
        {
            return new String[] { "id", "model", "action", "date", "ref_id", "department_id" };
        }
    }
}
