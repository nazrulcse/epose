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
    public partial class AlertMessage : Form
    {
        public AlertMessage(String title, String msg, String iconText = "")
        {
            InitializeComponent();
            formTitle.Text = title;
            message.Text = msg;
            if (iconText != "")
            {
                setIcon(iconText);
            }
        }

        public void setIcon(String iconText)
        {
          if (iconText == "warning")
          {
              icon.Image = EPose.Properties.Resources.warning;
              titleBar.BackColor = Color.FromArgb(240, 173, 78);
              laftBorder.BackColor = Color.FromArgb(240, 173, 78);
              rightBorder.BackColor = Color.FromArgb(240, 173, 78);
              bottomBorder.BackColor = Color.FromArgb(240, 173, 78);
          }
          else if (iconText == "error")
          {
                icon.Image = EPose.Properties.Resources.error;
                titleBar.BackColor = Color.FromArgb(212, 63, 58);
                laftBorder.BackColor = Color.FromArgb(212, 63, 58);
                rightBorder.BackColor = Color.FromArgb(212, 63, 58);
                bottomBorder.BackColor = Color.FromArgb(212, 63, 58);
          }
        }
    }
}
