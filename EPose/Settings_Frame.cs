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
        public string tillSettingsId;   
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
                MessageDialog.ShowAlert("Fill The Input Properly");
            }
            
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Currency item settings
        private void loadTillSettings() {
            tillSettingsdataGrid.Rows.Clear();
            CurrencyItemModel cim = new CurrencyItemModel();
            dynamic items = cim.all(cim);
            foreach(dynamic item in items) {
                tillSettingsdataGrid.Rows.Add(item.id, item.name, item.value);
            }
        }
        private void resetTillSettings() { 
          itemName.Text = "";
          itemValue.Text = "";
          tillSettingsId = null;
          btnDelete.Enabled = false;
          btnUpdate.Enabled = false;
          btnDelete.BackColor = Color.Gray;
          btnUpdate.BackColor = Color.Gray;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (itemName.Text != "" && itemValue.Text != "")
            {
                CurrencyItemModel cim = new CurrencyItemModel();
                cim.name = itemName.Text;
                cim.value = Convert.ToDouble(itemValue.Text);
                dynamic record = cim.create(cim);
                MessageDialog.ShowAlert("Currency Item Added");
                resetTillSettings();
                loadTillSettings();
            }
            else {
                MessageDialog.ShowAlert("Please Enter correct value", "Alert Message", "error");
            }
        }

        private void tabTillSettings_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "tillSettingsPage")
            {
                loadTillSettings();
            }
        }

        private void tillSettingsdataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            itemName.Text = tillSettingsdataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            itemValue.Text = tillSettingsdataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            tillSettingsId = tillSettingsdataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.BackColor = Color.FromArgb(212, 63, 58);
            btnUpdate.BackColor = Color.FromArgb(0, 165, 223);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (itemName.Text != "" && itemValue.Text != "")
            {
                CurrencyItemModel cim = new CurrencyItemModel();
                dynamic currency_item = cim.find(cim, tillSettingsId);
                currency_item.name = itemName.Text;
                currency_item.value = Convert.ToDouble(itemValue.Text);
                currency_item.save(currency_item);
                MessageDialog.ShowAlert("Currency Item Updated");
                resetTillSettings();
                loadTillSettings();
            }
            else {
                MessageDialog.ShowAlert("Please enter correct value", "Alert Message", "error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tillSettingsId != null)
            {
                CurrencyItemModel cim = new CurrencyItemModel();
                dynamic currency_item = cim.find(cim, tillSettingsId);
                currency_item.delete(currency_item);
                MessageDialog.ShowAlert("Currency Item Deleted");
                resetTillSettings();
                loadTillSettings();
            }
            else {
                MessageDialog.ShowAlert("Unable to delete, Please select item to delete", "Alert Message", "error");
            }
        }

        private void resetSettings_Click(object sender, EventArgs e)
        {
            resetTillSettings();
        }
    }
}
