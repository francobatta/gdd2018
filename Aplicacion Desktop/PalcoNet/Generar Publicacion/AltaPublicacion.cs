using PalcoNet.BDManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public List<ubicacion> ubicaciones = new List<ubicacion>();
        private void AltaPublicacion_Load(object sender, EventArgs e)
        {
            grado.Items.Add("Alta");
            grado.Items.Add("Media");
            grado.Items.Add("Baja");
            grado.SelectedIndex = 0;
            estado.Items.Add('B');
            estado.Items.Add('P');
            estado.Items.Add('F');
            estado.SelectedIndex = 0;
            fechaPublicacion.Text = ConfigurationManager.AppSettings["today"].ToString();
            rubro.DataSource = BDManager.getData("SELECT * FROM EQUISDE.rubro");
            tipoUbicacion.DataSource = BDManager.getData("SELECT * FROM EQUISDE.tipo");
            rubro.DisplayMember = "descripcion";
            rubro.ValueMember = "id_rubro";
            rubro.SelectedIndex = 0;
            tipoUbicacion.DisplayMember = "descripcion";
            tipoUbicacion.ValueMember = "codigo_tipo";
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
            Validaciones.inicializarValidador();
            Validaciones.esValido(descripcion.Name, descripcion.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido("ubicaciones", ubicaciones.Count.ToString(), new Validaciones.NumeroNoCreo());
            Validaciones.esValido("calle", calle.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido("núm. calle", nroCalle.Text, new Validaciones.Numeros());
            Validaciones.esValido("piso", piso.Text, new Validaciones.Numeros());
            Validaciones.esValido(depto.Name, depto.Text, new Validaciones.NumerosLetrasGuion());
            Validaciones.esValido("cód. postal", cpostal.Text, new Validaciones.Numeros());
            Validaciones.esValido("fechas de espectáculo", listaFechasEspectaculo.Items.Count.ToString(), new Validaciones.NumeroNoCreo());
            if (!String.IsNullOrEmpty(Validaciones.camposInvalidos))
                throw new CamposInvalidosException();
            // comienzo armado del objeto general
                // rubro
            publicacion nuevaPublicacion = new publicacion();
            nuevaPublicacion.id_rubro = rubro.SelectedValue.ToString();
                // direccion
            direccion d = new direccion();
            d.localidad = localidad.Text;
            d.ciudad = ciudad.Text;
            d.calle = calle.Text;
            d.nro_calle = nroCalle.Text;
            d.piso = piso.Text;
            d.depto = depto.Text;
            d.cpostal = cpostal.Text;
            BDManager.insertInto("direccion", d);
            BDManager.genericFillObject("SELECT * FROM EQUISDE.direccion d WHERE d.localidad=" + "'" + d.localidad + "'" + " AND " + "d.cpostal=" + "'" + d.cpostal + "'" + " AND " + "d.depto=" +
    "'" + d.depto + "'" + " AND " + "d.ciudad=" + "'" + d.ciudad + "'" + " AND " + "d.piso=" + d.piso + " AND " + "d.calle=" + "'" + d.calle + "'"
    , d);
            nuevaPublicacion.id_direccion = d.id_direccion;
                // estado
            estadop est = new estadop();
            BDManager.selectIntoObjectByString("estadop", "estado", estado.SelectedItem.ToString(), est);
            nuevaPublicacion.id_estado = est.id_estadop;
                // grado
            grado grad = new grado();
            BDManager.selectIntoObjectByString("grado", "estado", grado.SelectedItem.ToString(), grad);
            nuevaPublicacion.id_grado = grad.id_grado;
            nuevaPublicacion.username = usuarioGlobal.usuarioLogueado.username;
            nuevaPublicacion.descripcion = descripcion.Text;
            nuevaPublicacion.fecha_publicacion = fechaPublicacion.Value.ToString();
            // para todas las fechas de espectaculo
            foreach (DateTime f in listaFechasEspectaculo.Items)
            {
                nuevaPublicacion.fecha_vencimiento = f.ToString();
                BDManager.insertInto("publicacion", nuevaPublicacion);
                foreach (ubicacion u in ubicaciones)
                {
                    publicacion pDummy = new publicacion();
                    //MessageBox.Show("SELECT * FROM EQUISDE.publicacion WHERE username='" + usuarioGlobal.usuarioLogueado.username + "' AND descripcion='" + nuevaPublicacion.descripcion + "' AND fecha_vencimiento='" + f.ToString("s") +"'");
                    BDManager.genericFillObject(
 "SELECT * FROM EQUISDE.publicacion WHERE username='" + usuarioGlobal.usuarioLogueado.username + "' AND descripcion='" + nuevaPublicacion.descripcion + "' AND fecha_vencimiento='" + f.ToString("s") + "'", pDummy);
                    
                    u.id_publicacion = pDummy.id_publicacion;
                    BDManager.insertInto("ubicacion", u);
                }
            }
            // ahora que todo fue bien inserto las ubicaciones
            MessageBox.Show("La publicación se insertó correctamente", "Publicación insertada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos de la publicación a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }

    private void btn_limpiar_Click(object sender, EventArgs e)
    {
        descripcion.Text = default(String);
        //ubicacion
        filaUbicacion.Text = default(String);
        asientoUbicacion.Text = default(String);
        precioUbicacion.Text = default(String);
        tipoUbicacion.Text = default(String);
        listaUbicaciones.DataSource = null;
        //rubro
        rubro.Text = default(String);
        //direccion
        calle.Text = default(String);
        piso.Text = default(String);
        depto.Text = default(String);
        cpostal.Text = default(String);
        //listaFechas
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
        Validaciones.esValido("Tipo", tipoUbicacion.Text, new Validaciones.Letras());
        if (!String.IsNullOrEmpty(Validaciones.camposInvalidos) || tipoUbicacion.SelectedItem == null)
            throw new CamposInvalidosException();
        ubicacion u = new ubicacion();
        u.asiento = asientoUbicacion.Text;
        u.fila = filaUbicacion.Text;
        u.precio = precioUbicacion.Text;
        u.codigo_tipo = tipoUbicacion.SelectedValue.ToString();
        ubicaciones.Add(u);
        listaUbicaciones.DataSource = null;
        listaUbicaciones.DataSource = ubicaciones;
        listaUbicaciones.Columns["id_ubicacion"].Visible = false;
        listaUbicaciones.Columns["id_publicacion"].Visible = false;
        listaUbicaciones.Columns["sin_numerar"].Visible = false;
        }
        catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }

    private void btn_eliminarUbicacionSeleccionada_Click(object sender, EventArgs e)
    {
        if (listaUbicaciones.CurrentRow != null && listaUbicaciones.SelectedRows[0].Index > -1)
        {
            ubicaciones.RemoveAt(listaUbicaciones.CurrentCell.RowIndex);
            listaUbicaciones.DataSource = ubicaciones;
            listaUbicaciones.DataSource = null;
            listaUbicaciones.DataSource = ubicaciones;
            listaUbicaciones.Columns["id_ubicacion"].Visible = false;
            listaUbicaciones.Columns["id_publicacion"].Visible = false;
            listaUbicaciones.Columns["sin_numerar"].Visible = false;
        }
        else
            MessageBox.Show("Debe elegir una ubicación", "Fila no elegida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void btn_agregarFechaEspectaculo_Click(object sender, EventArgs e)
    {
        if (listaFechasEspectaculo.Items.Count == 0 || fechaEspectaculo.Value > (DateTime)listaFechasEspectaculo.Items[listaFechasEspectaculo.Items.Count - 1])
        listaFechasEspectaculo.Items.Add(fechaEspectaculo.Value);
        else
            MessageBox.Show("Error al insertar fecha. Comprobar que sea mayor a la última ingresada", "Fecha mal elegida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void btn_eliminarFechaSeleccionada_Click(object sender, EventArgs e)
    {
        if (listaFechasEspectaculo.SelectedItem != null)
        { listaFechasEspectaculo.Items.Remove(listaFechasEspectaculo.SelectedItem); }
        else
        { MessageBox.Show("Debe elegir una fecha a eliminar", "Fecha no elegida", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }

    }