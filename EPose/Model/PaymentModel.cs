using EPose.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Model
{
    class PaymentModel : ActiveRecord
    {
        public string id { get; set; }
        public string payment_type { get; set; }
        public string invoice_id { get; set; }
        public double amount { get; set; }
        public string transaction_token { get; set; }
        public DateTime date { get; set; }


        public string getTable()
        {
            return "payments";
        }

        public Array attrAccess()
        {
            return new String[] { "id", "payment_type", "invoice_id", "amount", "transaction_token", "date"};
        }
    }


}
