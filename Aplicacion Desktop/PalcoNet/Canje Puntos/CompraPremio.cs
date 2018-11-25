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
using PalcoNet.Canje_Puntos;

    public partial class CompraPremio : Form
    {
        public int puntosActuales;
        public CompraPremio(int puntosActuales)
        {
            this.puntosActuales = puntosActuales;
            InitializeComponent();
        }
        private void CompraPremio_Load(object sender, EventArgs e)
        {
            puntos_actual.Text = this.puntosActuales.ToString();
            listadoPremios.DataSource = BDManager.getData("SELECT descripcion,puntos_necesarios,fecha_emision,fecha_vencimiento  FROM EQUISDE.premio WHERE fecha_vencimiento > getDate()");
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
                DataGridViewRow filaElegida = listadoPremios.CurrentRow;
                if (filaElegida == null || filaElegida.Selected == false)
                    throw new CamposInvalidosException();
                if (Convert.ToInt32(filaElegida.Cells["puntos_necesarios"].Value) > this.puntosActuales)
                {
                    throw new PuntosFaltanteException();
                }
                premio_x_cliente premioCliente = new premio_x_cliente();
                //BDManager.selectIntoObject("publicacion", "id_publicacion", filaElegida.Cells["id_publicacion"].Value.ToString(), publicacionAUsar);
                //ElegirGrado elegirGrado = new ElegirGrado(publicacionAUsar); // SE LO PASO POR CONSTRUCTOR Y QUE EL MODIFICADOR SE ENCARGUE
                //elegirGrado.ShowDialog();
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar un premio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (PuntosFaltanteException) {
                MessageBox.Show("Error: Los puntos necesarios para comprar el premio son mayores a los puntos obtenidos", "Error al comprar un premio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listadoActualPublicacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }