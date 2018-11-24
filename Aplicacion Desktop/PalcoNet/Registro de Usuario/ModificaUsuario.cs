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

    public partial class ModificaUsuario : Form
    {
        public usuario usuarioAModificar { get; set; }
        public List<rol> listaRolesDeEseUsuario { get; set; }
        public ModificaUsuario(usuario u)
        {
            InitializeComponent();
            this.usuarioAModificar = u;
        }

        private void ModificaUsuario_Load(object sender, EventArgs e)
        {
            username.Text = usuarioAModificar.username;
            // todos los roles
            List<object> listaRolesBD = BDManager.getList("SELECT * FROM EQUISDE.rol", new rol());
            List<rol> listaRolesGeneral = listaRolesBD.Cast<rol>().ToList();
            listaRolesUsuario.DataSource = listaRolesGeneral;
            listaRolesUsuario.DisplayMember = "nombre";
            // roles de ESE usuario
            List<object> listaTraidaDeBD = BDManager.getList(
                "SELECT r.id_rol, r.nombre FROM EQUISDE.rol r JOIN EQUISDE.rol_x_usuario ru ON r.id_rol = ru.id_rol JOIN EQUISDE.usuario u ON ru.usuario = u.username WHERE u.username =" + usuarioAModificar.username
                , new rol());
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
    }