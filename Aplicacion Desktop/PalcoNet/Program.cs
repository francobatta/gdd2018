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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PalcoNet.Registro_de_Usuario.AltaUsuario()); //PA MOSTRAR EL PROGRAMA
            //objetito jijo = new objetito();
            //objetito jijo2 = new objetito();
            //jijo.Espec_Empresa_Razon_Social = "jijto"; // tengo un objeto trucho jijoo, esto es solo de prueba hice una Table_1 y meti unas boludeces
            //jijo.otroValor = "34";
            //PalcoNet.BDManager.BDManager.insertInto("dbo.Table_1", jijo);
            //PalcoNet.BDManager.BDManager.selectIntoObject("dbo.Table_1", "2", jijo2);
            //jijo2.otroValor = "3443";
            //PalcoNet.BDManager.BDManager.updateSet("dbo.Table_1", jijo2);
        }
    }
    public class objetito { public String Espec_Empresa_Razon_Social { get; set; } public String otroValor { get; set; } public int id { get; set; } }
}
