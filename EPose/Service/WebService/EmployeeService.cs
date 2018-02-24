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
    class EmployeeService
    {

        public static void perform(string url = "activities/employees")
        {
            String successRecords = "";
            dynamic employees = DownStream.syncEmployee(url);
            
            foreach (var employee in employees)
            {

                try
                {
                    var response = ActionPerform.perform(employee, employee.action);
                    if (response)
                    {
                        successRecords += employee.log_id + ",";
                    }
                    else
                    {
                        Console.WriteLine("Unable to create employee");
                    }
                }
                catch (MySqlException e)
                {
                    if (e.Number == 1062)
                    {
                        successRecords += employee.log_id + ",";
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
