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

    public partial class RendicionComisiones : Form
    {
        public RendicionComisiones()
        {
            InitializeComponent();
        }
        private void RendicionComisiones_Load(object sender, EventArgs e)
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

        private void btn_verSinRendir_Click(object sender, EventArgs e)
        {
            
            listadoComprasNoRendidas.DataSource = BDManager.getData("SELECT * FROM EQUISDE.compra WHERE id_compra NOT IN (SELECT DISTINCT id_compra FROM EQUISDE.item) ORDER BY 4");
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            listadoComprasNoRendidas.DataSource = null;
        }

        private void rendirElegidas_Click(object sender, EventArgs e)
        {
            
        }

        private void agregar_a_rendir_Click(object sender, EventArgs e)
        {
            listadoComprasARendir.DataSource = BDManager.getData("SELECT TOP " + nroComprasAAgregar.Text + " * FROM EQUISDE.compra WHERE id_compra NOT IN (SELECT DISTINCT id_compra FROM EQUISDE.item) ORDER BY 4");
        }
    }
