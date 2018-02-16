using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Service
{
    class ActionPerform
    {
        public static Boolean perform(dynamic modelObject, String action) {
            dynamic response = null;
            switch(action) {
                case "create": {
                    response = modelObject.create(modelObject);
                    break;
                }
                case "update": {
                    response = modelObject.save(modelObject);
                    break;
                }
                case "delete":
                {
                    response = modelObject.delete(modelObject);
                    break;
                }
                default: {
                    response = modelObject.create(modelObject);
                    break;
                }
            }
            return response != null;
        }
    }
}
