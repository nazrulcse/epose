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
    public partial class ActivityLog_Frame : Layout_Frame
    {
        public ActivityLog_Frame()
        {
            InitializeComponent();
        }

        private void ActivityLog_Frame_Load(object sender, EventArgs e)
        {
            loadInvoice();
            loadPayment();
            loadInvoiceItem();
            loadMembership();
        }

        public void loadInvoice()
        {
            ActivityLogModel log = new ActivityLogModel();
            dynamic invoices = log.where(log,"model = 'invoice'");
           if(invoices.Count>0){
               foreach (var invoice in invoices)
               {
                   invoiceList.Rows.Add(invoice.id, invoice.model, invoice.action, invoice.date, invoice.ref_id, invoice.department_id);
               }
           }
        }

        public void loadPayment()
        {
            ActivityLogModel log = new ActivityLogModel();
            dynamic payments = log.where(log, "model = 'payment'");
            if (payments.Count > 0) {
                foreach (var payment in payments)
                {
                    paymentsList.Rows.Add(payment.id, payment.model, payment.action, payment.date, payment.ref_id, payment.department_id);
                }
            }
        }

        public void loadInvoiceItem()
        {
            ActivityLogModel log = new ActivityLogModel();
            dynamic invoiceItems = log.where(log, "model = 'invoice_items'");
            if(invoiceItems.Count>0){
                foreach (var invoiceItem in invoiceItems)
                {
                    invoiceItemList.Rows.Add(invoiceItem.id, invoiceItem.model, invoiceItem.action, invoiceItem.date, invoiceItem.ref_id, invoiceItem.department_id);
                }
            }
            
        }

        public void loadMembership()
        {
            ActivityLogModel log = new ActivityLogModel();
            dynamic memberships = log.where(log, "model = 'membership'");
            if (memberships.Count > 0)
            {
                foreach (var membership in memberships)
                {
                    membershipList.Rows.Add(membership.id, membership.model, membership.action, membership.date, membership.ref_id, membership.department_id);
                }
            }

        }
    }
}
