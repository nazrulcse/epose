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
    class ProductService
    {
        public static void perform(string url = "activities/products")
        {
            String successRecords = "";
            dynamic products = DownStream.syncProduct(url);
            Console.WriteLine("" + products);
            foreach (var product in products)
            {
                try
                {
                    var response = ActionPerform.perform(product, product.action);
                    if (response)
                    {
                        successRecords += product.log_id + ",";
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
                        successRecords += product.log_id + ",";
                    }
                    else
                    {
                        MessageDialog.ShowAlert("Error: " + e.Message.ToString());
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
