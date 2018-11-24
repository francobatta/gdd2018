using PalcoNet.BDManager;
using PalcoNet.Registro_de_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    public partial class ModificaUsuario : Form
    {
        public usuario usuarioAModificar { get; set; }
        public List<rol> listaRolesDeEseUsuario = new List<rol>();
        public ModificaUsuario(usuario u)
        {
            InitializeComponent();
            this.usuarioAModificar = u;

        }

        private void ModificaUsuario_Load(object sender, EventArgs e)
        {
            // estados
            if (usuarioAModificar.habilitado == "False")
                btn_habilitar_rol.Enabled = true;
            else
                btn_habilitar_rol.Enabled = false;
            username.Text = usuarioAModificar.username;
            // todos los roles
            List<object> listaRolesBD = BDManager.getList("SELECT * FROM EQUISDE.rol", new rol());
            List<rol> listaRolesGeneral = listaRolesBD.Cast<rol>().ToList();
            listaRolesUsuario.DataSource = listaRolesGeneral;
            listaRolesUsuario.DisplayMember = "nombre";
            // roles de ESE usuario
            List<object> listaTraidaDeBD = BDManager.getList("SELECT * FROM EQUISDE.rol r JOIN EQUISDE.rol_x_usuario ru ON r.id_rol = ru.id_rol JOIN EQUISDE.usuario u ON ru.username = u.username WHERE r.habilitado=1 AND u.username ='" + usuarioAModificar.username + "'", new rol());
            listaRolesDeEseUsuario = listaTraidaDeBD.Cast<rol>().ToList();
            listaRoles.DataSource = listaRolesDeEseUsuario;
            listaRoles.DisplayMember = "nombre";
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
        password.Text = default(String);
        listaRoles.DataSource = null;
    }

    private void btn_agregarRol_Click(object sender, EventArgs e)
    {
        rol r = listaRolesUsuario.SelectedValue as rol;
        if (listaRolesUsuario.SelectedItem != null && !listaRolesDeEseUsuario.Any(n => n.id_rol.Equals(r.id_rol)))
        {
            listaRolesDeEseUsuario.Add(listaRolesUsuario.SelectedItem as rol);
            listaRoles.DataSource = null;
            listaRoles.DataSource = listaRolesDeEseUsuario;
            listaRoles.DisplayMember = "nombre";
        }
    }

    private void btn_eliminarRolSeleccionado_Click(object sender, EventArgs e)
    {
        if (listaRoles.SelectedItem == null)
            MessageBox.Show("Debe seleccionar un rol a eliminar", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        else{
        listaRolesDeEseUsuario.Remove(listaRoles.SelectedItem as rol);
        listaRoles.DataSource = null;
        listaRoles.DataSource = listaRolesDeEseUsuario;
        listaRoles.DisplayMember = "nombre";}
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
            // fin validaciones regex
            usuarioAModificar.username = username.Text;
            usuarioAModificar.password = password.Text;
            BDManager.updateEncryptedUser(usuarioAModificar);
            BDManager.deleteByField("rol_x_usuario", "username", "'" + usuarioAModificar.username + "'");
            foreach (rol r in listaRoles.Items)
            {
                BDManager.insertInto("rol_x_usuario", new rol_x_usuario { id_rol = r.id_rol, username = usuarioAModificar.username, });
            }
            MessageBox.Show("El usuario ha sido modificado", "Usuario modificado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos del usuario a modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

    
    }
    private void btn_habilitar_rol_Click(object sender, EventArgs e)
    {
        usuarioAModificar.habilitado = "True";
        btn_habilitar_rol.Enabled = false;
    }
    }