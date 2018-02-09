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

        public static void getData()
        {
            string AppName = Application.ProductName;
            try
            {
                DepartmentId = Interaction.GetSetting(AppName, "DptSection", "Department_Id", "1");
                TillId = Interaction.GetSetting(AppName, "DptSection", "Till_Id", "1");
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
            Interaction.MsgBox("Department settings are saved.", MsgBoxStyle.Information);
        }
    }
}
