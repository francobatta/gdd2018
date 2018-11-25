using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class cliente
    {
        public cliente() 
        {
            this.fecha_creacion = DateTime.Today.ToString();
        }
        public String id_direccion { get; set; }
        public String username { get; set; }
        public String nombre {get;set;}
        public String apellido {get;set;}
        public String tipo_documento {get;set;}
        public String dni {get;set;}
        public String CUIL {get;set;}
        public String mail {get;set;}
        public String telefono {get;set;}
        public String habilitado { get; set; }
        public String puntos { get; set; }
        public String fecha_creacion { get; set; }
        public String fecha_nacimiento {get;set;}
    }
