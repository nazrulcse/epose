using EPose.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Model
{
    class DepartmentModel : ActiveRecord
    {

        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string company_id { get; set; }
        public string action { get; set; }
        public string log_id { get; set; }


        public string getTable()
        {
            return "departments";
        }


        public Array attrAccess()
        {
            return new String[] { "id", "name", "address", "company_id" };
        }

    }
}
