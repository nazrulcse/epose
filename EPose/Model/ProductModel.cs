using EPose.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Model
{
    class ProductModel : ActiveRecord
    {
        public string id { get; set; }
        public string barcode { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string department { get; set; }
        public string category { get; set; }
        public string sub_category { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
        public int re_order_level { get; set; }
        public double cost_price { get; set; }
        public double sale_price { get; set; }
        public bool expirable { get; set; }
        public bool discountable { get; set; }
        public int stock { get; set; }
        public bool is_active { get; set; }
        public string log_id { get; set; }
        public string action { get; set; }



        public string getTable()
        {
            return "products";
        }

        public Array attrAccess()
        {
            return new String[] { "id", "barcode", "name", "description", "department", "category", "sub_category", "model", "brand", "re_order_level", "cost_price", "sale_price", "expirable", "discountable", "stock", "is_active" };
        }
    }
}
