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

    public partial class AltaPublicacion : Form
    {
        public AltaPublicacion()
        {
            InitializeComponent();
        }

        private void AltaPublicacion_Load(object sender, EventArgs e)
        {
            List<object> listaTraidaDeBD = BDManager.getList("SELECT codigo_tipo, descripcion FROM EQUISDE.tipo", new tipo());
            List<tipo> listaTipos = listaTraidaDeBD.Cast<tipo>().ToList();
            tipoUbicacion.DataSource = listaTipos;
            tipoUbicacion.DisplayMember = "descripcion";
            tipoUbicacion.ValueMember = "codigo_tipo";
            grado.Items.Add("Alta");
            grado.Items.Add("Media");
            grado.Items.Add("Baja");
            grado.SelectedIndex = 0;
            estado.Items.Add('B');
            estado.Items.Add('P');
            estado.Items.Add('F');
            estado.SelectedIndex = 0;
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

    }

    private void btn_limpiar_Click(object sender, EventArgs e)
    {
        descripcion.Text = default(String);
        filaUbicacion.Text = default(String);
        asientoUbicacion.Text = default(String);
        precioUbicacion.Text = default(String);
        tipoUbicacion.Text = default(String);
        listaUbicaciones.Items.Clear();
        rubro.Text = default(String);
        calle.Text = default(String);
        piso.Text = default(String);
        depto.Text = default(String);
        cpostal.Text = default(String);
        grado.SelectedIndex = -1;
        estado.SelectedIndex = -1;
        listaFechasEspectaculo.Items.Clear();
    }

    private void btn_agregarUbicacion_Click(object sender, EventArgs e)
    {
        try
        {
        Validaciones.inicializarValidador();
        Validaciones.esValido("Asiento", asientoUbicacion.Text, new Validaciones.Numeros());
        Validaciones.esValido("Fila", filaUbicacion.Text, new Validaciones.NumerosLetrasGuion());
        Validaciones.esValido("Precio", precioUbicacion.Text, new Validaciones.Numeros());
        if (!String.IsNullOrEmpty(Validaciones.camposInvalidos) || tipoUbicacion.SelectedItem == null)
            throw new CamposInvalidosException();
        ubicacion u = new ubicacion();
        u.asiento = asientoUbicacion.Text;
        u.fila = filaUbicacion.Text;
        u.precio = precioUbicacion.Text;
        u.codigo_tipo = tipoUbicacion.SelectedValue.ToString();
        listaUbicaciones.Items.Add(u);
        }
        catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }

    private void btn_eliminarUbicacionSeleccionada_Click(object sender, EventArgs e)
    {
        if (listaUbicaciones.SelectedItem != null)
            listaUbicaciones.Items.Remove(listaUbicaciones.SelectedItem);
        else
            MessageBox.Show("Debe elegir una ubicación", "Fila no elegida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    }