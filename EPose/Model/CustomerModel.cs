using EPose.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Model
{
    class CustomerModel : ActiveRecord
    {

        public string id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string department_id { get; set; }
        public double initial_balance { get; set; }
        public double credit_limit { get; set; }
        public string action { get; set; }
        public string log_id { get; set; }


        public string getTable()
        {
            return "customers";
        }

        public Array attrAccess()
        {
            return new String[] { "id", "name", "company", "address", "city", "email", "mobile", "department_id", "initial_balance", "credit_limit", "action", "log_id" };
        }
    }
}
