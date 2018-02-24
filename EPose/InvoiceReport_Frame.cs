using EPose.Model;
using EPose.Orm;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPose
{
    public partial class InvoiceReport_Frame : Form
    {
        dynamic invoice;
        double receivedAmount = 0.0;

        public InvoiceReport_Frame(dynamic invoice)
        {
            InitializeComponent();
            this.invoice = invoice;
        }

        private void InvoiceReport_Frame_Load(object sender, EventArgs e)
        {

            MySqlConnection conn = SQLConn.ConnDB();
            string sql = "SELECT * FROM invoice_items where invoice_id ='" + invoice.id + "'";
            MySqlDataAdapter adptr = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adptr.Fill(ds, "DataSet2");

            try
            {
            var fileName = AppDomain.CurrentDomain.BaseDirectory + "../../" + "invoice_Report.rdlc";
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                reportViewer1.LocalReport.LoadReportDefinition(fs);
            }

            string total = "" + Math.Round((this.invoice.invoice_total - this.invoice.discount) * 1.0, 2);
            string[] splitTotal = total.Split('.');
            string beforeDot = NumberToWords(Int32.Parse(splitTotal[0]));
            string afterDot = "";
            if (splitTotal.Length > 1)
            {
                afterDot = NumberToWords(Int32.Parse(splitTotal[1]));
                afterDot = " " + afterDot + " Paisa";
            }

            ReportParameter[] parameters = new ReportParameter[14];
            parameters[0] = new ReportParameter("date", ""+ DateTime.Now.ToString("yyyy-MM-dd"));
            parameters[1] = new ReportParameter("branch_name", DepartmentSettings.branchName);
            if (this.invoice.customer_id != null)
            {
                CustomerModel customer = new CustomerModel();
                dynamic customers = customer.find(customer, this.invoice.customer_id);
                parameters[2] = new ReportParameter("customerName", " " + customers.name);
                parameters[3] = new ReportParameter("customerAdress", " "+customers.address);
                parameters[4] = new ReportParameter("phone", " "+customers.mobile);

            }
            else {
                parameters[2] = new ReportParameter("customerName", " ");
                parameters[3] = new ReportParameter("customerAdress"," ");
                parameters[4] = new ReportParameter("phone", " ");
            }

            PaymentModel pay = new PaymentModel();

            dynamic payments = pay.where(pay, "invoice_id='" + this.invoice.id + "'");
            foreach (dynamic payment in payments)
            {
                receivedAmount += payment.amount;
            }

            string dueAfterRound = "" + Math.Round(this.invoice.net_due, 2);
            string totalAfterRound = "" + Math.Round(this.invoice.invoice_total, 2);
            parameters[5] = new ReportParameter("due", dueAfterRound);
            parameters[6] = new ReportParameter("invoiceNo", this.invoice.number);
            parameters[7] = new ReportParameter("total", totalAfterRound);
            parameters[8] = new ReportParameter("address", DepartmentSettings.address);
            parameters[9] = new ReportParameter("vatChalanNo", " " + DepartmentSettings.vatChalan);
            parameters[10] = new ReportParameter("totalInWord", beforeDot + " Taka" + afterDot);
            parameters[11] = new ReportParameter("discount", " " + this.invoice.discount);
            parameters[12] = new ReportParameter("netAmount", " " + this.invoice.net_total);
            parameters[13] = new ReportParameter("receivedAmount", " " + Math.Round(this.receivedAmount, 2));
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.SetParameters(parameters);
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", ds.Tables[0]));
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageDialog.ShowAlert("Error: " + ex.Message.ToString());
            }
        }


        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
