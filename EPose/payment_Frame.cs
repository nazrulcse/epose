using EPose.Model;
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
    public partial class payment_Frame : Layout_Frame
    {
        public payment_Frame()
        {
            InitializeComponent();
            this.setTitle("Payment Window");
            
            PaymentModel payment = new PaymentModel();
            payment.global_id = "111";
            payment.payment_type = "bikash";
            payment.invoice_id = "122";
            payment.amount = 23.4;
            payment.transaction_token = "7070";
            payment.create(payment);

            dynamic payments = payment.all(payment);
            foreach(var pay in payments){
                paymentList.Rows.Add(pay.global_id, pay.payment_type, pay.invoice_id, pay.amount, pay.transaction_token, pay.transaction_token);
            }

        }
    }
}
