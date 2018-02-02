using EPose.Service.Sync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Service.WebService
{
    class ProductService
    {

        public static void perform()
        {
            int i = 0;
            String[] successRecords = new String[100];
            dynamic products = DownStream.syncProduct();
            Console.WriteLine("" + products);
            foreach (var product in products)
            {
                try
                {
                    var response = ActionPerform.perform(product, product.action);
                    if (response)
                    {
                        successRecords[i++] = product.log_id;
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
