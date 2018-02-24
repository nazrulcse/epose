using EPose.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Model
{
    class TillClosingModel : ActiveRecord
    {
        public int id { get; set; }
        public double cash_in_drawer { get; set; }
        public double total_sale_mount { get; set; }
        public double difference { get; set; }
        public double initial_balance { get; set; }
        public string till_id { get; set; }
        public dynamic date { get; set; }

        public string getTable()
        {
            return "tillClosings";
        }

        public Array attrAccess()
        {
            return new String[] { "cash_in_drawer", "total_sale_mount", "difference", "initial_balance", "till_id", "date" };
        }
        

    }
}
