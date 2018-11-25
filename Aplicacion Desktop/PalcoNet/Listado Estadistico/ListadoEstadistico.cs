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

    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico(publicacion publicacionAUsar)
        {
            InitializeComponent();
            this.publicacionAUsar = publicacionAUsar;
        }
        private void ListadoEstadistico_Load(object sender, EventArgs e)
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
        public publicacion publicacionAUsar{get;set;}

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            grado gradoSeleccionado = (grado)gradosCombobox.SelectedItem;
            this.publicacionAUsar.id_grado = gradoSeleccionado.id_grado;
            BDManager.updateSet("publicacion","id_publicacion", publicacionAUsar);
            MessageBox.Show("Se modifico el grado", "Grado de la publicacion modificado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
}