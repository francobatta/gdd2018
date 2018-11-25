using PalcoNet.BDManager;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    public partial class ListadoEstadistico : Form
    {
        public String anio{get;set;}
        public String mes_dia_inicio { get; set; }
        public String mes_dia_fin { get; set; }
        public ListadoEstadistico()
        {
            InitializeComponent();
        }
        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            Combobox_listado.Items.Add("Empresas con mayor cantidad de localidades no vendidas");
            Combobox_listado.Items.Add("Clientes con mayores puntos vencidos");
            Combobox_listado.Items.Add("Clientes con mayor cantidad de compras");
            mes_dia_inicio = "01/01";
            mes_dia_fin = "03/31";
            for (int i = 1990; i <= Convert.ToInt32(ConfigurationManager.AppSettings["fecha_actual"].Substring(0,4)); i++)
            {
                comboAnio.Items.Add(i.ToString());
            }
           
        }
        // controles de cualquier form
        private void closingLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizingLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        protected override void WndProc(ref Message m) // PARA QUE SE PUEDA HACER DRAGGING DEL FORM
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void Combobox_listado_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboAnio.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.anio = (String)comboAnio.SelectedItem;
            primerTrimestre.Enabled = true;
            segundoTrimestre.Enabled = true;
            tercerTrimestre.Enabled = true;
            cuartoTrimestre.Enabled = true;
            primerTrimestre.Checked = true;
            btn_listado.Enabled = true;
        }

        private void segundoTrimestre_CheckedChanged(object sender, EventArgs e)
        {
            mes_dia_inicio = "04/01";
            mes_dia_fin = "06/30";
        }

        private void tercerTrimestre_CheckedChanged(object sender, EventArgs e)
        {
            mes_dia_inicio = "07/01";
            mes_dia_fin = "09/30";
        }

        private void cuartoTrimestre_CheckedChanged(object sender, EventArgs e)
        {
            mes_dia_inicio = "10/30";
            mes_dia_fin = "12/31";
        }

        private void primerTrimestre_CheckedChanged(object sender, EventArgs e)
        {
            mes_dia_inicio = "01/01";
            mes_dia_fin = "03/31";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            switch ((String)Combobox_listado.SelectedItem)
            {

                case "Empresas con mayor cantidad de localidades no vendidas":
                    listado_estadistico.DataSource = BDManager.getData("SELECT TOP 5 p.username,cuit,estado visibilidad,COUNT(*) cantidad FROM EQUISDE.publicacion p JOIN EQUISDE.empresa e ON(p.username = e.username) JOIN EQUISDE.grado g ON(g.id_grado=p.id_grado) JOIN EQUISDE.ubicacion u ON (p.id_publicacion=u.id_publicacion) LEFT JOIN EQUISDE.compra_x_ubicacion cu ON (u.id_ubicacion = cu.id_ubicacion)  WHERE cu.id_compra IS NULL AND p.fecha_publicacion BETWEEN CAST('" + anio + "/" + mes_dia_inicio + "' AS date) AND CAST('" + anio + "/" + mes_dia_fin + "' AS date) GROUP BY p.username,cuit,razon_social,estado,fecha_publicacion,p.id_grado,p.id_publicacion ORDER BY  cantidad DESC,fecha_publicacion,p.id_grado ASC");
                    break;
                case "Clientes con mayores puntos vencidos":
                    listado_estadistico.DataSource = BDManager.getData("SELECT TOP 5 nombre,apellido,COUNT(id_compra)cantidad FROM EQUISDE.cliente cl JOIN EQUISDE.compra cp ON (cl.username = cp.username) WHERE cp.fecha_vencimiento_puntos < '" + ConfigurationManager.AppSettings["fecha_actual"] + "' AND cp.fecha_vencimiento_puntos BETWEEN CAST('" + anio + "/" + mes_dia_inicio + "' AS datetime) AND CAST('" + anio + "/" + mes_dia_fin + "' AS datetime) GROUP BY nombre,apellido ORDER BY 3 DESC");
                    break;
                case "Clientes con mayor cantidad de compras":
                    listado_estadistico.DataSource = BDManager.getData("SELECT TOP 5 nombre, apellido, COUNT(cp.id_compra) cantidad_compra, p.username usuario_empresa FROM EQUISDE.cliente cl JOIN EQUISDE.compra cp ON (cp.username = cl.username) JOIN EQUISDE.compra_x_ubicacion cu ON (cp.id_compra = cu.id_compra) JOIN EQUISDE.ubicacion u ON(cu.id_ubicacion = u.id_ubicacion) JOIN EQUISDE.publicacion p ON (p.id_publicacion = u.id_publicacion) WHERE cp.fecha_compra BETWEEN CAST('" + anio + "/" + mes_dia_inicio + "' AS date) AND CAST('" + anio + "/" + mes_dia_fin + "' AS date) GROUP BY nombre,apellido,p.username ORDER BY cantidad_compra DESC");
                    break;
            }
        }
}