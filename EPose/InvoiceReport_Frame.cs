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
       

        public InvoiceReport_Frame()
        {
            InitializeComponent();
           
        }

        private void InvoiceReport_Frame_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = SQLConn.ConnDB();
            string sql = "SELECT * FROM invoice_items where id ='INT636542335368565'";
            MySqlDataAdapter adptr = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adptr.Fill(ds, "DataSet2");


            var fileName = "D:/Development/Projects/epose/EPose/invoice_Report.rdlc";
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                reportViewer1.LocalReport.LoadReportDefinition(fs);
            }

            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("data", "eeeee");
            parameters[1] = new ReportParameter("branch_name", "Syftet");

            this.reportViewer1.LocalReport.SetParameters(parameters);

            //reportViewer1.SetParameterValue("Textbox7", "Hello");

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", ds.Tables[0]));
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();

            

        }
    }
}
