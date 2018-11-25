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

        public usuario us { get; set; }
        public ModificaEmpresa(usuario o)
        {
            us = o;
            InitializeComponent();
        }

        private void ModificaEmpresa_Load(object sender, EventArgs e)
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
        //
        try{
        empresa emp = new empresa();
        direccion d = new direccion();
        emp.razon_social = nombre.Text;
        emp.mail = email.Text;
        emp.telefono = telefono.Text;
        emp.cuit = CUIL.Text;
        d.localidad = localidad.Text;
        d.ciudad = ciudad.Text;
        d.calle = calle.Text;
        d.piso = piso.Text;
        d.depto = depto.Text;
        d.cpostal = cpostal.Text;
        if (BDManager.exists("empresa", "cuit", emp.cuit))
            throw new EmpresaInvalidadException();
        String dirKey = default(string);
        BDManager.genericFillObject("SELECT id_direccion FROM EQUISDE.empresa d WHERE d.username=" + "'" + us.username + "'", dirKey);
        BDManager.updateSetStringKey("direccion", "id_direccion", dirKey, d);
        BDManager.updateSetStringKey("empresa","username",us.username,emp);
        MessageBox.Show("El usuario ha sido modificado", "Usuario modificado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
        }
         catch (EmpresaInvalidadException) { MessageBox.Show("CUIT ya existente en sistema", "Error al validar campos de la empresa a modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
    }