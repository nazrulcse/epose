using EPose.Service.PosService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EPose.Service.Sync
{
    class UpStream
    {
        public static void webAcknowledgement(String[] log_ids) {
           
        }

        public static void perform() {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Console.WriteLine("Thread running......");
                InvoiceService.perform();
                InvoiceItemService.perform();
                PaymentService.perform();
                MemberShipService.perform();
            }).Start();
        }
    }
}
