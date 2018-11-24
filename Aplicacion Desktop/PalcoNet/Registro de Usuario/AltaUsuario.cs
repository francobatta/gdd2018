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
using PalcoNet.Registro_de_Usuario;

    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            List<object> listaTraidaDeBD = BDManager.getList("SELECT * FROM EQUISDE.rol", new rol());
            List<rol> listaRolesdeBD = listaTraidaDeBD.Cast<rol>().ToList();
            comboboxRoles.DataSource = listaRolesdeBD;
            comboboxRoles.DisplayMember = "nombre";
            listaRoles.DisplayMember = "nombre";
        }
        private void btn_agregarRol_Click(object sender, EventArgs e)
        {
            if (comboboxRoles.SelectedItem != null && !listaRoles.Items.Contains(comboboxRoles.SelectedItem))
                listaRoles.Items.Add(comboboxRoles.SelectedItem);
        }

        private void btn_eliminarRolSeleccionado_Click(object sender, EventArgs e)
        {
            if (listaRoles.SelectedItem != null)
                listaRoles.Items.Remove(listaRoles.SelectedItem);
            else
                MessageBox.Show("Seleccione item a eliminar de la lista", "No hay item seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        username.Text = default(String);
        password.Text = default(String);
        listaRoles.Items.Clear();
    }

    private void btn_guardar_Click(object sender, EventArgs e)
    {
        try
        {
            Validaciones.inicializarValidador();
            Validaciones.esValido(username.Name, username.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido(password.Name, password.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido("roles asignados", listaRoles.Items.Count.ToString(), new Validaciones.NumeroNoCreo());
            if (!String.IsNullOrEmpty(Validaciones.camposInvalidos))
                throw new CamposInvalidosException();
            // fin regex
            usuario u = new usuario();
            u.username = username.Text;
            u.password = password.Text;
            if (BDManager.exists("usuario", "username", u.username))
            { throw new ControlDePKException(); }
            BDManager.insertEncryptedUser(u);
        }
        catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos del usuario a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        catch (ControlDePKException) { MessageBox.Show("El usuario "+username.Text+" ya existe en el sistema", "Error al validar campos del usuario a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }

    }