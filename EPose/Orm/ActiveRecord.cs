using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Orm
{
    public class ActiveRecord
    {
        public ActiveRecord() {
            SQLConn.getData();
        }

        public Object create(dynamic modelObject)
        {
            Boolean first = true;
            var table_name = modelObject.getTable();
            Type objType = modelObject.GetType();
            StringBuilder table_columns = new StringBuilder();
            StringBuilder table_values = new StringBuilder();
            var arrFields = modelObject.attrAccess();
            for (var i = 0; i < arrFields.Length; i++)
            {
                string field = arrFields[i];
                PropertyInfo pi = objType.GetProperty(field);
                if (pi != null) {
                    var fieldValue = pi.GetValue(modelObject, null);
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        table_columns.Append(", ");
                        table_values.Append(", ");
                    }
                    table_columns.Append(field.ToString());
                    table_values.Append("'" + fieldValue + "'");
                };
            }
            var query = "INSERT INTO " + table_name + " (" + table_columns + ") VALUES (" + table_values + ")";
            Console.WriteLine("INSERT INTO " + table_name + " (" + table_columns + ") VALUES (" + table_values + ");");
            var objResult = executeQuery(query);
            if (objResult)
            {
                return modelObject;
            }
            else {
                return null;
            }
        }

        public object find(dynamic modelObject, String id)
        {
            return getFromDatabase(modelObject, id);
        }

        public object all(dynamic modelObject)
        {
            return getFromDatabase(modelObject, null);
        }

        public object getFromDatabase(dynamic modelObject, String id)
        {
            var table_name = modelObject.getTable();
            Type objType = modelObject.GetType();
            var query = "Select * from " + table_name;
            if (id != null)
            {
                query = "Select * from " + table_name + " where id = '" + id + "'";
                dynamic objects = readExecuteQuery(modelObject, query);
                if (objects != null)
                {
                    return objects[0];
                }
            }
            else {
                return readExecuteQuery(modelObject, query);
            }
            return modelObject;
        }

        public Boolean executeQuery(String query) {
            try
            {
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(query, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.Message.ToString());
                return false;
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        public object readExecuteQuery(dynamic objectModel, String query)
        {
            //try
            //{
            Console.WriteLine("Query: " + query);
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(query, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                var objectList = ObjectBuilder.DataReader2Obj(SQLConn.dr, objectModel);
                return objectList;
            //}
            //catch (Exception ex)
            //{
              //  Console.WriteLine("Mysql Error: " + ex.Message.ToString());
                //return false;
            //}
            //finally
            //{
              //  SQLConn.cmd.Dispose();
               // SQLConn.conn.Close();
            //}
        }

        public object getProperty(Type objType, String name)
        {
            MethodInfo theMethod = objType.GetMethod(name);
            return theMethod.Invoke(objType, null);
        }
    }
}
