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

public partial class nuevaTarjeta : Form
    {
        public nuevaTarjeta()
        {
            InitializeComponent();
        }
        private void nuevaTarjeta_Load(object sender, EventArgs e)
        {
          
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                tarjeta tar = new tarjeta();
                tar.nro_tarjeta = NroTarjeta.Text;
                tar.username = usuarioGlobal.usuarioLogueado.username;
                tar.nombre_titular = NombreTitular.Text;
                tar.fecha_vencimiento = FechaVencimiento.Text;
                tar.cod_seguridad = CodSeguridad.Text;
                MessageBox.Show("La tarjeta ha sido insertado", "Tarjeta insertada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
        }
    }
