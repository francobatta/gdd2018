using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1()); PA MOSTRAR EL PROGRAMA
            objetito jijo = new objetito();
            jijo.Espec_Empresa_Razon_Social = "ASDASDJ#JIEEEEEEEEEEEE";
            PalcoNet.BDManager.BDManager.queryOptionalObject("SELECT * FROM gd_esquema.Maestra", jijo, PalcoNet.BDManager.queryTypes.SINGLE_RETURNING_QUERY); // MUESTRO BD
            MessageBox.Show(jijo.Espec_Empresa_Razon_Social.ToString());
        }
    }
    public class objetito { public String Espec_Empresa_Razon_Social { get; set; } }
}
