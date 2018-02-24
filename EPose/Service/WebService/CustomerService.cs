using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPose.Service.Sync;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace EPose.Service.WebService
{
    class CustomerService
    {
        public static void perform(string url = "activities/customers")
        {
            String successRecords = "";
            dynamic customers = DownStream.syncCustomer(url);
            foreach (var customer in customers)
            {
                try
                {
                    var response = ActionPerform.perform(customer, customer.action);
                    if (response)
                    {
                        successRecords += customer.log_id + "";
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
                        successRecords += customer.log_id + "";
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