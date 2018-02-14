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
    public partial class DailySale_Frame : Layout_Frame
    {
        double totalCashPayment = 0.0;
        double mobilePayment = 0.0;
        double debitPayment = 0.0;
        double totalCardPayment = 0.0;
        double totalPayment = 0.0;

        public DailySale_Frame()
        {
            InitializeComponent();
            setTitle("Daily Sales Report");
        }

        private void DailySale_Frame_Load(object sender, EventArgs e)
        {
            loadSales();
            loadDailyTransaction();
        }



        public void loadSales()
        {
            PaymentModel pay = new PaymentModel();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            dynamic payments = pay.where(pay, "date = '" + date + "'");

            if (payments.Count > 0)
            {
                foreach (var payment in payments)
                {
                    totalPayment += payment.amount;
                    String type = payment.payment_type;
                    switch (type)
                    {
                        case "Cash":
                            totalCashPayment += payment.amount;
                            break;
                        case "Mobile":
                            mobilePayment += payment.amount;
                            break;
                        case "Card":
                            totalCardPayment += payment.amount;
                            break;
                        case "Debit":
                            debitPayment += payment.amount;
                            break;
                        default:
                            break;
                    }
                }
            }
            totalLabel.Text = "" + Math.Round(totalPayment, 2);
            cardLabel.Text = "" + Math.Round(totalCardPayment, 2);
            mobileLabel.Text = "" + Math.Round(mobilePayment, 2);
            debitLabel.Text = "" + Math.Round(debitPayment, 2);
            cashSaleLabel.Text = "" + Math.Round(totalCashPayment, 2);
        }

        public void loadDailyTransaction() { 
        
             dateLabel.Text = DateTime.Now.ToString("dd.MM.yyy");
             PaymentModel pay = new PaymentModel();
             string date = DateTime.Now.ToString("yyyy-MM-dd");
             dynamic payments = pay.where(pay, "date = '" + date + "'");

             if (payments.Count > 0)
             {
                 foreach (var payment in payments)
                 {
                     paymentList.Rows.Add(payment.id, payment.payment_type, payment.invoice_id, payment.amount, payment.transaction_token, payment.date);
                 }
             }
        }
    }
}
