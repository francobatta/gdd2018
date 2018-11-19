using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.BDManager
{
    public static class BDManager
    {
        //abstract void DoStuff(SqlCommand com);
        private static String getConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost\\SQLSERVER2012";
            builder.UserID = "gdEspectaculos2018";
            builder.Password = "gdEspectaculos2018";
            builder.InitialCatalog = "GD2C2018";
            return builder.ConnectionString;
        }
        public static void queryOptionalObject(String sqlQuery,Object o = null, queryTypes qt = queryTypes.NON_RETURNING_QUERY)
        {
            using (SqlConnection connection = new SqlConnection(getConnectionString()))
            {
                connection.Open();
                command = new SqlCommand(sqlQuery, connection);
                qt.DoStuff();
            }
        }
        public static SqlCommand command { get; set; }
    }
    public enum queryTypes
    {
        NON_RETURNING_QUERY, SINGLE_RETURNING_QUERY, MULTIPLE_RETURNING_QUERY
    }
    public static class Extensions
    {
        public static object DoStuff(this queryTypes q)
        {
            switch(q)
            {
                case queryTypes.NON_RETURNING_QUERY: { BDManager.command.ExecuteNonQuery(); return null; }
                case queryTypes.SINGLE_RETURNING_QUERY: return null;
                case queryTypes.MULTIPLE_RETURNING_QUERY: return null;
            }
            return null;
        }
    }
}
