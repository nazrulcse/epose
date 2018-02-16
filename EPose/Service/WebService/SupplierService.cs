using EPose.Service.Sync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Service.WebService
{
    class SupplierService
    {

        public static void perform(string url = "activities/suppliers")
        {
            int i = 0;
            String[] successRecords = new String[100];
            dynamic suppliers = DownStream.syncSupplier(url);
            foreach (var supplier in suppliers)
            {
                try
                {
                    var response = ActionPerform.perform(supplier, supplier.action);
                    if (response)
                    {
                        successRecords[i++] = supplier.log_id;
                    }
                    else
                    {
                        Console.WriteLine("Unable to create department");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message.ToString());
                }
                UpStream.webAcknowledgement(successRecords);
            }
        }

    }
}
