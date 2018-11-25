using PalcoNet;
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

    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            tipoDoc.Items.Add("DNI");
            tipoDoc.Items.Add("LE");
            tipoDoc.Items.Add("CI");
            tipoDoc.SelectedIndex = 0;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                validarCamposCliente();
                // armar objetito cliente
                cliente c = new cliente();
                direccion d = new direccion();
                tarjeta t = new tarjeta();
                 c.nombre = nombre.Text;
                 c.apellido = apellido.Text;
                 c.tipo_documento = tipoDoc.Text;
                 c.dni = nDoc.Text;
                 c.CUIL = CUIL.Text;
                 c.mail = email.Text;
                 c.telefono = telefono.Text;
                 c.fecha_nacimiento = fechaNac.Text;
                 d.localidad = localidad.Text;
                 d.ciudad = ciudad.Text;
                 d.calle = calle.Text;
                 d.piso = piso.Text;
                 d.depto = depto.Text;
                 d.cpostal = cpostal.Text;
                 d.nro_calle = nroCalle.Text;
                 t.username = CUIL.Text;
                 t.nro_tarjeta = nroTarjeta.Text;
                 t.cod_seguridad = codSeguridad.Text;
                 t.nombre_titular = nombreTitularTarjeta.Text;
                 t.fecha_vencimiento = fechavtotarjeta.Text;
                // valido CUIL
                if (BDManager.exists("cliente", "CUIL", c.CUIL))
                    throw new ClienteInvalidoException();
                // validar tipodoc+ndoc contra la base usando BDManager
                if (BDManager.existsButWith("cliente","tipo_documento",tipoDoc.Text,"dni="+nDoc.Text))
                    throw new ClienteInvalidoException();
                // inserto dir
                MessageBox.Show("SELECT id_direccion FROM EQUISDE.direccion d WHERE d.localidad=" + "'" + d.localidad + "'" + " AND " + "d.cpostal=" + "'" + d.cpostal + "'" + " AND " + "d.depto=" +
                    "'" + d.depto + "'" + " AND " + "d.ciudad=" + "'" + d.ciudad + "'" + " AND " + "d.piso=" + d.piso + " AND " + "d.calle=" + "'" + d.calle + "'");
                BDManager.genericFillObject("SELECT * FROM EQUISDE.direccion d WHERE d.localidad=" + "'" + d.localidad + "'" + " AND " + "d.cpostal=" + "'" + d.cpostal + "'" + " AND " + "d.depto=" +
                    "'" + d.depto + "'" + " AND " + "d.ciudad=" + "'" + d.ciudad + "'" + " AND " + "d.piso=" + d.piso + " AND " + "d.calle=" + "'" + d.calle + "'"
                    , d);
                c.id_direccion = d.id_direccion;
                // el usuario que tendra el cliente
                usuario u = new usuario();
                u.username = c.CUIL;
                u.password = c.CUIL;
                c.username = c.CUIL;
                // inserto tarjeta y clientebueno
                BDManager.insertEncryptedUser(u);
                BDManager.insertInto("direccion", d);
                BDManager.insertInto("cliente", c);
                BDManager.insertInto("tarjeta", t);
                MessageBox.Show("El cliente ha sido insertado. Al clickear OK, se le pedirá que efectúe un cambio de contraseña predeterminada para su usuario nuevo.", "Cliente insertado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegistraUsuario registraUsuario = new RegistraUsuario(u);
                registraUsuario.ShowDialog();
                this.Close();
            }
            catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos del cliente a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (ClienteInvalidoException) { MessageBox.Show("CUIL ya existente en sistema", "Error al validar campos del cliente a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void validarCamposCliente()
        {
            Validaciones.inicializarValidador();
            Validaciones.esValido(nombre.Name, nombre.Text, new Validaciones.Letras());
            Validaciones.esValido(apellido.Name, apellido.Text, new Validaciones.Letras());
            Validaciones.esValido(tipoDoc.Name, tipoDoc.Text, new Validaciones.Letras());
            Validaciones.esValido(nDoc.Name, nDoc.Text, new Validaciones.Numeros());
            Validaciones.esValido(CUIL.Name, CUIL.Text, new Validaciones.CUIT());
            Validaciones.esValido(email.Name, email.Text, new Validaciones.Email());
            Validaciones.esValido(telefono.Name, telefono.Text, new Validaciones.NumerosGuion());
            Validaciones.esValido(localidad.Name, localidad.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido(ciudad.Name, ciudad.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido(calle.Name, calle.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido(piso.Name, piso.Text, new Validaciones.NumerosGuion());
            Validaciones.esValido(depto.Name, depto.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido(cpostal.Name, cpostal.Text, new Validaciones.Numeros());
            Validaciones.esValido(nroTarjeta.Name, nroTarjeta.Text, new Validaciones.Numeros());
            Validaciones.esValido(codSeguridad.Name, codSeguridad.Text, new Validaciones.Numeros());
            Validaciones.esValido(nombreTitularTarjeta.Name, nombreTitularTarjeta.Text, new Validaciones.Letras());
            if (!String.IsNullOrEmpty(Validaciones.camposInvalidos))
                throw new CamposInvalidosException();
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
        nombre.Text = default(String);
        apellido.Text = default(String);
        tipoDoc.Text = default(String);
        nDoc.Text = default(String);
        CUIL.Text = default(String);
        email.Text = default(String);
        telefono.Text = default(String);
        fechaNac.Text = default(String);
        localidad.Text = default(String);
        ciudad.Text = default(String);
        calle.Text = default(String);
        piso.Text = default(String);
        depto.Text = default(String);
        cpostal.Text = default(String);
        nroTarjeta.Text = default(String);
        codSeguridad.Text = default(String);
        nombreTitularTarjeta.Text = default(String);
        fechavtotarjeta.Text = default(String);
    }
    }
