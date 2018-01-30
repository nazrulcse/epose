using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPose.Service.Sync;

namespace EPose.Service.WebService
{
    class EmployeeService
    {

        public static void perform()
        {
            int i = 0;
            String[] successRecords = new String[100];
            dynamic employees = DownStream.syncEmployee();
            
            foreach (var employee in employees)
            {

                try
                {
                    var response = ActionPerform.perform(employee, employee.action);
                    if (response)
                    {
                        successRecords[i++] = employee.log_id;
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
