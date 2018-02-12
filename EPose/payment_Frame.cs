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
        Invoice_Frame invoice_form;
        double netDue;
        public payment_Frame( dynamic invoice, Invoice_Frame invf)
        {
            InitializeComponent();
            this.setTitle("Payment Window"); 
            this.invoice = invoice;
            this.invoice_form = invf;
            this.netDue = invoice.net_total;
            this.ActiveControl = paymentType;
        }

        private void payment_Frame_Load(object sender, EventArgs e)
        {
            amountTextBox.Text = "" + netDue; 
        }

        private void paymentType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                var payment_type = this.paymentType.GetItemText(this.paymentType.SelectedItem);
                if (payment_type != "")
                {
                    amountTextBox.Focus();
                }
            }
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if(amountTextBox.Text != "") {
                    processPayment(amountTextBox.Text);
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.T))
            {
                paymentType.Focus();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.A))
            {
                amountTextBox.Focus();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private Boolean processPayment(String amount) {
            double paid_amount = Convert.ToDouble(amount);
            if (paid_amount > 0)
            {
                if (netDue > 0)
                {
                    DialogResult dialogResult = MessageDialog.Show("Confirm Payment", "Are you want to make the payment ");
                    if (dialogResult == DialogResult.Yes)
                    {
                        PaymentModel payment = new PaymentModel();
                        var ms = (DateTime.Now - DateTime.MinValue).TotalMilliseconds * 10;
                        payment.id = ms.ToString();
                        payment.payment_type = this.paymentType.GetItemText(this.paymentType.SelectedItem);
                        payment.invoice_id = invoice.id;
                        payment.amount = paid_amount;
                        payment.transaction_token = new Random().Next(1000) + invoice.id;
                        payment.date = DateTime.Today;
                        payment.create(payment);
                        bool status = ActivityLogModel.track("payment", "create", payment.id);
                        paymentList.Rows.Add(payment.id, payment.payment_type, payment.invoice_id, payment.amount, payment.transaction_token, payment.date);
                        netDue -= payment.amount;
                        netDue = Math.Round(netDue, 2);
                    }
                }
                else {
                    DialogResult result = MessageDialog.Show("Amount Paid!", "Invoice amount fully paid! Do you want to close payment form?");
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
            }
            else {
                if (netDue <= 0)
                {
                    DialogResult result = MessageDialog.Show("Amount Paid!", "Invoice amount fully paid! Do you want to close payment form?");
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else {
                    MessageBox.Show("Amount should not be 0");
                }
            }
            amountTextBox.Focus();
            amountTextBox.Text = "" + netDue;
            return true;
        }

        private void amountTextBox_Enter(object sender, EventArgs e)
        {
            changeColor(amountTextBox, "enter");
        }

        private void amountTextBox_Leave(object sender, EventArgs e)
        {
            changeColor(amountTextBox, "out");
        }
    }
}
