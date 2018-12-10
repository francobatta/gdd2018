using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.BDManager;

    public partial class ModificaEmpresa : Form
    {

        public empresa empresaAUsar { get; set; }
        public ModificaEmpresa(empresa o)
        {
            empresaAUsar = o;
            InitializeComponent();
        }

        private void ModificaEmpresa_Load(object sender, EventArgs e)
        {
            razon_social.Text = empresaAUsar.razon_social;
            email.Text = empresaAUsar.mail;
            CUIT.Text = empresaAUsar.cuit;
            direccion direccionAModificar = new direccion();
            BDManager.selectIntoObject("direccion", "id_direccion", empresaAUsar.id_direccion, direccionAModificar);
            localidad.Text = direccionAModificar.localidad;
            ciudad.Text = direccionAModificar.ciudad;
            calle.Text = direccionAModificar.calle;
            piso.Text = direccionAModificar.piso;
            nroCalle.Text = direccionAModificar.nro_calle;
            depto.Text = direccionAModificar.depto;
            cpostal.Text = direccionAModificar.cpostal;
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

    private void btn_guardar_Click(object sender, EventArgs e)
    {
        //
        try{

        validarCamposEmpresa();
        direccion d = new direccion();
        empresaAUsar.razon_social = razon_social.Text;
        empresaAUsar.mail = email.Text;
        d.localidad = localidad.Text;
        d.ciudad = ciudad.Text;
        d.calle = calle.Text;
        d.piso = piso.Text;
        d.depto = depto.Text;
        d.cpostal = cpostal.Text;
        d.nro_calle = nroCalle.Text;
        if (!empresaAUsar.cuit.Equals(CUIT.Text))
        {
            empresaAUsar.cuit = CUIT.Text;
            if (BDManager.exists("empresa", "cuit", empresaAUsar.cuit))
                throw new EmpresaInvalidadException();
        }
        BDManager.updateSetStringKey("direccion", "id_direccion", empresaAUsar.id_direccion, d);
        BDManager.updateSetStringKey("empresa", "username", empresaAUsar.username, empresaAUsar);
       MessageBox.Show("La empresa ha sido modificada", "Empresa modificada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
        }
        catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos de la empresa a modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
         catch (EmpresaInvalidadException) { MessageBox.Show("CUIT ya existente en sistema", "Error al validar campos de la empresa a modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }
    private void validarCamposEmpresa()
    {
        Validaciones.inicializarValidador();
        Validaciones.esValido(CUIT.Name, CUIT.Text, new Validaciones.CUIT());
        Validaciones.esValido(calle.Name, calle.Text, new Validaciones.NumerosLetrasGuion());
        Validaciones.esValido(piso.Name, piso.Text, new Validaciones.NumerosGuion());
        Validaciones.esValido(cpostal.Name, cpostal.Text, new Validaciones.Numeros());
        Validaciones.esValido(nroCalle.Name, nroCalle.Text, new Validaciones.Numeros());
        if (!String.IsNullOrEmpty(Validaciones.camposInvalidos))
            throw new CamposInvalidosException();
    }
    private void btn_limpiar_Click(object sender, EventArgs e)
    {
        razon_social.Text = default(String);
        CUIT.Text = default(String);
        email.Text = default(String);
        localidad.Text = default(String);
        ciudad.Text = default(String);
        calle.Text = default(String);
        piso.Text = default(String);
        depto.Text = default(String);
        cpostal.Text = default(String);
    }
    }