using EPose.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Model
{
    class MemberShipModel : ActiveRecord
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public double point { get; set; }
        public string code { get; set; }
        public string last_point { get; set; }
        public bool is_active { get; set; }
        public string action { get; set; }
        public string log_id { get; set; }
        

        public string getTable()
        {
            return "memberships";
        }

        public Array attrAccess() {
            return new String[] { "id", "name", "email", "mobile", "address", "point", "code", "last_point", "is_active", "action" };
        }
    }
}
