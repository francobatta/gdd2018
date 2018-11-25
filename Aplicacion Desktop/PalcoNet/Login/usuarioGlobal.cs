using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public static class usuarioGlobal
    {
        public static usuario usuarioLogueado { get; set; }
        public static rol rolLogueado { get; set; }
        public static List<rol> posiblesRoles { get; set; }
        public static int numeroDeIntentos = 3;
        public static void restarIntento()
        {
            numeroDeIntentos -= 1;
        }
    }