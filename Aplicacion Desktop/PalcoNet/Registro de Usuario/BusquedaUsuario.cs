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

    public partial class BusquedaUsuario : Form
    {
        public BusquedaUsuario()
        {
            InitializeComponent();
        }
        private void BusquedaUsuario_Load(object sender, EventArgs e)
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

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow filaElegida = listadoUsuarios.CurrentRow;
                if (filaElegida == null || filaElegida.Selected == false)
                    throw new CamposInvalidosException();
                usuario aCambiar = new usuario();
                BDManager.selectIntoObjectByString("usuario", "username",filaElegida.Cells["username"].Value.ToString(), aCambiar);
                ModificaUsuario modificaUsuario = new ModificaUsuario(aCambiar); // SE LO PASO POR CONSTRUCTOR Y QUE EL MODIFICADOR SE ENCARGUE
                modificaUsuario.ShowDialog();
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar rol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            listadoUsuarios.DataSource = BDManager.getData("SELECT username, habilitado FROM EQUISDE.usuario WHERE username LIKE '%" + username.Text + "%'");
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            listadoUsuarios.DataSource = null;
            username.Text = default(String);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow filaElegida = listadoUsuarios.CurrentRow;
                if (filaElegida == null || filaElegida.Selected == false)
                    throw new CamposInvalidosException();
                usuario usuarioACambiar = new usuario();
                BDManager.selectIntoObjectByString("usuario", "username", filaElegida.Cells["username"].Value.ToString(), usuarioACambiar);
                usuarioACambiar.habilitado = "False";
                BDManager.updateSetStringKey("usuario", "username",usuarioACambiar.username, usuarioACambiar);
                MessageBox.Show("Usuario " + usuarioACambiar.username + " inhabilitado con éxito", "Inhabilitación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }