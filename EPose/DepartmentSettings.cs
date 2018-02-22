using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace EPose
{
    static class DepartmentSettings
    {
        public static string DepartmentId;
        public static string TillId;
        public static string vatChalan;
        public static string vatRegstration;
        public static string address;
        public static string branchName;
        public static Bitmap logo;

        public static void getData()
        {
            string AppName = Application.ProductName;
            try
            {
                DepartmentId = Interaction.GetSetting(AppName, "DptSection", "Department_Id", "1");
                TillId = Interaction.GetSetting(AppName, "DptSection", "Till_Id", "1");
                vatChalan = Interaction.GetSetting(AppName, "DptSection", "vat_chalan", "1");
                vatRegstration = Interaction.GetSetting(AppName, "DptSection", "vat_regestration", "1");
                branchName = Interaction.GetSetting(AppName, "DptSection", "branch_name", "1");
                address = Interaction.GetSetting(AppName, "DptSection", "adress", "1");
            }
            catch
            {
                Interaction.MsgBox("System registry was not established, you can set/save " + "these settings by pressing F1", MsgBoxStyle.Information);
            }
        }

        public static void SaveData()
        {
            string AppName = Application.ProductName;
            Interaction.SaveSetting(AppName, "DptSection", "Department_Id", DepartmentId);
            Interaction.SaveSetting(AppName, "DptSection", "Till_Id", TillId);
            Interaction.SaveSetting(AppName, "DptSection", "vat_chalan", vatChalan);
            Interaction.SaveSetting(AppName, "DptSection", "vat_regestration", vatRegstration);
            Interaction.SaveSetting(AppName, "DptSection", "branch_name", branchName);
            Interaction.SaveSetting(AppName, "DptSection", "adress", address);
            Interaction.SaveSetting(AppName, "DptSection", "logo", logo.ToString());
            Interaction.MsgBox("Department settings are saved.", MsgBoxStyle.Information);
        }
    }
}
