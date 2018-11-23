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

    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
        }
        private void AltaRol_Load(object sender, EventArgs e)
        {
            BDManager.fillComboBoxFrom("SELECT id_funcionalidad,nombre FROM EQUISDE.funcionalidad",funcionalidades);
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            nombre.Text = default(String);
            listaFuncionalidadesAsignadas.Items.Clear();
        }
    }