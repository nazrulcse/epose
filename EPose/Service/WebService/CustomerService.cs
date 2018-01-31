using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPose.Service.Sync;
namespace EPose.Service.WebService
{
    class CustomerService
    {
        public static void perform()
        {
            int i = 0;
            String[] successRecords = new String[100];
            dynamic customers = DownStream.syncCustomer();
            foreach (var customer in customers)
            {
                try
                {
                    var response = ActionPerform.perform(customer, customer.action);
                    if (response)
                    {
                        successRecords[i++] = customer.log_id;
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