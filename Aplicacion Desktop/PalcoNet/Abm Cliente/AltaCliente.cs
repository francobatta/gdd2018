using PalcoNet;
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

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                validarCamposCliente();
                // armar objetito cliente
                // validar PK no repetida contra la base usando BDManager
            }
            catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos del cliente a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void validarCamposCliente()
        {
            Validaciones.inicializarValidador();
            Validaciones.esValido(nombre.Name, nombre.Text, new Validaciones.Letras());
            Validaciones.esValido(apellido.Name, apellido.Text, new Validaciones.Letras());
            Validaciones.esValido(tipoDoc.Name, tipoDoc.Text, new Validaciones.Letras());
            Validaciones.esValido(nDoc.Name, nDoc.Text, new Validaciones.Numeros());
            Validaciones.esValido(CUIL.Name, CUIL.Text, new Validaciones.Numeros());
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