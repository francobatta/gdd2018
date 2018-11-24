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
            usuario u = new usuario();
            u.username = "jijo2";
            u.password = "buta2";
            BDManager.BDManager.insertEncryptedUser(u);
            Application.Run(new RegistraUsuario(u)); //PA MOSTRAR EL PROGRAMA
        }
    }
}
