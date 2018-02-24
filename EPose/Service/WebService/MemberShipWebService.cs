using EPose.Service.Sync;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Service.WebService
{
    class MemberShipWebService
    {
        public static void perform(string url = "/activities/memberships")
        {
            String successRecords = "";
            dynamic memberships = DownStream.syncMemberships(url);
            foreach (var membership in memberships)
            {
                try
                {
                    var response = ActionPerform.perform(membership, membership.action);
                    if (response)
                    {
                        successRecords += membership.log_id + ",";
                    }
                    else
                    {
                        Console.WriteLine("Unable to create membership");
                    }
                }
                catch (MySqlException e)
                {
                    if (e.Number == 1062)
                    {
                        successRecords += membership.log_id + ",";
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
