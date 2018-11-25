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
    public partial class BusquedaEmpresa : Form
    {
        public BusquedaEmpresa()
        {
            InitializeComponent();
        }
        private void BusquedaEmpresa_Load(object sender, EventArgs e)
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
                DataGridViewRow filaElegida = listadoEmpresas.CurrentRow;
                if (filaElegida == null || filaElegida.Selected == false)
                    throw new CamposInvalidosException();
                empresa emp = new empresa();
                BDManager.selectIntoObjectByString("empresa", "username", filaElegida.Cells["username"].Value.ToString(),emp);
                usuario us = new usuario();
                BDManager.selectIntoObject("usuario", "username", emp.username, us);
                ModificaEmpresa m = new  ModificaEmpresa (us);
                m.ShowDialog();
                this.Close();
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                validarCamposEmpresa();
                listadoEmpresas.DataSource = BDManager.getData(
                   "SELECT * FROM EQUISDE.empresa WHERE razon_social LIKE '%" + razonSocial.Text + "%' AND cuit LIKE '%" + CUIT.Text + "%' AND mail LIKE '%" + email.Text + "%'"
                   );
            }
            catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos de la empresa a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.razonSocial.Text = default(String);
            this.CUIT.Text = default(String);
            this.email.Text = default(String);
            listadoEmpresas.DataSource = null;
        }
        private void validarCamposEmpresa()
        {
            Validaciones.inicializarValidador();
            Validaciones.esValido(email.Name, email.Text, new Validaciones.Email());
            Validaciones.esValido(CUIT.Name, CUIT.Text, new Validaciones.CUIT());
            Validaciones.esValido(razonSocial.Name, razonSocial.Text, new Validaciones.NumerosLetrasGuion());
            if (!String.IsNullOrEmpty(Validaciones.camposInvalidos))
                throw new CamposInvalidosException();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow filaElegida = listadoEmpresas.CurrentRow;
                if (filaElegida == null || filaElegida.Selected == false)
                    throw new CamposInvalidosException();
                empresa emp = new empresa();
                BDManager.selectIntoObjectByString("empresa", "username", filaElegida.Cells["username"].Value.ToString(),emp);
                emp.habilitado = "False";
                BDManager.updateSetStringKey("empresa", "username", emp.username, emp);
                MessageBox.Show("Empresa " + emp.razon_social+ ' ' + emp.cuit + " inhabilitado con éxito", "Inhabilitación de empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }