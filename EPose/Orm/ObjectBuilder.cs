using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPose.Orm
{
    class ObjectBuilder
    {
        public static object DataReader2Obj(MySqlDataReader rdr, dynamic objectModel)
        {
            IList<Object> list = new List<Object>();

            while (rdr.Read())
            {
                object t = Activator.CreateInstance(objectModel.GetType());
                Type obj = objectModel.GetType();
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    object tempValue = null;
                    if (rdr.IsDBNull(i))
                    {
                        string typeFullName = obj.GetProperty(rdr.GetName(i)).PropertyType.FullName;
                        tempValue = GetDBNullValue(typeFullName);
                    }
                    else
                    {
                        tempValue = rdr.GetValue(i);
                    }
                    var property = obj.GetProperty(rdr.GetName(i));
                    if (property != null)
                    {
                        property.SetValue(t, tempValue, null);
                    }
                }
                list.Add(t);
            }
            return list;
        }  

        private static object GetDBNullValue(string typeFullName)
        {
            typeFullName = typeFullName.ToLower();
            if (typeFullName == "string")
            {
                return String.Empty;
            }
            if (typeFullName == "int32")
            {
                return 0;
            }
            if (typeFullName == "datetime")
            {
                return DateTime.Now;
            }
            if (typeFullName == "boolean")
            {
                return false;
            }
            if (typeFullName == "int")
            {
                return 0;
            }

            return null;
        } 
    }
}
