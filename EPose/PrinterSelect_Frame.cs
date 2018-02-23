using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace EPose
{
    public partial class PrinterSelect_Frame : Layout_Frame
    {
        dynamic inv;
        public PrinterSelect_Frame( dynamic invoice)
        {
            InitializeComponent();
            this.inv = invoice;
        }

        private void PrinterSelect_Frame_Load(object sender, EventArgs e)
        {
            GetAllPrinterList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (radioButtonA4.Checked) {
                InvoiceReport_Frame recept = new InvoiceReport_Frame(this.inv);
                recept.Show();
            }
            else
            {
                string printer = lstPrinterList.GetItemText(lstPrinterList.SelectedItem);
                if (printer != null && printer !="")
                {
                    PosReceipt pos = new PosReceipt(this.inv, printer);
                    pos.print();
                }
                else {
                    MessageBox.Show("Slect A Printer");
                }
               
            }            
        }

        private void GetAllPrinterList()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
              //  MessageBox.Show(printer.ToString());
                lstPrinterList.Items.Add(printer.ToString());
            }
        }
    }
}
