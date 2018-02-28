using EPose.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPose
{
    class PosReceipt
    {
        dynamic invoice;
        public StringBuilder printString;
        const int FIRST_COL_PAD = 15;
        const int SECOND_COL_PAD = 7;
        const int THIRD_COL_PAD = 10;
        public string printer_name;
        double received;

        public PosReceipt(dynamic inv, string printer = null,double received = 0.0) {
            this.invoice = inv;
            this.printer_name = printer;
            this.received = received;
            DepartmentSettings.getData();
        }

        public void print() {
                try
                {
                    Font printFont = new Font("Arial", 8);
                    PrintDocument pd = new PrintDocument();
                    if(this.printer_name != null) {
                        pd.PrinterSettings.PrinterName = this.printer_name;
                    }
                    pd.PrintPage += new PrintPageEventHandler(this.perform);
                   // pd.Print();
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            Console.WriteLine(GenerateHeader());
        }

        public void perform(object sender, PrintPageEventArgs e)
        {
            int AvailableWidth = 250;
            Font ft = new Font("Arial", 8);
            StringFormat stringFormat = new StringFormat();
            var layoutArea = new SizeF(AvailableWidth, 0);
            Graphics g = e.Graphics;

            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            // Calculate the number of lines per page.
            linesPerPage = e.MarginBounds.Height / ft.GetHeight(g);

            yPos = topMargin + (count * ft.GetHeight(e.Graphics));
            g.DrawString(GenerateHeader(), ft, Brushes.Black,
               leftMargin, yPos, new StringFormat());

            //SizeF stringSize = g.MeasureString(GenerateHeader(), ft, layoutArea, stringFormat);
            //RectangleF rectf = new RectangleF(new PointF(), new SizeF(AvailableWidth, stringSize.Height));
            //g.DrawString(GenerateHeader(), ft, Brushes.Black, rectf, stringFormat);
        }

       

        public String GenerateHeader() {
            PaymentModel payment = new PaymentModel();
            dynamic payments = payment.where(payment, "invoice_id='" + this.invoice.id + "'");

            var sb = new StringBuilder();
            sb.AppendLine("Tangail Enterprise");
            sb.AppendLine(DepartmentSettings.branchName.PadLeft(0));
            sb.AppendLine(DepartmentSettings.address.PadLeft(20));
            sb.AppendLine("-----------------------------------------------------------------");
            sb.AppendLine("VAT CHALAN ("+DepartmentSettings.vatChalan+")");
            sb.AppendLine("VAT Reg: "+DepartmentSettings.vatRegstration);
            CustomerModel customer = new CustomerModel();
            if (this.invoice.customer_id != null)
            {
                dynamic customers = customer.find(customer, this.invoice.customer_id);
                sb.AppendLine(customers.name);
            }
            else {
                sb.AppendLine(" ");
            }
           
            sb.AppendLine("------------------------------------------------------------------");
            sb.Append("Item/Decription".PadRight(FIRST_COL_PAD));
            sb.Append("|".PadLeft(21));
            sb.AppendLine("Amount".PadLeft(15));
            sb.AppendLine("------------------------------------------------------------------");
            InvoiceItemModel invoice_item_obj = new InvoiceItemModel();
            dynamic items = invoice_item_obj.where(invoice_item_obj, "invoice_id = '" + this.invoice.id + "'");
            int i = 0;
            float total = 0;
            double vat = 0;
            foreach (dynamic item in items)
            {
                Console.WriteLine("jhfv");
                sb.Append("" + (i++) + ") PCODE1   [" + item.quantity + " @ " + Math.Round(item.price, 2) + "]".PadRight(FIRST_COL_PAD));
                sb.Append("|".PadRight(SECOND_COL_PAD));
                sb.AppendLine(string.Format("{0:0.00}", item.total).PadLeft(THIRD_COL_PAD));
                sb.AppendLine(item.name.PadRight(FIRST_COL_PAD));
                sb.AppendLine("------------------------------------------------------------------");
                total += item.total;
                double invoiceVat = item.vat;
                vat += invoiceVat;
            }
            sb.AppendLine("Subtotal Without VAT:                         " + Math.Round(total, 2));
            sb.AppendLine("VAT(Applicable Item Only):                    " + Math.Round(vat, 2));
            sb.AppendLine("                                           -----------------------");

            double paid = 0.0;
            double change = 0.0;
            if(this.received == 0.0){
                 paid = invoice.net_total;
                 change = 0.0;
            }
            else{
                paid = this.received;
                change = this.received - invoice.net_total;
            }


            sb.AppendLine("                                                Net total:" + invoice.net_total);
            sb.AppendLine("                                                 Discount:" + invoice.discount);
            sb.AppendLine("                                                   Paid  :" + paid);
            sb.AppendLine("                                                 Change  :" + change );

            String paymentType = "";
            if (payments.Count > 0)
            {
                paymentType = payments[0].payment_method;
            }
            sb.AppendLine("Payment Mode:" + paymentType);
            sb.AppendLine("--------------------------------------------------------------");
            sb.AppendLine("CASH                                                    " + Math.Round((total + vat), 2));
            sb.AppendLine("--------------------------------------------------------------");
            sb.AppendLine("Current Bonus Point :" + this.invoice.point);
            sb.AppendLine("Last Bonus Point :" + this.invoice.lastPoint);
            sb.AppendLine("---------------------------------------------------------------");
            sb.AppendLine("Sold item cannot be refunded but be exchanged");
            sb.AppendLine("within 72 hours with revevant recepit.");
            sb.AppendLine("COS&ORN is not exchangable. Inquery:01722647240");
            sb.AppendLine("Your right choice for shopping");
            sb.AppendLine("**System by Syftet Limited, Dhaka**");
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

       

        public String GenerateBody()
        {
            return "";
        }

        public String GenerateAmount()
        {
            return "";
        }

        public String GenerateFooter()
        {
            return "";
        }

        public String GenerateBarcode()
        {
            return "";
        }
    }
}
