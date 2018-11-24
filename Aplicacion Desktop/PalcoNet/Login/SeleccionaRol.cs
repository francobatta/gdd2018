using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    public partial class SeleccionaRol : Form
    {
        public SeleccionaRol()
        {
            InitializeComponent();
        }

        private void SeleccionaRol_Load(object sender, EventArgs e)
        {
            listaRolesUsuario.DataSource = usuarioGlobal.posiblesRoles;
            usernameDisplay.Text = usuarioGlobal.usuarioLogueado.username;
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

    private void btn_ingresar_Click(object sender, EventArgs e)
    {
        try
        {
            DataGridViewRow filaElegida = listaRolesUsuario.CurrentRow;
            if (filaElegida == null || filaElegida.Selected == false)
                throw new CamposInvalidosException();
            rol r = new rol();
            r.id_rol = filaElegida.Cells["id_rol"].Value.ToString();
            r.nombre = filaElegida.Cells["nombre"].Value.ToString();
            usuarioGlobal.rolLogueado = r;
            MessageBox.Show("Rol elegido satisfactoriamente", "Selección de rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // abro menu y cierro esto
            this.Hide();
            var MenuPrincipal = new MenuPrincipal();
            MenuPrincipal.Closed += (s, args) => this.Close();
            MenuPrincipal.Show();
        }
        catch (CamposInvalidosException) { MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar rol", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }
    }