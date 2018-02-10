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

        public PosReceipt(dynamic inv) {
            this.invoice = inv;
            DepartmentSettings.getData();
        }

        public void print() {
                try
                {
                    Font printFont = new Font("Arial", 8);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.perform);
                    pd.Print();
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
            var sb = new StringBuilder();
            sb.AppendLine("Tangail Enterprise");
            sb.AppendLine("Dhaka Branch".PadLeft(0));
            sb.AppendLine("Road #3, House #262, Mirpur-12, DOHS, Dhaka".PadLeft(20));
            sb.AppendLine("-----------------------------------------------------------------");
            sb.AppendLine("VAT CHALAN (VAT-11)");
            sb.AppendLine("VAT Reg: 170012542");
            sb.AppendLine("Customer Name: Md Nazrul Islam");
            sb.AppendLine("------------------------------------------------------------------");
            sb.Append("Item/Decription".PadRight(FIRST_COL_PAD));
            sb.Append("|".PadLeft(21));
            sb.AppendLine("Amount".PadLeft(15));
            sb.AppendLine("------------------------------------------------------------------");
            InvoiceItemModel invoice_item_obj = new InvoiceItemModel();
            dynamic items = invoice_item_obj.where(invoice_item_obj, "invoice_id = '" + this.invoice.id + "'");
            int i = 0;
            float total = 0;
            float vat = 0;
            foreach (dynamic item in items)
            {
                Console.WriteLine("jhfv");
                sb.Append("" + (i++) + ") PCODE1   [" + item.quantity + " @ " + item.price + "]".PadRight(FIRST_COL_PAD));
                sb.Append("|".PadRight(SECOND_COL_PAD));
                sb.AppendLine(string.Format("{0:0.00}", item.total).PadLeft(THIRD_COL_PAD));
                sb.AppendLine(item.name.PadRight(FIRST_COL_PAD));
                sb.AppendLine("------------------------------------------------------------------");
                total += item.price;
                vat += item.vat;
            }
            sb.AppendLine("Subtotal Without VAT:                         " + total);
            sb.AppendLine("VAT(Applicable Item Only):                    " + vat);
            sb.AppendLine("                                           -----------------------");
            sb.AppendLine("                                                Net Due:" + (total + vat));
            sb.AppendLine("                                                   Paid:" + (total + vat + 111));
            sb.AppendLine("                                                 Change:" + 111);
            sb.AppendLine("Payment Mode:");
            sb.AppendLine("--------------------------------------------------------------");
            sb.AppendLine("CASH                                                    " + (total + vat));
            sb.AppendLine("--------------------------------------------------------------");
            sb.AppendLine("Current Bonus Point : 27.50");
            sb.AppendLine("Current Bonus Point : 57.72");
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
