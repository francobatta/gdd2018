using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class funcionalidad
    {
        public funcionalidad() { }
        public funcionalidad(String id_funcionalidad, String nombre)
        {
            this.id_funcionalidad = id_funcionalidad;
            this.nombre = nombre;
        }
        public String id_funcionalidad { get; set; }
        public String nombre { get; set; }
    }