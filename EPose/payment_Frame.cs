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

        dynamic invoice;
        public payment_Frame( dynamic invoice)
        {
            InitializeComponent();
            this.setTitle("Payment Window"); 
            this.invoice = invoice;
        }

        private void payment_Frame_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            PaymentModel payment = new PaymentModel();
            payment.global_id = "111";
            payment.payment_type = this.paymentType.GetItemText(this.paymentType.SelectedItem);
            payment.invoice_id = invoice.id;
            payment.amount = Convert.ToDouble(amountTextBox.Text);
            payment.transaction_token =  new Random().Next(1000)+invoice.id;
            payment.date = DateTime.Today; ;
            payment.create(payment);

            dynamic payments = payment.all(payment);
            paymentList.Rows.Clear();
            foreach (var pay in payments)
            {
                paymentList.Rows.Add(pay.global_id, pay.payment_type, pay.invoice_id, pay.amount, pay.transaction_token,pay.date);
            }
        }

       
    }
}
