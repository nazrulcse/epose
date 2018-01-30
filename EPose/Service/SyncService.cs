using EPose.Service.Sync;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPose.Service.WebService;

namespace EPose.Service
{
    class SyncService
    {
        public static void run() {
            Console.WriteLine("Sync service started...");
           // DepartmentService.perform();
            EmployeeService.perform();
            //WebAPI wp = new WebAPI();
            //wp.syncEmployee();
        }
    }
}
