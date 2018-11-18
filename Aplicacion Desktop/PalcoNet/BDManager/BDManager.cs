using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.BDManager
{
    public class BDManager
    {
        static String getConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost\\SQLSERVER2012";
            builder.UserID = "gdEspectaculos2018";
            builder.Password = "gdEspectaculos2018";
            builder.InitialCatalog = "GD2C2018";
            return builder.ConnectionString;
        }
        public static void metodoDeEjemplo()
        {
            using (SqlConnection connection = new SqlConnection(getConnectionString()))
            {
                connection.Open();
                String sql = "SELECT Ubicacion_Asiento FROM gd_esquema.Maestra";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    object s = command.ExecuteScalar();
                    MessageBox.Show("me pude conectar y con ExecuteScalar tiro un (1) registro de Ubicacion_Asiento: " + s.ToString());
                }
            }
        }
    }
}
