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
        String paymentType = "";
        String numberOfKeyBoard = "";
        public payment_Frame( dynamic invoice, Invoice_Frame invf)
        {
            InitializeComponent();
            this.setTitle("Payment Window"); 
            this.invoice = invoice;
            this.invoice_form = invf;
            this.netDue = invoice.net_total;
            this.ActiveControl = amountTextBox;
        }

        private void payment_Frame_Load(object sender, EventArgs e)
        {
            amountTextBox.Text = "" + netDue; 
        }

        private void paymentType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                var payment_type = this.paymentType;
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
                return true;
            }
            else if (keyData == (Keys.Control | Keys.A))
            {
                amountTextBox.Focus();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void selectPaymentType() {
          resetPaymentType();
          switch(paymentType) {
              case "Cash":
                  cashButton.BackColor = Color.FromArgb(92, 184, 92);
                  break;
              case "Mobile":
                  mobileButton.BackColor = Color.FromArgb(92, 184, 92);
                  break;
              case "Card":
                  cardButton.BackColor = Color.FromArgb(92, 184, 92);
                  break;
              case "Debit":
                  debitButton.BackColor = Color.FromArgb(92, 184, 92);
                  break;
          }
        }

        public void resetPaymentType() {
            cashButton.BackColor = Color.FromArgb(0, 165, 223);
            cardButton.BackColor = Color.FromArgb(0, 165, 223);
            debitButton.BackColor = Color.FromArgb(0, 165, 223);
            mobileButton.BackColor = Color.FromArgb(0, 165, 223);
        }

        private Boolean processPayment(String amount) {
            double paid_amount = Convert.ToDouble(amount);
            if (paid_amount > 0 && paid_amount <= netDue)
            {
                if (netDue > 0)
                {
                    DialogResult dialogResult = MessageDialog.Show("Confirm Payment", "Are you want to make the payment ");
                    if (dialogResult == DialogResult.Yes)
                    {
                        PaymentModel payment = new PaymentModel();
                        var ms = (DateTime.Now - DateTime.MinValue).TotalMilliseconds * 10;
                        payment.id = ms.ToString();
                        if (this.paymentType == "")
                        {
                            payment.payment_type = "Cash";
                        }
                        else
                        {
                         payment.payment_type = this.paymentType;
                        }
                        payment.invoice_id = invoice.id;
                        payment.amount = paid_amount;
                        payment.transaction_token = new Random().Next(1000) + invoice.id;
                        payment.date = DateTime.Now.ToString("yyyy-MM-dd");
                        payment.create(payment);
                        bool status = ActivityLogModel.track("payment", "create", payment.id);
                        if (status)
                        {
                            paymentList.Rows.Add(payment.id, payment.payment_type, payment.invoice_id, payment.amount, payment.transaction_token, payment.date);
                            netDue -= payment.amount;
                            netDue = Math.Round(netDue, 2);
                        }
                        else {
                            MessageDialog.ShowAlert("Unable to make payment! Please try again or contact admin", "Alert Message", "error");
                        }
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
                    MessageBox.Show("Amount should not be 0 or grater than due amount");
                
            }
            if (netDue <= 0)
                {
                    DialogResult result = MessageDialog.Show("Amount Paid!", "Invoice amount fully paid! Do you want to close payment form?");
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
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
        private void cashButton_Click(object sender, EventArgs e)
        {
            paymentType = "Cash";
            selectPaymentType();
        }

        private void mobileButton_Click(object sender, EventArgs e)
        {
            paymentType = "Mobile";
            selectPaymentType();
        }

        private void debitButton_Click(object sender, EventArgs e)
        {
            paymentType = "Debit";
            selectPaymentType();
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            paymentType = "Card";
            selectPaymentType();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            amountTextBox.Text = "";
            numberOfKeyBoard = "";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            numberOfKeyBoard = numberOfKeyBoard + 0;
            amountTextBox.Text = numberOfKeyBoard;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            numberOfKeyBoard = numberOfKeyBoard + 1;
            amountTextBox.Text = numberOfKeyBoard;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            numberOfKeyBoard = numberOfKeyBoard + 3;
            amountTextBox.Text = numberOfKeyBoard;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            numberOfKeyBoard = numberOfKeyBoard + 2;
            amountTextBox.Text = numberOfKeyBoard;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            numberOfKeyBoard = numberOfKeyBoard + 4;
            amountTextBox.Text = numberOfKeyBoard;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            numberOfKeyBoard = numberOfKeyBoard + 5;
            amountTextBox.Text = numberOfKeyBoard;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            numberOfKeyBoard = numberOfKeyBoard + 6;
            amountTextBox.Text = numberOfKeyBoard;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            numberOfKeyBoard = numberOfKeyBoard + 7;
            amountTextBox.Text = numberOfKeyBoard;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            numberOfKeyBoard = numberOfKeyBoard + 8;
            amountTextBox.Text = numberOfKeyBoard;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            numberOfKeyBoard = numberOfKeyBoard + 9;
            amountTextBox.Text = numberOfKeyBoard;
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            numberOfKeyBoard = numberOfKeyBoard + ".";
            amountTextBox.Text = numberOfKeyBoard;
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text != "")
            {
                processPayment(amountTextBox.Text);
            }
        }
    }
}
