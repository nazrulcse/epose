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
          }
          else if (iconText == "error")
          {
                icon.Image = EPose.Properties.Resources.error;           
          }
        }
    }
}
