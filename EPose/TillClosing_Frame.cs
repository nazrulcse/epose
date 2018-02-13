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
        double totalCashPayment;
        double totalBkashPayment;
        double totalCashRocketPayment;
        double totalCardPayment;
        double totalPayment;

        public TillClosing_Frame()
        {
            InitializeComponent();

            PaymentModel payment = new PaymentModel();
            dynamic payments = payment.where(payment,"date = ");
            

        }

        private void TillClosing_Frame_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dd.MM.yyy");
        }



    }
}
