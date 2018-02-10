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
        public payment_Frame( dynamic invoice, Invoice_Frame invf)
        {
            InitializeComponent();
            this.ActiveControl = paymentType;
            this.setTitle("Payment Window"); 
            this.invoice = invoice;
            this.invoice_form = invf;
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


            ActivityLogModel log = new ActivityLogModel();
            log.model = "payment";
            log.action = "create";
            log.date = DateTime.Now;
            log.ref_id = payment.global_id;
            log.department_id = DepartmentSettings.DepartmentId;
;
            log.create(log);


            dynamic payments = payment.where(payment, "transaction_token =" + payment.transaction_token);
            paymentList.Rows.Clear();
            foreach (var pay in payments)
            {
                paymentList.Rows.Add(pay.global_id, pay.payment_type, pay.invoice_id, pay.amount, pay.transaction_token,pay.date);
            }
        }

        private void paymentType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                amountTextBox.Focus();
            }
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                if (amountTextBox.Text == "0.0")
                {
                    MessageBox.Show("Enter amount");
                    amountTextBox.Focus();
                }
                DialogResult dialogResult = MessageBox.Show("", "Are you want to pay??", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    button1.PerformClick();
                    this.invoice_form.paidAmount(amountTextBox.Text);
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    Console.WriteLine("No");
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

        private void amountTextBox_Enter(object sender, EventArgs e)
        {
            changeColor(amountTextBox, "enter");
            amountTextBox.Text = "";
        }

        private void amountTextBox_Leave(object sender, EventArgs e)
        {

        }

        
    }
}
