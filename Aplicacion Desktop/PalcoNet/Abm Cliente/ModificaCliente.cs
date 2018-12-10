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

public partial class ModificaCliente : Form
{
    public ModificaCliente()
    {
        InitializeComponent();
    }
    public cliente c { get; set; }
    public direccion d { get; set; }
    public tarjeta t { get; set; }
    public ModificaCliente(cliente _c, direccion _d, tarjeta _t)
    {
        InitializeComponent();
        this.c = _c;
        this.t = _t;
        this.d = _d;
        this.Load += new System.EventHandler(this.ModificaCliente_Load);

    }
    public void ModificaCliente_Load(object sender, EventArgs e)
    {
        nombre.Text = c.nombre;
        apellido.Text = c.apellido;
        tipoDoc.Text = c.tipo_documento;
        nDoc.Text = c.dni;
        CUIL.Text = c.CUIL;
        this.userV = c.username;
        email.Text = c.mail;
        telefono.Text = c.telefono;
        fechaNac.Text = c.fecha_nacimiento;
        localidad.Text = d.localidad;
        ciudad.Text = d.ciudad;
        calle.Text = d.calle;
        piso.Text = d.piso;
        nroCalle.Text = d.nro_calle;
        depto.Text = d.depto;
        cpostal.Text = d.cpostal;
        nombreTitularTarjeta.Text = t.nombre_titular;
        ntarjeta.Text = t.nro_tarjeta;
        codSeguridad.Text = t.cod_seguridad;
        fechavtotarjeta.Text = t.fecha_vencimiento;
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
        codSeguridad.Text = default(String);
        nombreTitularTarjeta.Text = default(String);
        fechavtotarjeta.Text = default(String);
    }

    private void btn_guardar_Click(object sender, EventArgs e)
    {
        try
        {
            Validaciones.inicializarValidador();
            Validaciones.esValido(nDoc.Name, nDoc.Text, new Validaciones.Numeros());
            Validaciones.esValido(CUIL.Name, CUIL.Text, new Validaciones.CUIT());
            Validaciones.esValido(email.Name, email.Text, new Validaciones.Email());
            Validaciones.esValido(ntarjeta.Name, ntarjeta.Text, new Validaciones.Numeros());
            Validaciones.esValido(codSeguridad.Name, codSeguridad.Text, new Validaciones.Numeros());
            Validaciones.esValido(nombreTitularTarjeta.Name, nombreTitularTarjeta.Text, new Validaciones.Letras());
            if (!String.IsNullOrEmpty(Validaciones.camposInvalidos))
                throw new CamposInvalidosException();
            // armar objetito cliente
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
            t.nro_tarjeta = ntarjeta.Text;
            t.cod_seguridad = codSeguridad.Text;
            t.nombre_titular = nombreTitularTarjeta.Text;
            t.fecha_vencimiento = fechavtotarjeta.Text;
            // valido CUIL
            if (BDManager.existsButWith("cliente", "CUIL", c.dni, "username!=" + this.userV))
                throw new ClienteInvalidoException();
            // validar tipodoc+ndoc contra la base usando BDManager
            if (BDManager.existsButWith("cliente", "tipo_documento", tipoDoc.Text, " dni= " + nDoc.Text + " AND username!=" + this.userV))
                throw new ClienteInvalidoException();
            BDManager.updateSetStringKey("direccion", "id_direccion", d.id_direccion, d);
            BDManager.updateSetStringKey("cliente", "username", c.username, c);
            BDManager.updateSetStringKey("tarjeta", "username", c.username, t);
            MessageBox.Show("El cliente ha sido insertado.", "Cliente insertado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos del cliente a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        catch (ClienteInvalidoException) { MessageBox.Show("CUIL o documento ya existente en sistema bajo otro usuario", "Error al validar campos del cliente a modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

    }

    public string userV { get; set; }
}