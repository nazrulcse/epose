using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPose.Orm
{
    public class ActiveRecord
    {
        public ActiveRecord() {
            SQLConn.getData();
        }

        public Object create(dynamic modelObject)
        {
            MySqlConnection conn = SQLConn.ConnDB();
            MySqlCommand cmd = conn.CreateCommand();
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
                    if (table_columns.Length > 0)
                    {
                        table_columns.Append(", ");
                        table_values.Append(", ");
                    }
                    table_columns.Append(field.ToString());
                    table_values.Append("?" + field.ToString());
                    cmd.Parameters.Add("?" + field.ToString(), fieldValue);
                };
            }
            var query = "INSERT INTO " + table_name + " (" + table_columns + ") VALUES (" + table_values + ")";
            Console.WriteLine("INSERT INTO " + table_name + " (" + table_columns + ") VALUES (" + table_values + ");");
            cmd.CommandText = query;
            int objResult = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Code: " + objResult);
            if (objResult == 1)
            {
                return modelObject;
            }
            else {
                return null;
            }
        }

        public object find(dynamic modelObject, String id)
        {
            var table_name = modelObject.getTable();
            var query = "Select * from " + table_name + " where id = '" + id + "'";
            dynamic objects = getFromDatabase(modelObject, query);
            if (objects != null && objects.Count > 0)
            {
                return objects[0];
            }
            return modelObject;
        }

        public object find_by(dynamic modelObject, String field, String value)
        {
            var table_name = modelObject.getTable();
            var query = "Select * from " + table_name + " where " + field + "= '" + value + "'";
            dynamic objects = getFromDatabase(modelObject, query);
            if (objects.Count > 0)
            {
                return objects[0];
            }
            return null;
        }

        public object all(dynamic modelObject)
        {
            var table_name = modelObject.getTable();
            var query = "Select * from " + table_name;
            return getFromDatabase(modelObject, query);
        }

      
        public object where(dynamic modelObject, string condition, string options = "ORDER BY id ASC")
        {
            var table_name = modelObject.getTable();
            Type objType = modelObject.GetType();
            var query = "Select * from " + table_name + " where(" + condition + ") " + options;
            return getFromDatabase(modelObject, query);
        }
       
        public object delete(dynamic modelObject, string condition = "")
        {
            var table_name = modelObject.getTable();
            Type objType = modelObject.GetType();
            var query = "";
            if (condition != "")
            {
                query = "delete from " + table_name + " where(" + condition + ")";
            }
            else {
                query = "delete from " + table_name + " where id=" + modelObject.id;
            }
            return getFromDatabase(modelObject, query);
        }

        public object update_attributes(dynamic modelObject, string condition = "")
        {
            MySqlConnection conn = SQLConn.ConnDB();
            MySqlCommand cmd = conn.CreateCommand();
            var table_name = modelObject.getTable();
            Type objType = modelObject.GetType();
            StringBuilder set_columns = new StringBuilder();
            var arrFields = modelObject.attrAccess();
            for (var i = 0; i < arrFields.Length; i++)
            {
                string field = arrFields[i];
                PropertyInfo pi = objType.GetProperty(field);
                if (pi != null)
                {
                    if (field.ToString() == "id")
                    {
                        continue;
                    }
                    var fieldValue = pi.GetValue(modelObject, null);
                    if (set_columns.ToString() != "")
                    {
                        set_columns.Append(", ");
                    }
                    set_columns.Append(field.ToString());
                    set_columns.Append(" =");
                    set_columns.Append("@" + field.ToString());
                    cmd.Parameters.Add("@" + field.ToString(), fieldValue);
                };
            }
            var query = "UPDATE " + table_name + " SET " + set_columns;
            if (condition == "")
            {
                query += " where(id='" + modelObject.id + "')";
            }
            else {
                query += " where(" + condition + ")";
            }
            Console.WriteLine(query);
            cmd.CommandText = query;
            int objResult = cmd.ExecuteNonQuery();
            conn.Close();
            if (objResult == 1)
            {
                return modelObject;
            }
            else
            {
                return null;
            }
        }

        public object save(dynamic modelObject) {
            return update_attributes(modelObject, "");
        }

        public object update_attribute(dynamic modelObject, string fieldName, String value, string id)
        {
            var table_name = modelObject.getTable();
            Type objType = modelObject.GetType();
            var query = "update " + table_name + " set " + fieldName + " = " + value + "  where id = "+id;
            Console.WriteLine("update " + table_name + " set " + fieldName + " = " + value + " where id = " + id);
            var objResult = executeQuery(query);
            if (objResult)
            {
                return modelObject;
            }
            else
            {
                return null;
            }
        }

        public object update_attributeForSingleRow(dynamic modelObject, string fieldName, dynamic value, string id)
        {
            var table_name = modelObject.getTable();
            Type objType = modelObject.GetType();
            var query = "update " + table_name + " set " + fieldName + " = " + value + "  where id = " + id;
            Console.WriteLine("update " + table_name + " set " + fieldName + " = " + value + " where id = " + id);
            var objResult = executeQuery(query);
            if (objResult)
            {
                return modelObject;
            }
            else
            {
                return null;
            }
        }

        public object getFromDatabase(dynamic modelObject, String query)
        {
           return readExecuteQuery(modelObject, query);
        }

        public Boolean executeQuery(String query) {
           // try
           // {
                Console.WriteLine("Query: " + query);
                MySqlConnection conn = SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(query, conn);
                 SQLConn.cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            //}
            //catch (Exception ex)
           // {
             //   MessageDialog.ShowAlert("" + ex.Message.ToString());
               // return false;
            //}
            //finally
            //{
              //  SQLConn.cmd.Dispose();
                //SQLConn.conn.Close();
            //}
        }

        public object readExecuteQuery(dynamic objectModel, String query)
        {
            //try
            //{
                //MySqlConnection conn = new MySqlConnection();
                Console.WriteLine("Query: " + query);
                MySqlConnection conn = SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(query, conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();
                var objectList = ObjectBuilder.DataReader2Obj(SQLConn.dr, objectModel);
                conn.Close();
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
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  