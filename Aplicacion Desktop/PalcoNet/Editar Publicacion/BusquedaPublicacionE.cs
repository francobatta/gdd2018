using PalcoNet.BDManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    public partial class BusquedaPublicacionE : Form
    {
        public BusquedaPublicacionE()
        {
            InitializeComponent();
        }
        private void BusquedaPublicacionE_Load(object sender, EventArgs e)
        {
            listadoPublicaciones.DataSource = BDManager.getData("SELECT * FROM EQUISDE.publicacion WHERE id_estado=2 AND username='"+usuarioGlobal.usuarioLogueado.username+ "'");
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

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow filaElegida = listadoPublicaciones.CurrentRow;
                if (filaElegida == null || filaElegida.Selected == false)
                    throw new CamposInvalidosException();
                publicacion p = new publicacion();
                p.id_publicacion = filaElegida.Cells["id_publicacion"].Value.ToString();
                p.id_rubro = filaElegida.Cells["id_rubro"].Value.ToString();
                p.id_direccion = filaElegida.Cells["id_estado"].Value.ToString();
                p.id_grado = filaElegida.Cells["id_grado"].Value.ToString();
                p.id_estado = "2";
                p.descripcion = filaElegida.Cells["descripcion"].Value.ToString();
                p.fecha_publicacion = filaElegida.Cells["fecha_publicacion"].Value.ToString();
                p.fecha_vencimiento = filaElegida.Cells["fecha_vencimiento"].Value.ToString();
                ModificaPublicacion m = new ModificaPublicacion(p);
                m.ShowDialog();
                this.Close();
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }