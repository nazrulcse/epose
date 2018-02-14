using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPose.Orm;

namespace EPose.Model
{
    class InvoiceItemModel : ActiveRecord
    {
        public string id { get; set; }
        public string name { get; set; }
        public string invoice_id { get; set; }
        public string product_id { get; set; }
        public double price { get; set; }
        public dynamic date { get; set; }
        public double total { get; set; }
        public float quantity { get; set; }
        public string unit { get; set; }
        public double vat { get; set; }
        public double discount { get; set; }

        public string getTable()
        {
            return "invoice_items";
        }

        public Array attrAccess()
        {
            return new String[] { "id", "vat", "name", "invoice_id", "price", "total", "quantity", "unit", "discount", "product_id"};
        }
    }
}
