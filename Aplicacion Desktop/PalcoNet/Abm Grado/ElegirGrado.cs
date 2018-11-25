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

    public partial class ElegirGrado : Form
    {
        public ElegirGrado(publicacion publicacionAUsar)
        {
            InitializeComponent();
            this.publicacionAUsar = publicacionAUsar;
        }
        private void ElegirGrado_Load(object sender, EventArgs e)
        {
            id.Text = this.publicacionAUsar.id_publicacion;
            descripcion.Text = this.publicacionAUsar.descripcion;
            if (publicacionAUsar.id_grado != null)
            {
                grado grade = new grado();
                BDManager.selectIntoObject("grado", "id_grado", publicacionAUsar.id_grado, grade);
                gradoActual.Text = grade.estado;
            }
            List<object> listaTraidaDeBD = BDManager.getList("SELECT * FROM EQUISDE.grado", new grado());
            List<grado> listaGradosDeBD = listaTraidaDeBD.Cast<grado>().ToList();
            gradosCombobox.DataSource = listaGradosDeBD;
            gradosCombobox.DisplayMember = "estado";
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
            BDManager.updateSet("publicacion", this.publicacionAUsar.id_publicacion, publicacionAUsar);
            MessageBox.Show("Se modifico el grado", "Grado de la publicacion modificado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            gradosCombobox.Text = default(String);
        }
    }