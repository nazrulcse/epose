using EPose.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Model
{
    class InvoiceModel : ActiveRecord
    {
        public string id { get; set; }
        public string number { get; set; }
        public string department_id { get; set; }
        public string barcode { get; set; }
        public dynamic date { get; set; }
        public string customer_id { get; set; }
        public string till_id { get; set; }
        public double invoice_total { get; set; }
        public double vat { get; set; }
        public double discount { get; set; }
        public double net_total { get; set; }
        public Boolean is_paid { get; set; }
        public Boolean is_credit { get; set; }
        public double net_due { get; set; }
        public double point { get; set; }
        public double lastPoint { get; set; }

        public string getTable() {
            return "invoices";
        }

        public Array attrAccess()
        {
            return new String[] { "id", "number", "department_id", "barcode", "date", "customer_id", "till_id", "invoice_total", "vat", "discount", "net_total", "is_credit" };
        }
    }
}
