using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Service
{
    class SyncService
    {
        public static void run() {
            Console.WriteLine("Sync service started...");
            WebAPI wp = new WebAPI();
            wp.syncEmployee();
        }
    }
}
