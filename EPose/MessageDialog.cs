using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPose
{
    public class MessageDialog
    {
        public static DialogResult Show(String title, String msg)
        {
            AlartBox alt = new AlartBox(title, msg);
            return alt.ShowDialog();
        }

        public static DialogResult ShowAlert(String msg, String title = "Alert Message", String icon = "")
        {
            AlertMessage alt = new AlertMessage(title, msg, icon);
            return alt.ShowDialog();
        }
    }
}
