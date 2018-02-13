using EPose.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Model
{
    class CurrencyItemModel : ActiveRecord
    {
        public int id { get; set; }
        public string name { get; set; }
        public double value { get; set; }


        public string getTable()
        {
            return "currency_items";
        }

        public Array attrAccess()
        {
            return new String[] { "id", "name", "value" };
        }
    }
}
