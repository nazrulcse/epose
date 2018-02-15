using EPose.Service.Sync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Service.WebService
{
    class MemberShipWebService
    {
    public static void perform()
        {
            int i = 0;
            String[] successRecords = new String[100];
            dynamic memberships = DownStream.syncMemberships();
            Console.WriteLine("" + memberships);
            foreach (var membership in memberships)
            {
               // try
                //{
                    var response = ActionPerform.perform(membership, membership.action);
                    if (response)
                    {
                        successRecords[i++] = membership.log_id;
                    }
                    else
                    {
                        Console.WriteLine("Unable to create membership");
                    }
                //}
                //catch (Exception ex)
                //{
                  //  Console.WriteLine("Error: " + ex.Message.ToString());
                //}
                //UpStream.webAcknowledgement(successRecords);
            }
        }

    }
}
