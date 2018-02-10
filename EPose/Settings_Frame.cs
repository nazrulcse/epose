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
    public partial class Settings_Frame : Layout_Frame
    {
        
        public Settings_Frame()
        {
            InitializeComponent();
            this.setTitle("Settings Window");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Settings_Frame_Load(object sender, EventArgs e)
        {
            SettingsModel setting = new SettingsModel();
           dynamic set =  setting.all(setting);
           txtPrinterSize.Text = set[0].printer_size;
           String padding = set[0].padding_layout;
           string[] tokens = padding.Split(',');
           txtTop.Text = tokens[0];
           textRight.Text = tokens[1];
           textBottom.Text = tokens[2];
           textLeft.Text = tokens[3];
           if (set[0].printer_type == "A4 Printer")
           {
               printerType.SelectedIndex = 0;
            }
           else if (set[0].printer_type == "Thermal Printer")
           {
               printerType.SelectedIndex = 1;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            String printerType = this.printerType.GetItemText(this.printerType.SelectedItem);
            String printerSize = txtPrinterSize.Text;
            String paddidngLayout = txtTop.Text +","+ textRight.Text +","+ textBottom.Text +","+ textLeft.Text;

            if (printerType != "" && printerSize != "" && paddidngLayout != "")
            {
                SettingsModel setting = new SettingsModel();
                setting.printer_type = printerType;
                setting.printer_size = printerSize;
                setting.padding_layout = paddidngLayout;



                setting = (SettingsModel)setting.create(setting);
                MessageBox.Show("Settings Save Succesfully");
            }
            else {
                MessageBox.Show("Fell The Input Properly");
            }
            
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
