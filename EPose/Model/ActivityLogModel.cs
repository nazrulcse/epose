using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Model
{
    class ActivityLogModel
    {
        public string id { get; set; }
        public string model { get; set; }
        public string action { get; set; }
        public DateTime date { get; set; }
        public string ref_id { get; set; }
        public string department_id { get; set; }

        public string getTable()
        {
            return "activity_logs";
        }


        public Array attrAccess()
        {
            return new String[] { "id", "model", "action", "date", "ref_id", "department_id" };
        }
    }
}
