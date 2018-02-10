using EPose.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Model
{
    class SettingsModel : ActiveRecord
    {
        public int  id { get; set; }
        public string printer_type { get; set; }
        public string printer_size { get; set; }
        public string padding_layout { get; set; }
       

        public string getTable()
        {
            return "settings";
        }


        public Array attrAccess()
        {
            return new String[] { "id", "printer_type", "printer_size", "padding_layout"};
        }
    }
}
