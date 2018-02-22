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
    public partial class PurchaseReturn_Frame : Layout_Frame
    {
        public PurchaseReturn_Frame()
        {
            InitializeComponent();
            this.setTitle("Purchase Order Window");
        }

        private void PurchaseReturn_Load(object sender, EventArgs e)
        {

        }

        private void employeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_invoice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return) {
                string number = search_invoice.Text;
                InvoiceModel inv = new InvoiceModel();
                dynamic invoices = inv.where(inv, "lower(number) like '%" + number.ToLower() + "%'");
                if (invoices.Count > 0)
                {
                    foreach(dynamic invoice in invoices) {
                        invoiceList.Rows.Add(invoice.id, invoice.number, invoice.customer_id, invoice.date, invoice.net_total);
                    }
                    invoiceList.Rows[0].Selected = true;
                    invoiceList.Focus();
                }
                else {
                    MessageDialog.ShowAlert("Invoice not found");
                }
            }
        }

        private void invoiceList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (invoiceList.Rows.Count > 1)
                {
                    MessageDialog.ShowAlert("Invoice Selected " + invoiceList.SelectedRows[0].Index);
                    this.Close();
                }
                else
                {
                    MessageDialog.ShowAlert("No Product found", "Alert Message", "warning");
                }
            }
        }
    }
}
