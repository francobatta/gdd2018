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

    public partial class AltaEmpresa : Form
    {
        public AltaEmpresa()
        {
            InitializeComponent();
        }

        private void AltaEmpresa_Load(object sender, EventArgs e)
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

    private void btn_guardar_Click(object sender, EventArgs e)
    {
        try
        {
            validarCamposEmpresa();
            //
            empresa emp = new empresa();
            direccion d = new direccion();
            emp.razon_social = nombre.Text;
            emp.mail = email.Text;
            emp.telefono = telefono.Text;
            emp.cuit = CUIL.Text;
            d.nro_calle = nroCalle.Text;
            d.localidad = localidad.Text;
            d.ciudad = ciudad.Text;
            d.calle = calle.Text;
            d.piso = piso.Text;
            d.depto = depto.Text;
            d.cpostal = cpostal.Text;
            if (BDManager.exists("empresa", "cuit", emp.cuit))
                throw new EmpresaInvalidadException();
            //
            BDManager.insertInto("direccion", d);
            String dirKey = default(string);
            BDManager.genericFillObject("SELECT id_direccion FROM EQUISDE.direccion d WHERE d.localidad=" + "'" + d.localidad + "'" + " AND " + "d.cpostal=" + "'" + d.cpostal + "'"+" AND "+"d.depto="+
                "'" + d.depto + "'" + " AND " + "d.ciudad=" + "'" + d.ciudad + "'" + " AND " +"d.piso=" + d.piso +" AND "+ "d.calle="  + "'" + d.calle + "'"
                , dirKey);
            emp.id_direccion = dirKey;
            //
            usuario u = new usuario();
            u.username = emp.cuit;
            u.password = emp.cuit;
            emp.username = emp.cuit;
            BDManager.insertEncryptedUser(u);
            BDManager.insertInto("empresa", emp);
            MessageBox.Show("La empresa ha sido insertado", "Empresa insertada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
        catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos de la empresa a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        catch (EmpresaInvalidadException) { MessageBox.Show("CUIT ya existente en sistema", "Error al validar campos de la empresa a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }

    private void validarCamposEmpresa()
    {
        Validaciones.inicializarValidador();
        Validaciones.esValido(nombre.Name, nombre.Text, new Validaciones.Letras());
        Validaciones.esValido(CUIL.Name, CUIL.Text, new Validaciones.CUIT());
        Validaciones.esValido(email.Name, email.Text, new Validaciones.Email());
        Validaciones.esValido(telefono.Name, telefono.Text, new Validaciones.NumerosGuion());
        Validaciones.esValido(localidad.Name, localidad.Text, new Validaciones.NumerosLetrasGuion());
        Validaciones.esValido(ciudad.Name, ciudad.Text, new Validaciones.NumerosLetrasGuion());
        Validaciones.esValido(calle.Name, calle.Text, new Validaciones.NumerosLetrasGuion());
        Validaciones.esValido(piso.Name, piso.Text, new Validaciones.NumerosGuion());
        Validaciones.esValido(depto.Name, depto.Text, new Validaciones.NumerosLetrasGuion());
        Validaciones.esValido(cpostal.Name, cpostal.Text, new Validaciones.Numeros());
        Validaciones.esValido(nroCalle.Name, nroCalle.Text, new Validaciones.Numeros());
        if (!String.IsNullOrEmpty(Validaciones.camposInvalidos))
            throw new CamposInvalidosException();
    }

    private void btn_limpiar_Click(object sender, EventArgs e)
    {
        nombre.Text = default(String);
        CUIL.Text = default(String);
        email.Text = default(String);
        telefono.Text = default(String);
        localidad.Text = default(String);
        ciudad.Text = default(String);
        calle.Text = default(String);
        piso.Text = default(String);
        depto.Text = default(String);
        cpostal.Text = default(String);
    }

    private void nroCalle_TextChanged(object sender, EventArgs e)
    {

    }
    }