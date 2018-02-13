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
    public partial class TillClosing_Frame : Layout_Frame
    {
        double totalCashPayment = 0.0;
        double totalBkashPayment = 0.0;
        double totalRocketPayment = 0.0;
        double totalCardPayment =  0.0;
        double totalPayment = 0.0;

        public TillClosing_Frame()
        {
            InitializeComponent();

            PaymentModel pay = new PaymentModel();
            dynamic payments = pay.where(pay,"date = ");

            if(payments.Count>0){
              
                foreach(var payment in payments){
                    totalPayment += payment.amount;
                    String type = payment.payment_type;
                    switch (type)
                 {
                   case "Cash":
                            totalCardPayment =+ payment.amount;
                          break;
                   case "Bikash":
                          totalBkashPayment =+ payment.amount;
                           break;
                   case "Card":
                           totalCardPayment =+ payment.amount;
                           break;
                   case "Rocket":
                           totalRocketPayment =+ payment.amount;
                           break;
                    default: 
                       break;
                 }
                }
            }

            cashSaleLabel.Text = "" + totalCashPayment;
            

        }

        private void TillClosing_Frame_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dd.MM.yyy");
        }



    }
}
