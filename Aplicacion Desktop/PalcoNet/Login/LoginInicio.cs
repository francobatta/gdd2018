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
using PalcoNet.Login;

    public partial class LoginInicio : Form
    {
        public LoginInicio()
        {
            InitializeComponent();
        }

        private void LoginInicio_Load(object sender, EventArgs e)
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

    private void btn_limpiar_Click(object sender, EventArgs e)
    {
        username.Text = default(String);
        passwordAnterior.Text = default(String);
    }

    private void btn_ingresar_Click(object sender, EventArgs e)
    {
        try
        {
            Validaciones.inicializarValidador();
            Validaciones.esValido(username.Name, username.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido("password", passwordAnterior.Text, new Validaciones.NumerosLetrasGuion());
            if (!String.IsNullOrEmpty(Validaciones.camposInvalidos))
                throw new CamposInvalidosException();
            // todos los controles contra usuario
            if (!BDManager.exists("usuario", "username", username.Text))
                throw new UsuarioNoExistenteException();
            if (!BDManager.existsButWith("usuario", "username", username.Text, "password=HASHBYTES('SHA2_256','" + passwordAnterior.Text + "')"))
            {   if (usuarioGlobal.numeroDeIntentos < 1) throw new UsuarioInhabilitadoException();
                throw new PasswordIncorrectaException();}
            usuario u = new usuario();
            BDManager.selectIntoObjectByString("usuario", "username", username.Text, u);
            if (u.habilitado == "False")
                throw new UsuarioInhabilitadoException();
            usuarioGlobal.usuarioLogueado = u;
            usuarioGlobal.numeroDeIntentos = 3;
            MessageBox.Show("Login exitoso del usuario " + u.username, "Login completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // ahora tengo que ver si el user tiene 1 rol o mas
            List<object> listaTraidaDeBD = BDManager.getList("SELECT * FROM EQUISDE.rol r JOIN EQUISDE.rol_x_usuario ru ON r.id_rol = ru.id_rol JOIN EQUISDE.usuario u ON ru.username = u.username WHERE r.habilitado=1 AND u.username ='" + u.username + "'", new rol());
            List<rol> listaRolesDeEseUsuario = listaTraidaDeBD.Cast<rol>().ToList();
            if (listaRolesDeEseUsuario.Count > 1)
            {
                SeleccionaRol seleccionaRol = new SeleccionaRol();
                usuarioGlobal.posiblesRoles = listaRolesDeEseUsuario;
                seleccionaRol.ShowDialog();
            }
            else
            {
                usuarioGlobal.rolLogueado = listaRolesDeEseUsuario[0];
            }
            this.Close();
        }
        catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos del usuario a loguear", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        catch (PasswordIncorrectaException) {
            usuarioGlobal.restarIntento(); ;MessageBox.Show("Contraseña incorrecta. Restan " + usuarioGlobal.numeroDeIntentos +" intentos", "Error en contraseña" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (UsuarioNoExistenteException) { MessageBox.Show("Usuario no existente en el sistema", "Error al validar campos del usuario a loguear", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        catch (UsuarioInhabilitadoException) { MessageBox.Show("El usuario" + username.Text +"se encuentra inhabilitado", "Usuario inhabilitado", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }
      
    }