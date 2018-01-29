using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPose.Service.Sync;

namespace EPose.Service.WebService
{
    class DepartmentService
    {
        public static void perform() {
            int i = 0;
            String[] successRecords = new String[100]; 
            dynamic departments = DownStream.syncDepartment();
            foreach(var department in departments) {
                try {
                    var response = ActionPerform.perform(department, department.action);
                    if (response)
                    {
                        successRecords[i++] = department.log_id;
                    }
                    else {
                        Console.WriteLine("Unable to create department");
                    }
                }
                catch(Exception ex) {
                    Console.WriteLine("Error: " + ex.Message.ToString());
                }
                UpStream.webAcknowledgement(successRecords);
            }
        }
    }
}