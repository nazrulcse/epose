using EPose.Service.Sync;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Service.WebService
{
    class SupplierService
    {
        public static void perform(string url = "activities/suppliers")
        {
            String successRecords = "";
            dynamic suppliers = DownStream.syncSupplier(url);
            foreach (var supplier in suppliers)
            {
                try
                {
                    var response = ActionPerform.perform(supplier, supplier.action);
                    if (response)
                    {
                        successRecords += supplier.log_id + ",";
                    }
                    else
                    {
                        Console.WriteLine("Unable to create department");
                    }
                }
                catch (MySqlException e)
                {
                    if (e.Number == 1062)
                    {
                        successRecords += supplier.log_id + ",";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message.ToString());
                }
            }
            UpStream.webAcknowledgement(successRecords);
        }
    }
}
