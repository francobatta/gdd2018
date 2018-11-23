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
        public static SqlCommand command { get; set; }
        public static object myObj { get; set; }
        public static ComboBox toFill { get; set; }
        private static String getConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost\\SQLSERVER2012";
            builder.UserID = "gdEspectaculos2018";
            builder.Password = "gdEspectaculos2018";
            builder.InitialCatalog = "GD2C2018";
            return builder.ConnectionString;
        }
        public static void delete(String tableName, String idColumn , object o = null)
        {
            myObj = o;
            var sql = new StringBuilder("DELETE FROM EQUISDE." + tableName);
            if (!myObj.Equals(null))
                sql.Append(" WHERE " + idColumn + "=" + Extensions.getIdFromObj());
            MessageBox.Show(sql.ToString());
            queryOptionalObject(sql.ToString());
        }
        public static void updateSet(String tableName, object o)
        {
            myObj = o;
            var sql = new StringBuilder("UPDATE EQUISDE." + tableName + " SET ");
            var listaParaUpdate = Extensions.getPropertiesFromObj().Select(p => p.Name + "=@" + p.Name).ToArray();
            appendList(sql,listaParaUpdate,"",",","");
            sql.Append(" WHERE id=" + Extensions.getIdFromObj().First().GetValue(myObj));
            MessageBox.Show(sql.ToString());
            queryOptionalObject(sql.ToString());
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
        public static void fillComboBoxFrom(String s, object o, ComboBox c)
        {
            toFill = c;
            myObj = o;
            queryOptionalObject(s, queryTypes.FILL_COMBOBOX);
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
    }
    public enum queryTypes
    {
        NON_RETURNING_QUERY, SINGLE_RETURNING_QUERY, MULTIPLE_RETURNING_QUERY,
        FILL_COMBOBOX
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
                        SqlDataReader reader = BDManager.command.ExecuteReader();
                        MessageBox.Show("Falta implementar porque no tenemos una restriccion clara aun");
                        reader.Close();
                        break; }
                case queryTypes.FILL_COMBOBOX:
                    {
                        SqlDataReader reader = BDManager.command.ExecuteReader();
                        while (reader.Read())
                        {
                            BDManager.toFill.Items.Add(new { id = reader["id_"+BDManager.myObj.GetType().Name].ToString(), nombre = reader["nombre"].ToString() });
                        }
                        BDManager.toFill.ValueMember = "id";
                        BDManager.toFill.DisplayMember = "nombre";
                        BDManager.toFill.SelectedIndex = 0;
                        reader.Close();
                        break;
                    }
            }
        }
    }

}
