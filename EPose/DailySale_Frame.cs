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
            invoiceList.AllowUserToAddRows = false;
        }

        private void DailySale_Frame_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            loadSales(date);
            loadDailyTransaction();
            loadInvoice();
        }



        public void loadSales(string date)
        {
            PaymentModel pay = new PaymentModel();
            //string date = DateTime.Now.ToString("yyyy-MM-dd");
            dynamic payments = pay.where(pay, "date = '" + date + "'");

            if (payments.Count > 0)
            {
                foreach (var payment in payments)
                {
                    totalPayment += payment.amount;
                    String type = payment.payment_method;
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

        public void loadDailyTransaction()
        {

            dateLabel.Text = DateTime.Now.ToString("dd.MM.yyy");
            PaymentModel pay = new PaymentModel();
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            dynamic payments = pay.where(pay, "date = '" + date + "'");

            if (payments.Count > 0)
            {
                foreach (var payment in payments)
                {
                    paymentList.Rows.Add(payment.id, payment.payment_method, payment.invoice_id, payment.amount, payment.transaction_token, payment.date);
                }
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            String searchValue = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            InvoiceModel inv = new InvoiceModel();
            dynamic invoices = inv.where(inv, "till_id = '" + DepartmentSettings.TillId + "' and date ='" + searchValue + "'");

            if (invoices.Count > 0)
            {
                string invoiceIds = null;
                foreach (var invoice in invoices)
                {
                    invoiceIds += "," + invoice.id;
                }

                string Ids = invoiceIds.Substring(1);
                PaymentModel pay = new PaymentModel();
                dynamic payments = pay.where(pay, "invoice_id in(" + Ids + ")");

                if (payments.Count > 0)
                {
                    loadSales(searchValue);
                    paymentList.Rows.Clear();
                    foreach (var payment in payments)
                    {
                        paymentList.Rows.Add(payment.id, payment.payment_method, payment.invoice_id, payment.amount, payment.transaction_token, payment.date);
                    }
                }
            }
            else
            {
                paymentList.Rows.Clear();
                totalLabel.Text = "";
                cardLabel.Text = "";
                mobileLabel.Text = "";
                debitLabel.Text = "";
                cashSaleLabel.Text = "";
            }
        }

        public void loadInvoice()
        {
            InvoiceModel inv = new InvoiceModel();
            dynamic invoices = inv.all(inv);
            loadInvoiceData(invoices);
        }

        private void dateTimePickerSearchInvoice_ValueChanged(object sender, EventArgs e)
        {
             String searchValue = dateTimePickerSearchInvoice.Value.ToString("yyyy-MM-dd");
            InvoiceModel inv = new InvoiceModel();
            dynamic invoices = inv.where(inv," date ='" + searchValue + "'");

            loadInvoiceData(invoices);
        }

        private void textBoxSearchInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string number = textBoxSearchInvoice.Text;
                InvoiceModel inv = new InvoiceModel();
                dynamic invoices = inv.where(inv, "lower(number) like '%" + number.ToLower() + "%'");
                loadInvoiceData(invoices);
            }
        }

        public void loadInvoiceData(dynamic invoices) {
          if (invoices.Count > 0)
                {
                    invoiceList.Rows.Clear();
                    foreach (dynamic invoice in invoices)
                    {
                        string paymentType = "";
                        PaymentModel pay = new PaymentModel();
                        dynamic payments = pay.where(pay, "invoice_id ='" + invoice.id + "'");
                        if (payments.Count > 0)
                        {
                            foreach (var payment in payments)
                            {
                                paymentType += (paymentType == "" ? payment.payment_method : "," + payment.payment_method);
                            }
                        }
                        invoiceList.Rows.Add(invoice.id, invoice.number, invoice.customer_id, invoice.date.ToString("yyyy-MM-dd"), invoice.net_total, paymentType);
                    }
                }
                else
                {
                    invoiceList.Rows.Clear();
                    MessageDialog.ShowAlert("Invoice not found");
                }
        }

        private void textBoxSearchInvoice_Leave(object sender, EventArgs e)
        {
            changeColor(textBoxSearchInvoice, "out");
           
        }

        private void textBoxSearchInvoice_Enter(object sender, EventArgs e)
        {
            changeColor(textBoxSearchInvoice, "enter");
        }

        private void invoiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageDialog.Show("Print!", "Are you want to print the receipt now!", "print");
            if (result == DialogResult.Yes)
            {
                 int SelectedRow = invoiceList.CurrentCell.RowIndex;
                 dynamic cellValue = invoiceList.Rows[SelectedRow].Cells["invoiceNo"].Value;
                 string invoiceNumber = Convert.ToString(cellValue);
                 InvoiceModel inv = new InvoiceModel();
                 dynamic invoices = inv.find_by(inv, "number" ,invoiceNumber);

                 if (invoices != null) {
                     new PrinterSelect_Frame(invoices).Show();
                 }

                
            }
        }
    }
}
