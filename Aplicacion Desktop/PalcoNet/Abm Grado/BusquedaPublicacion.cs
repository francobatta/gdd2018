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
    public partial class BusquedaPublicacion : Form
    {
        public BusquedaPublicacion()
        {
            InitializeComponent();
        }
        private void BusquedaPublicacion_Load(object sender, EventArgs e)
        {
            listadoActualPublicacion.DataSource = BDManager.getData("SELECT * FROM EQUISDE.publicacion WHERE username = '" + "06-68361819-16" + "'");
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

        private void btn_elegir_grado_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow filaElegida = listadoActualPublicacion.CurrentRow;
                if (filaElegida == null || filaElegida.Selected == false)
                    throw new CamposInvalidosException();
                publicacion publicacionAUsar = new publicacion();
                BDManager.selectIntoObject("publicacion", "id_publicacion", filaElegida.Cells["id_publicacion"].Value.ToString(), publicacionAUsar);
                ElegirGrado elegirGrado = new ElegirGrado(publicacionAUsar); // SE LO PASO POR CONSTRUCTOR Y QUE EL MODIFICADOR SE ENCARGUE
                elegirGrado.ShowDialog();
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar publicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listadoActualPublicacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }