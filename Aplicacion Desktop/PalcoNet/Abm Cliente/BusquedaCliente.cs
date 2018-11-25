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
    public partial class BusquedaCliente : Form
    {
        public BusquedaCliente()
        {
            InitializeComponent();
        }
        private void BusquedaCliente_Load(object sender, EventArgs e)
        {
            tipoDoc.Items.Add("DNI");
            tipoDoc.Items.Add("LE");
            tipoDoc.Items.Add("CI");
            //tipoDoc.SelectedIndex = 0;
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

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           listadoClientes.DataSource = BDManager.getData(
               "SELECT * FROM EQUISDE.cliente WHERE nombre LIKE '%" + nombre.Text + "%' AND apellido LIKE '%" + apellido.Text + "%' AND tipo_documento LIKE '%" + tipoDoc.Text + "%' AND dni LIKE '%" + nDoc.Text + "%' AND mail LIKE '%" + email.Text + "%'"
               );
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.nombre.Text = default(String);
            this.apellido.Text = default(String);
            this.tipoDoc.SelectedIndex = -1;
            this.nDoc.Text = default(String);
            this.email.Text = default(String);
            listadoClientes.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow filaElegida = listadoClientes.CurrentRow;
                if (filaElegida == null || filaElegida.Selected == false)
                    throw new CamposInvalidosException();
                cliente clienteACambiar = new cliente();
                BDManager.selectIntoObjectByString("cliente", "username", filaElegida.Cells["username"].Value.ToString(), clienteACambiar);
                clienteACambiar.habilitado = "False";
                BDManager.updateSetStringKey("cliente", "username", clienteACambiar.username, clienteACambiar);
                MessageBox.Show("Cliente " + clienteACambiar.nombre +' '+ clienteACambiar.apellido + " inhabilitado con éxito", "Inhabilitación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }