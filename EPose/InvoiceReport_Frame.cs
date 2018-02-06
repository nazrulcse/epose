using EPose.Orm;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
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
    public partial class InvoiceReport_Frame : Form
    {
        public InvoiceReport_Frame()
        {
            InitializeComponent();
        }

        private void InvoiceReport_Frame_Load(object sender, EventArgs e)
        {
            SQLConn.ConnDB();
            string sql = "";
            sql += "SELECT * FROM invoices";
            MySqlDataAdapter adptr = new MySqlDataAdapter(sql, SQLConn.conn);
            DataSet ds = new DataSet();
            adptr.Fill(ds);
            ReportDataSource rds = new ReportDataSource("Tablix1", ds);
            reportViewer1.LocalReport.DataSources.Add(rds);
        }
    }
}
