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
        double initial_balance = 0;

        public TillClosing_Frame()
        {
            InitializeComponent();
        }

        private void TillClosing_Frame_Load(object sender, EventArgs e)
        {
            setTitle("Till Closing Window");
            DepartmentSettings.getData();
            dateLabel.Text = DateTime.Now.ToString("dd.MM.yyy");
            loadSales();
            loadCurrencySettings();
            initial_balance = getInitialBalance();
            labelInitialBanalce.Text = "" + initial_balance;
        }

        private void loadCurrencySettings() {
            CurrencyItemModel cim = new CurrencyItemModel();
            dynamic items = cim.all(cim);
            foreach (var item in items) {
                currencySettings.Rows.Add(item.value, item.name, 0);
            }
        }
    
        public void loadSales()
        {

            string date = DateTime.Now.ToString("yyyy-MM-dd");

            InvoiceModel inv = new InvoiceModel();
            dynamic invoices = inv.where(inv, "till_id = '" + DepartmentSettings.TillId + "' and date ='" + date + "'");

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
                cashSale.Text = "" + Math.Round(totalCashPayment, 2);
            }
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
            textBoxDifference.Text = "" + (totalCashPayment - (totalSalesDrawer - initial_balance));
            labelNetDrawerBalance.Text = "" + (totalSalesDrawer - initial_balance);
        }

        private void currencySettings_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calculateCash();
        }

        private double getInitialBalance() {
            TillClosingModel tc = new Model.TillClosingModel();
            dynamic closings = tc.where(tc, "till_id='" + DepartmentSettings.TillId + "'" + " and date != " + DateTime.Now.ToString("yyyy-MM-dd"), "order by id desc");
            if (closings.Count > 0)
            {
                dynamic closing = closings[0];
                return closing.initial_balance;
            }
            else {
                return 0.0;
            }
        }

        private void closebutton_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageDialog.Show("Confirm Close", "Are you want to Close?? ");
            if (dialogResult == DialogResult.Yes)
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                TillClosingModel till = new TillClosingModel();
                dynamic tills = till.where(till, "date = '" + date + "'");

                if (tills.Count > 0)
                {
                    if (textBoxKeepInDrawe.Text != "")
                    {
                        till.cash_in_drawer = totalSalesDrawer;
                        till.total_sale_mount = totalPayment;
                        till.difference = totalPayment - totalSalesDrawer;
                        till.initial_balance = Convert.ToDouble(textBoxKeepInDrawe.Text);
                        till.till_id = DepartmentSettings.TillId;
                        till.date = DateTime.Now.ToString("yyyy-MM-dd");
                        till.update_attributes(till, "date = '" + date + "'");
                        MessageBox.Show("successfull update");
                    }
                    else
                    {
                        MessageBox.Show("Keep sonthing in drawer first");
                    }
                }

                else
                {

                    if (textBoxKeepInDrawe.Text != "")
                    {
                        till.cash_in_drawer = totalSalesDrawer;
                        till.total_sale_mount = totalPayment;
                        till.difference = totalPayment - totalSalesDrawer;
                        till.initial_balance = Convert.ToDouble(textBoxKeepInDrawe.Text);
                        till.till_id = DepartmentSettings.TillId;
                        till.date = DateTime.Now.ToString("yyyy-MM-dd");
                        till.create(till);
                        MessageBox.Show("successfull create");
                    }
                    else
                    {
                        MessageBox.Show("Keep sonthing in drawer first");
                    }

                }
            }
        }
    }
}
