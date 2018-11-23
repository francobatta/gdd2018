﻿using System;
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
            var sql = new StringBuilder("DELETE FROM " + tableName);
            if (!myObj.Equals(null))
                sql.Append(" WHERE " + idColumn + "=" + Extensions.getIdFromObj());
            MessageBox.Show(sql.ToString());
            queryOptionalObject(sql.ToString());
        }
        public static void updateSet(String tableName, object o)
        {
            myObj = o;
            var sql = new StringBuilder("UPDATE " + tableName + " SET ");
            var listaParaUpdate = Extensions.getPropertiesFromObj().Select(p => p.Name + "=@" + p.Name).ToArray();
            appendList(sql,listaParaUpdate,"",",","");
            sql.Append(" WHERE id=" + Extensions.getIdFromObj().First().GetValue(myObj));
            MessageBox.Show(sql.ToString());
            queryOptionalObject(sql.ToString());
        }
        public static void insertInto(String tableName, object o)
        {
            myObj = o;
            var sql = new StringBuilder("INSERT INTO " + tableName + " (");
            appendList(sql, Extensions.getPropertiesFromObj().Select(p => p.Name).ToArray());
            sql.Append(" VALUES (");
            appendList(sql, Extensions.getPropertiesFromObj().Select(p => p.Name).ToArray(), "@");
            MessageBox.Show(sql.ToString());
            queryOptionalObject(sql.ToString());
        }
        public static void selectIntoObject(String tableName, String idColumn, String id, Object o)
        {
            myObj = o;
            var sql = "SELECT * FROM " + tableName + " WHERE " + idColumn + "=" + id;
            MessageBox.Show(sql);
            queryOptionalObject(sql, queryTypes.SINGLE_RETURNING_QUERY);
        } // Llena el objeto que le pases de acuerdo al tableName e id que la pases. EN la bd la columna id debe llamarse id
        // La condicion es que los atributos del mismo coincidan con los nombres de los columnas de la tabla (se puede hacer mas generico como que tablename sea de acuerdo al nombre de la clase)
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
        public static void fillComboBoxFrom(String s, ComboBox c)
        {
            toFill = c;
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
            return props.Where(p => p.Name != "id").ToArray();
        }
        public static PropertyInfo[] getIdFromObj() // no es del dominio, obtiene el id de un objeto estatico X
        {
            Type myType = BDManager.myObj.GetType();
            PropertyInfo[] props = myType.GetProperties();
            return props.Where(p => p.Name == "id").ToArray();
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
                            p.SetValue(BDManager.myObj, (reader[p.Name] == DBNull.Value ?  default(string) : reader[p.Name]));
                        }
                        foreach (PropertyInfo p in getIdFromObj())
                        {
                            p.SetValue(BDManager.myObj, (reader[p.Name] == DBNull.Value ? default(string) : reader[p.Name]));
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
                            BDManager.toFill.Items.Add(new { id = reader.GetString(0), name = reader.GetString(1) });
                        }
                        BDManager.toFill.ValueMember = "id";
                        BDManager.toFill.DisplayMember = "name";
                        reader.Close();
                        break;
                    }
            }
        }
    }

}
