using EPose.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Model
{
    class SupplierModel : ActiveRecord
    {
        public string id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string department_id { get; set; }
        public bool is_active { get; set; }
        public string log_id { get; set; }


        public string getTable()
        {
            return "suppliers";
        }

        public Array attrAccess()
        {
            return new String[] { "id", "name", "company", "address", "city", "email", "mobile", "department_id", "is_active", "log_id" };
        }
    }
}
