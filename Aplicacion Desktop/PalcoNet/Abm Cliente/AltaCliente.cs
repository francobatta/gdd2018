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
using PalcoNet.Abm_Cliente;

    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

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
                 //c.username = Login.usuarioLogueado();
                 c.nombre = nombre.Text;
                 c.apellido = apellido.Text;
                 c.tipoDoc = tipoDoc.Text;
                 c.nDoc = nDoc.Text;
                 c.CUIL = CUIL.Text;
                 c.email = email.Text;
                 c.telefono = telefono.Text;
                 c.fechaNac = fechaNac.Text;
                 d.localidad = localidad.Text;
                 d.ciudad = ciudad.Text;
                 d.calle = calle.Text;
                 d.piso = piso.Text;
                 d.depto = depto.Text;
                 d.cpostal = cpostal.Text;
                 t.nroTarjeta = nroTarjeta.Text;
                 t.codSeguridad = codSeguridad.Text;
                 t.nombreTitularTarjeta = nombreTitularTarjeta.Text;
                 t.tipoTarjeta = tipoTarjeta.Text;
                 t.fechaVto = fechavtotarjeta.Text;
                // valido CUIL
                if (BDManager.exists("cliente", "CUIL", c.CUIL))
                    throw new ClienteInvalidoException();
                // validar tipodoc+ndoc contra la base usando BDManager
                if (BDManager.existsButWith("cliente","tipoDoc",tipoDoc.Text,"nDoc="+nDoc.Text))
                    throw new ClienteInvalidoException();
                // inserto dir
                BDManager.insertInto("direccion", d);
                String dirKey = default(string);
                BDManager.genericFillObject("SELECT id_direccion FROM direccion d JOIN cliente c ON d.id_direccion = c.id_direccion WHERE c.CUIL="+c.CUIL, dirKey);
                c.id_direccion = dirKey;
                // inserto tarjeta
                BDManager.insertInto("direccion", d);
                String tKey = default(string);
                BDManager.genericFillObject("SELECT id_tarjeta FROM tarjeta t JOIN cliente c ON t.id_tarjeta = c.tarjeta WHERE c.CUIL=" + c.CUIL, dirKey);
                c.id_tarjeta = tKey;
                // inserto cliente
                BDManager.insertInto("cliente", c);
                MessageBox.Show("El cliente ha sido insertado", "Cliente insertado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Validaciones.esValido(tipoTarjeta.Name, tipoTarjeta.Text, new Validaciones.Letras());
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
    }