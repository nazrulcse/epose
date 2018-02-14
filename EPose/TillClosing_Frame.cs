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
using EPose.Model;

namespace EPose
{
    public partial class TillClosing_Frame : Layout_Frame
    {
        double totalCashPayment = 0.0;
        double mobilePayment = 0.0;
        double debitPayment = 0.0;
        double totalCardPayment =  0.0;
        double totalPayment = 0.0;
        double totalSalesDrawer = 0;

        public TillClosing_Frame()
        {
            InitializeComponent();
        }

        private void TillClosing_Frame_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dd.MM.yyy");
            loadSales();
            loadCurrencySettings();
        }

        private void loadCurrencySettings() {
            CurrencyItemModel cim = new CurrencyItemModel();
            dynamic items = cim.all(cim);
            foreach (var item in items) {
                currencySettings.Rows.Add(item.value, item.name, 0);
            }
        }

        public void loadSales() {
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

        private void calculateCash() {
            totalSalesDrawer = 0;
            try {
                foreach (dynamic row in currencySettings.Rows)
                {
                    Console.WriteLine(row.Cells[0].Value.ToString());
                    totalSalesDrawer += Convert.ToDouble(row.Cells[0].Value.ToString()) * Int32.Parse(row.Cells[2].Value.ToString());
                }
            }
            catch(Exception ex) {
                MessageDialog.ShowAlert("Something wrong! Please enter correct value.", "Incorrect Value", "error");
            }
            cashOnDrawer.Text = "" + totalSalesDrawer;
        }

        private void currencySettings_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calculateCash();
        }
    }
}
