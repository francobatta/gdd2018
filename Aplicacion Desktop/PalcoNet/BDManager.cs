using System;
using System.Collections.Generic;
using System.Data;
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
        public static SqlCommand command { get; set; }
        public static object myObj { get; set; }
        public static Type dummyType { get; set; }
        public static ComboBox toFill { get; set; }
        public static List<object> listaObjetosRetornados = new List<object>();
        private static String getConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost\\SQLSERVER2012";
            builder.UserID = "gdEspectaculos2018";
            builder.Password = "gdEspectaculos2018";
            builder.InitialCatalog = "GD2C2018";
            return builder.ConnectionString;
        }
        public static void delete(String tableName, String idColumn , object o)
        {
            myObj = o;
            var sql = new StringBuilder("DELETE FROM EQUISDE." + tableName);
            if (!myObj.Equals(null))
                sql.Append(" WHERE " + idColumn + "=" + Extensions.getIdFromObj());
            MessageBox.Show(sql.ToString());
            queryOptionalObject(sql.ToString());
        }
        public static void deleteByField(String tableName, String field, String value)
        {
            var sql = new StringBuilder("DELETE FROM EQUISDE." + tableName);
            if (!myObj.Equals(null))
                sql.Append(" WHERE " + field + "=" + value);
            MessageBox.Show(sql.ToString());
            queryOptionalObject(sql.ToString());
        }
        public static void updateSet(String tableName, String idColumn, object o)
        {
            myObj = o;
            var sql = new StringBuilder("UPDATE EQUISDE." + tableName + " SET ");
            var listaParaUpdate = Extensions.getPropertiesFromObj().Select(p => p.Name + "=@" + p.Name).ToArray();
            appendList(sql,listaParaUpdate,"",",","");
            MessageBox.Show(" WHERE " + idColumn + "=" + Extensions.getIdFromObj().First().GetValue(myObj));
            sql.Append(" WHERE "+idColumn +"=" + Extensions.getIdFromObj().First().GetValue(myObj));
            queryOptionalObject(sql.ToString(), queryTypes.NON_RETURNING_QUERY);
        }
        public static void updateSetStringKey(String tableName, String idColumn, String idVal, object o)
        {
            myObj = o;
            var sql = new StringBuilder("UPDATE EQUISDE." + tableName + " SET ");
            var listaParaUpdate = Extensions.getPropertiesFromObj().Select(p => p.Name + "=@" + p.Name).ToArray();
            appendList(sql, listaParaUpdate, "", ",", "");
            sql.Append(" WHERE " + idColumn + "='" + idVal +"'");
            queryOptionalObject(sql.ToString(), queryTypes.NON_RETURNING_QUERY);
        }
        public static void insertInto(String tableName, object o)
        {
            myObj = o;
            var sql = new StringBuilder("INSERT INTO EQUISDE." + tableName + " (");
            appendList(sql, Extensions.getPropertiesFromObj().Select(p => p.Name).ToArray());
            sql.Append(" VALUES (");
            appendList(sql, Extensions.getPropertiesFromObj().Select(p => p.Name).ToArray(), "@");
            MessageBox.Show(sql.ToString());
            queryOptionalObject(sql.ToString());
        }
        public static void insertEncryptedUser(usuario u)
        {
            var sql = new StringBuilder("INSERT INTO EQUISDE.usuario (username,password) VALUES ('"+u.username+"',HASHBYTES('SHA2_256','"+u.password+"'))");
            MessageBox.Show(sql.ToString());
            queryOptionalObject(sql.ToString(),queryTypes.JUST_DO_STUFF);
        }
        public static void updateEncryptedUser(usuario u)
        {
            var sql = new StringBuilder("UPDATE EQUISDE.usuario SET username='" + u.username + "',password=HASHBYTES('SHA2_256','" + u.password + "') WHERE username='"+u.username+"'");
            MessageBox.Show(sql.ToString());
            queryOptionalObject(sql.ToString(), queryTypes.JUST_DO_STUFF);
        }
        public static bool exists(String tableName, String campo, String valor)
        {
            using (SqlConnection connection = new SqlConnection(getConnectionString()))
            {
                connection.Open();
                MessageBox.Show("SELECT 1 FROM EQUISDE." + tableName + " WHERE " + campo + "='" + valor + "'");
                command = new SqlCommand("SELECT 1 FROM EQUISDE." + tableName + " WHERE " + campo + "='" + valor + "'", connection);
                SqlDataReader reader = BDManager.command.ExecuteReader();
                if (reader.Read()) return true;
                reader.Close();
                command.Dispose();
                return false;
            }
        }
        public static void genericFillObject(String query, object o)
        {
            myObj = o;
            queryOptionalObject(query, queryTypes.SINGLE_RETURNING_QUERY);
            o = myObj;
        }
        public static List<object> getList(String query,object contenedorGenerico) // no pude usar generics porque el C# se enoja con la clase estatica. o define el
        {
            dummyType = contenedorGenerico.GetType();
            queryOptionalObject(query, queryTypes.MULTIPLE_RETURNING_QUERY);
            return listaObjetosRetornados;
        }
        public static void selectIntoObject(String tableName, String idColumn, String id, Object o)
        {
            myObj = o;
            var sql = "SELECT * FROM EQUISDE." + tableName + " WHERE " + idColumn + "=" + id;
            MessageBox.Show(sql);
            queryOptionalObject(sql, queryTypes.SINGLE_RETURNING_QUERY);
        }
        public static void selectIntoObjectByString(String tableName, String col, String val, Object o)
        {
            myObj = o;
            var sql = "SELECT * FROM EQUISDE." + tableName + " WHERE " + col + "='" + val + "'";
            MessageBox.Show(sql);
            queryOptionalObject(sql, queryTypes.SINGLE_RETURNING_QUERY);
        }
        public static void queryOptionalObject(String sqlQuery, queryTypes qt = queryTypes.NON_RETURNING_QUERY)
        {
            using (SqlConnection connection = new SqlConnection(getConnectionString()))
            {
                connection.Open();
                command = new SqlCommand(sqlQuery, connection);
                qt.DoStuff();
                command.Dispose();
            }
        }
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
        public static DataTable getData(string selectCommand)
        {
                using (SqlConnection connection = new SqlConnection(getConnectionString()))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    return table;
                }
        }

    }
    public enum queryTypes
    {
        NON_RETURNING_QUERY, SINGLE_RETURNING_QUERY, MULTIPLE_RETURNING_QUERY,
        JUST_DO_STUFF
    }
    public static class Extensions
    {
        public static PropertyInfo[] getPropertiesFromObj() // no es del dominio, obtiene las properties de un objeto estatico X menos su id
        {
            Type myType = BDManager.myObj.GetType();
            PropertyInfo[] props = myType.GetProperties();
            return props.Where(p => p.Name != "id_"+myType.Name).ToArray();
        }
        public static PropertyInfo[] getIdFromObj() // no es del dominio, obtiene el id de un objeto estatico X
        {
            Type myType = BDManager.myObj.GetType();
            PropertyInfo[] props = myType.GetProperties();
            return props.Where(p => p.Name == "id_"+myType.Name).ToArray();
        }
        public static void DoStuff(this queryTypes q)
        {
            switch(q)
            {
                case queryTypes.JUST_DO_STUFF:
                    {
                        BDManager.command.ExecuteNonQuery(); break;
                    }
                case queryTypes.NON_RETURNING_QUERY: {
                    foreach (PropertyInfo p in getPropertiesFromObj()) 
                    {
                        BDManager.command.Parameters.AddWithValue("@" + p.Name, p.GetValue(BDManager.myObj) ?? DBNull.Value); // ?? para que null no de error
                    }
                    BDManager.command.ExecuteNonQuery(); break;
                }
                case queryTypes.SINGLE_RETURNING_QUERY:
                    {
                        SqlDataReader reader = BDManager.command.ExecuteReader();
                        reader.Read();
                        foreach (PropertyInfo p in getPropertiesFromObj())
                        {
                            p.SetValue(BDManager.myObj, (reader[p.Name] == DBNull.Value ?  default(string) : reader[p.Name].ToString()));
                        }
                        foreach (PropertyInfo p in getIdFromObj())
                        {
                            p.SetValue(BDManager.myObj, (reader[p.Name] == DBNull.Value ? default(string) : reader[p.Name].ToString()));
                        } // en el caso del insert es necesario otorgar el id al objeto
                        reader.Close();
                        break; } 
                case queryTypes.MULTIPLE_RETURNING_QUERY:
                    {
                        BDManager.listaObjetosRetornados = new List<object>();
                        SqlDataReader reader = BDManager.command.ExecuteReader();
                        while (reader.Read())
                        {
                            propsFromObj propGetter = new propsFromObj();
                            object instance = Activator.CreateInstance(BDManager.dummyType);
                            foreach (PropertyInfo p in propGetter.getPropertiesFromObj(instance))
                            {
                                p.SetValue(instance, (reader[p.Name] == DBNull.Value ? default(string) : reader[p.Name].ToString()));
                            }
                            foreach (PropertyInfo p in propGetter.getIdFromObj(instance))
                            {
                                p.SetValue(instance, (reader[p.Name] == DBNull.Value ? default(string) : reader[p.Name].ToString()));
                            }
                            BDManager.listaObjetosRetornados.Add(instance);
                        }
                        reader.Close();
                        break;
                    }
            }
        }
    }
    public class propsFromObj
    {
        public PropertyInfo[] getPropertiesFromObj(object o) // no es del dominio, obtiene las properties de un objeto estatico X menos su id
        {
            Type myType = o.GetType();
            PropertyInfo[] props = myType.GetProperties();
            return props.Where(p => p.Name != "id_"+myType.Name).ToArray();
        }
        public PropertyInfo[] getIdFromObj(object o) // no es del dominio, obtiene el id de un objeto estatico X
        {
            Type myType = o.GetType();
            PropertyInfo[] props = myType.GetProperties();
            return props.Where(p => p.Name == "id_"+myType.Name).ToArray();
        }
    }

}
