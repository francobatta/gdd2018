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

    public partial class nuevaCompra : Form
    {
        public publicacion pub { get; set; }
        public ubicacion ubi { get; set; }
        public nuevaCompra()
        {
            InitializeComponent();
        }
        private void nuevaCompra_Load(object sender, EventArgs e)
        {
            //Falta validar rango fechas
            ListaEsp.DataSource = BDManager.getData(
              "SELECT p.* FROM EQUISDE.publicacion p JOIN EQUISDE.estado e ON p.id_estado=e.id_estado WHERE e.estado LIKE 'Alta'"
              );
            //
            List<object> listaTraidaDeBD = BDManager.getList("SELECT codigo_tipo, descripcion FROM EQUISDE.tipo", new tipo());
            List<tipo> listaTipos = listaTraidaDeBD.Cast<tipo>().ToList();
            tipoUbi.DataSource = listaTipos;
            tipoUbi.DisplayMember = "descripcion";
            tipoUbi.ValueMember = "codigo_tipo";


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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {  
                DataGridViewRow filaElegida = ListaEsp.CurrentRow;
                if (filaElegida == null || filaElegida.Selected == false)
                    throw new CamposInvalidosException();
                BDManager.selectIntoObject("publicacion","id_publicacion",filaElegida.Cells["id_publicacion"].Value.ToString(),pub);
                ListaUbi.DataSource = BDManager.getData(
              "SELECT * FROM EQUISDE.ubicacion u WHERE u.id_publicacion ="+pub.id_publicacion
              );
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar espectaculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListaEsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow filaElegida = ListaUbi.CurrentRow;
                if (filaElegida == null || filaElegida.Selected == false)
                    throw new CamposInvalidosException();
                BDManager.selectIntoObject("Ubicacion", "id_ubicacion",filaElegida.Cells["id_ubicacion"].Value.ToString(), ubi);
                //revisar
                Carrito.Items.Add(ubi.id_ubicacion.ToString());
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar ubicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agregarTipo_Click(object sender, EventArgs e)
        {
              try
        {
        if (tipoUbi.SelectedItem == null)
            throw new CamposInvalidosException();
        ListaCat.Items.Add(tipoUbi.SelectedValue as string);
        }
        catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos de categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }

        private void eliminarTipo_Click(object sender, EventArgs e)
        {
         if (ListaCat.SelectedItem != null)
            ListaCat.Items.Remove(ListaCat.SelectedItem);
        else
            MessageBox.Show("Debe elegir una categoria", "Fila no elegida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void filtrar_Click(object sender, EventArgs e)
        {
            //falta validacion
            String ids="(";
                foreach (var t in ListaCat.Items)
                {
                    ids+=t.ToString();
                    ids+=",";
                    }
            ids = ids.Remove(ids.Length - 1); 
            ids=")";
            ListaEsp.DataSource = null;
            ListaEsp.DataSource = BDManager.getData(
              "SELECT Distinct p.* FROM EQUISDE.publicacion p JOIN EQUISDE.estado e ON p.id_estado=e.id_estado JOIN EQUISDE.ubicacion u ON u.id_publicacion=p.id_publicacion"+
            "WHERE e.estado LIKE 'Alta' AND p.descripcion LIKE '%" + Descripcion.Text + "%' AND u.codigo_tipo IN " + ids
              );
        }

        private void eliminarCarrito_Click(object sender, EventArgs e)
        {
            if (Carrito.SelectedItem != null)
                Carrito.Items.Remove(Carrito.SelectedItem);
            else
                MessageBox.Show("Debe elegir una ubicacion", "Fila no elegida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Compra_Click(object sender, EventArgs e)
        {
            try{
            compra_x_ubicacion cu = new compra_x_ubicacion();
            compra com = new compra();
            com.username = usuarioGlobal.usuarioLogueado.username;
            com.email = Email.Text;
            //Falta atributo fecha
            com.fecha_compra = null;
            com.cantidad = Carrito.Items.Count.ToString();
            //los puntos es la cantidad de ubicaciones que compro por 3
            com.puntos = (Carrito.Items.Count * 3).ToString();
            float aux=0;
            foreach (var t in Carrito.Items)
            {
                ubicacion u = new ubicacion();
                BDManager.selectIntoObjectByString("ubicacion","id_ubicacion",t.ToString(), u);
                aux += (float)Convert.ToDouble(u.precio);
            }  
            if(aux<0)
                throw new CompraInvalidaException();
            if (!BDManager.exists("tarjeta", "username", usuarioGlobal.usuarioLogueado.username)) {
                nuevaTarjeta m = new nuevaTarjeta();
                m.ShowDialog();
            }
            com.forma_de_pago = "tarjeta";
            BDManager.insertInto("compra", com);
            cu.id_compra = com.id_compra;

            foreach (var t in Carrito.Items)
            {
                cu.id_ubicacion = t.ToString();
                BDManager.insertInto("compra_x_ubicacion", cu);
            }
            }
             catch (CompraInvalidaException) { MessageBox.Show("Importe negativo", "Error al validar campos de la compra al insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        }