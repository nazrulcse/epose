﻿using System;
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
    public partial class AlartBox : Form
    {
        public AlartBox(String title, String msg, String iconText = "", String information = "")
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
          if (iconText == "print")
          {
              icon.Image = EPose.Properties.Resources.print;
          }
          else if (iconText == "member")
          {
              icon.Image = EPose.Properties.Resources.member;
          }
          else if (iconText == "error")
          {
                icon.Image = EPose.Properties.Resources.error;
          }
        }
    }
}
