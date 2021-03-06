﻿using EPose.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPose
{
    public partial class PaymentList_Frame : Layout_Frame
    {
        public PaymentList_Frame()
        {
            InitializeComponent();
            setTitle("Todays Payment List");
            PaymentModel pay = new PaymentModel();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            dynamic payments = pay.where(pay, "date = '" + date + "'");
            if(payments.Count>0){
                foreach (var payment in payments)
                {
                    paymentList.Rows.Add(payment.id, payment.payment_method, payment.invoice_id, payment.amount, payment.transaction_token, payment.date);
                }
            }
        }
    }
}
