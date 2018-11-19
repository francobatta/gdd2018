using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.BDManager
{
    public static class BDManager
    {
        private static String getConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost\\SQLSERVER2012";
            builder.UserID = "gdEspectaculos2018";
            builder.Password = "gdEspectaculos2018";
            builder.InitialCatalog = "GD2C2018";
            return builder.ConnectionString;
        }
        public static void updateSet(String tableName, object o) 
        {
            var sql = new StringBuilder("UPDATE " + tableName + " SET ");
            var listaParaUpdate = getPropertiesFromObj().Select(p => p.Name + "=@" + p.Name).ToArray();
            appendList(sql,listaParaUpdate);
        }
        public static void insertInto(String tableName, object o)
        {
            var sql = new StringBuilder("INSERT INTO " + tableName + " (");
            appendList(sql, getPropertiesFromObj().Select(p => p.Name).ToArray());
            sql.Append(" VALUES (");
            appendList(sql, getPropertiesFromObj().Select(p => p.Name).ToArray(), "@");
            queryOptionalObject(sql.ToString(), o, queryTypes.NON_RETURNING_QUERY);
        }
        public static void selectIntoObject(String tableName, String id, Object o) 
        {
            queryOptionalObject("SELECT * FROM " + tableName + " WHERE id=" + id, o, queryTypes.SINGLE_RETURNING_QUERY);
        } // Llena el objeto que le pases de acuerdo al tableName e id que la pases. EN la bd la columna id debe llamarse id
        // La condicion es que los atributos del mismo coincidan con los nombres de los columnas de la tabla (se puede hacer mas generico como que tablename sea de acuerdo al nombre de la clase)
        public static void queryOptionalObject(String sqlQuery,Object o = null, queryTypes qt = queryTypes.NON_RETURNING_QUERY)
        {
            using (SqlConnection connection = new SqlConnection(getConnectionString()))
            {
                myObj = o;
                connection.Open();
                command = new SqlCommand(sqlQuery, connection);
                qt.DoStuff();
                command.Dispose();
            }
        }
        public static SqlCommand command { get; set; }
        public static object myObj { get; set; }
        private static void appendList(StringBuilder sql, String[] s, String preceding = default(string), String appendIfNotLast = ",", String appendIfLast = ")") // no es del dominio, hace appends a un string
        {
            foreach (String st in s)
            {
                sql.Append(preceding + st);
                if (!st.Equals(s[s.Length - 1]))
                    sql.Append(appendIfNotLast);
                else
                    sql.Append(appendIfLast);
            }
        }
        public static PropertyInfo[] getPropertiesFromObj() // no es del dominio, obtiene las properties de un objeto estatico X
        {
            Type myType = BDManager.myObj.GetType();
            PropertyInfo[] props = myType.GetProperties();
            return props;
        }
    }
    public enum queryTypes
    {
        NON_RETURNING_QUERY, SINGLE_RETURNING_QUERY, MULTIPLE_RETURNING_QUERY
    }
    public static class Extensions
    {
        public static void DoStuff(this queryTypes q)
        {
            switch(q)
            {
                case queryTypes.NON_RETURNING_QUERY: {
                    foreach (PropertyInfo p in BDManager.getPropertiesFromObj()) 
                    {
                        BDManager.command.Parameters.AddWithValue("@"+p.Name,p.GetValue(BDManager.myObj));
                    }
                    BDManager.command.ExecuteNonQuery(); break;
                }
                case queryTypes.SINGLE_RETURNING_QUERY:
                    {
                        SqlDataReader reader = BDManager.command.ExecuteReader();
                        reader.Read();
                        foreach (PropertyInfo p in BDManager.getPropertiesFromObj())
                        {
                            p.SetValue(BDManager.myObj, reader[p.Name]);
                        }
                        reader.Close();
                        break; } 
                case queryTypes.MULTIPLE_RETURNING_QUERY:
                    {
                        SqlDataReader reader = BDManager.command.ExecuteReader();
                        MessageBox.Show("Falta implementar porque no tenemos una restriccion clara aun");
                        reader.Close();
                        break; }
            }
        }
    }

}
