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

    public partial class RegistraUsuario : Form
    {
        public usuario user { get; set; }
        public RegistraUsuario(usuario u)
        {
            InitializeComponent();
            this.user = u;
            username.Text = user.username;
            username.Enabled = false;
        }

        private void RegistraUsuario_Load(object sender, EventArgs e)
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
        passwordAnterior.Text = default(String);
        passwordNueva.Text = default(String);
        passwordNuevaConfirmacion.Text = default(String);
    }

    private void btn_guardar_Click(object sender, EventArgs e)
    {
        try
        {
            Validaciones.inicializarValidador();
            Validaciones.esValido(username.Name, username.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido(passwordAnterior.Name, passwordAnterior.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido(passwordNueva.Name, passwordNueva.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido(passwordNuevaConfirmacion.Name, passwordNuevaConfirmacion.Text, new Validaciones.NumerosLetrasGuion());
            if (!String.IsNullOrEmpty(Validaciones.camposInvalidos))
                throw new CamposInvalidosException();
            if (passwordNueva.Text != passwordNuevaConfirmacion.Text)
                throw new ControlDePKException();
            if (!BDManager.existsButWith("usuario", "username", user.username, "password=HASHBYTES('SHA2_256','" + passwordAnterior.Text + "')"))
                throw new PasswordIncorrectaException();
            user.password = passwordNueva.Text;
            BDManager.updateEncryptedUser(user);
            MessageBox.Show("El usuario ha sido modificado", "Usuario modificado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos del usuario a registrar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        catch (ControlDePKException) { MessageBox.Show("Contraseña nueva mal escrita", "Error al validar campos del usuario a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        catch (PasswordIncorrectaException) { MessageBox.Show("Contraseña anterior incorrecta", "Error al validar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

    }
    }
