using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class tarjeta
    {
        public tarjeta()
        {
            this.importe = "5000";
        }
        public String nro_tarjeta { get; set; }
        public String username { get; set; }
        public String cod_seguridad { get; set; }
        public String nombre_titular { get; set; }
        public String fecha_vencimiento { get; set; }
        public String importe { get; set; }
    }
