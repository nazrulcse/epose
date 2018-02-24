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
    class DepartmentService
    {
        public static void perform(string url = "activities/departments")
        {
            String successRecords = "";
            dynamic departments = DownStream.syncDepartment(url);
            foreach(var department in departments) {
                try {
                    var response = ActionPerform.perform(department, department.action);
                    if (response)
                    {
                        successRecords += department.log_id + ",";
                    }
                    else {
                        Console.WriteLine("Unable to create department");
                    }
                }
                catch (MySqlException e)
                {
                    if (e.Number == 1062)
                    {
                        successRecords += department.log_id + ",";
                    }
                }
                catch(Exception ex) {
                    Console.WriteLine("Error: " + ex.Message.ToString());
                }
            }
            UpStream.webAcknowledgement(successRecords);
        }
    }
}