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
            objetito jijo2 = new objetito();
            jijo.Espec_Empresa_Razon_Social = "jijto"; // tengo un objeto trucho jijoo, esto es solo de prueba hice una Table_1 y meti unas boludeces
            jijo.otroValor = "34";
            PalcoNet.BDManager.BDManager.insertInto("dbo.Table_1", jijo);
            PalcoNet.BDManager.BDManager.selectIntoObject("dbo.Table_1", "2", jijo2);
            MessageBox.Show(jijo.Espec_Empresa_Razon_Social + " " + jijo2.Espec_Empresa_Razon_Social + "si son iguales hizo bien");
            MessageBox.Show(jijo.otroValor + " " + jijo2.otroValor + "si son iguales hizo bien");
            jijo2.otroValor = "3443";
            PalcoNet.BDManager.BDManager.updateSet("dbo.Table_1", jijo2);
            MessageBox.Show(jijo2.otroValor + " debe ser 3443 y " + jijo2.Espec_Empresa_Razon_Social + "debe ser jijito");
        }
    }
    public class objetito { public String Espec_Empresa_Razon_Social { get; set; } public String otroValor {get; set;} }
}
