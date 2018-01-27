﻿using EPose.Orm;
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
        public DateTime date { get; set; }
        public string customer_id { get; set; }

        public string getTable() {
            return "invoices";
        }

        public Array attrAccess()
        {
            return new String[] { "id", "number", "department_id", "barcode", "date", "customer_id" };
        }
    }
}