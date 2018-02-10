using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPose.Orm;

namespace EPose.Model
{
    class EmployeeModel : ActiveRecord
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string login_id { get; set; }
        public string image { get; set; }
        public string mobile { get; set; }
        public string present_address { get; set; }
        public string country { get; set; }
        public string department { get; set; }
        public string department_id { get; set; }
        public string designation { get; set; }
        public string action { get; set; }
        public DateTime joining_date { get; set; }
        public bool is_active { get; set; }
        public string log_id { get; set; }
        

        public string getTable()
        {
            return "employees";
        }

        public Array attrAccess() {
            return new String[] { "id", "name", "email", "password", "image", "mobile", "present_address", "country", "department", "department_id", "designation", "joining_date", "is_active", "login_id" };
        }
    }
}
