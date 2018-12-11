using PalcoNet.BDManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    public partial class NuevaCompra : Form
    {
        public publicacion pElegida { get; set; }
        public String queryLimpio;
        public NuevaCompra()
        {
            InitializeComponent();
        }
        private void NuevaCompra_Load(object sender, EventArgs e)
        {
            rubro.DataSource = BDManager.getData("SELECT * FROM EQUISDE.rubro");
            rubro.DisplayMember = "descripcion";
            rubro.ValueMember = "id_rubro";
            fechaInicio.Text = ConfigurationManager.AppSettings["today"].ToString();
            fechaFin.Text = ConfigurationManager.AppSettings["today"].ToString();
            left.Enabled = false;
            leftleft.Enabled = false;
            right.Enabled = false;
            righttight.Enabled = false;

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

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow filaElegida = listadoPublicaciones.CurrentRow;
                if (filaElegida == null || filaElegida.Selected == false)
                    throw new CamposInvalidosException();
                pElegida = new publicacion();
                pElegida.id_publicacion = filaElegida.Cells["id_publicacion"].Value.ToString();
                pElegida.descripcion = filaElegida.Cells["descripcion"].Value.ToString();
                pElegida.fecha_publicacion = filaElegida.Cells["fecha_publicacion"].Value.ToString();
                pElegida.fecha_vencimiento = filaElegida.Cells["fecha_vencimiento"].Value.ToString();
                pElegida.id_direccion = filaElegida.Cells["id_direccion"].Value.ToString();
                pElegida.id_estado = filaElegida.Cells["id_estado"].Value.ToString();
                pElegida.id_grado = filaElegida.Cells["id_grado"].Value.ToString();
                pElegida.id_rubro = filaElegida.Cells["id_rubro"].Value.ToString();
                pElegida.username = filaElegida.Cells["username"].Value.ToString();
                idPublicacionElegida.Text = pElegida.id_publicacion;
            }
            catch (CamposInvalidosException) { MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar publicación", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            llenarGrillaPublicaciones(0);
            left.Enabled = true;
            leftleft.Enabled = true;
            right.Enabled = true;
            righttight.Enabled = true;
        }

        private void llenarGrillaPublicaciones(int numeroDePagina)
        {
            queryLimpio = default(string);
            listadoPublicaciones.DataSource = null;
            String query = default(string);
            query = "SELECT DISTINCT * FROM EQUISDE.publicacion WHERE id_estado=1 AND fecha_vencimiento BETWEEN '" + fechaInicio.Value.ToShortDateString() + "' AND '" + fechaFin.Value.ToShortDateString() + "' AND descripcion LIKE '%" + descripcion.Text + "%'";
            bool esElPrimerRubro = true;
            foreach (rubro r in listadoRubros.Items)
            {
                if (esElPrimerRubro)
                { query += " AND (id_rubro=" + r.id_rubro; esElPrimerRubro = false; }
                else
                    query += " OR id_rubro=" + r.id_rubro;
            }
            if (listadoRubros.Items.Count > 0)
                query += ")";
            query += " ORDER BY id_grado,1";
            queryLimpio = String.Copy(query);
            query += " OFFSET "+numeroDePagina*10+" ROWS FETCH NEXT 10 ROWS ONLY";
            //MessageBox.Show(query);
            listadoPublicaciones.DataSource = BDManager.getData(query);
            nPag.Text = numeroDePagina.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {  }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_agregarRubro_Click(object sender, EventArgs e)
        {
            // NO PUEDE SER MAS PORONGA EL LENGUAJE?
            if (!listadoRubros.Items.Cast<rubro>().Any(x => x.id_rubro.Equals(rubro.SelectedValue.ToString())))
            {
                listadoRubros.Items.Add(new rubro { descripcion = rubro.Text, id_rubro = rubro.SelectedValue.ToString() });
                listadoRubros.DisplayMember = "descripcion";
            }           
        }
        private void btn_eliminarRubro_Click(object sender, EventArgs e)
        {
            if(listadoRubros.SelectedIndex >= 0)
                listadoRubros.Items.RemoveAt(listadoRubros.SelectedIndex);
            else
                MessageBox.Show("Error: debe seleccionar una fila", "Error al seleccionar rubro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void right_Click(object sender, EventArgs e)
        {
            llenarGrillaPublicaciones(Convert.ToInt32(nPag.Text) + 1);
            if(listadoPublicaciones.Rows.Count == 0)
                llenarGrillaPublicaciones(Convert.ToInt32(nPag.Text) - 1);
        }

        private void left_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(nPag.Text) -1 >= 0)
                llenarGrillaPublicaciones(Convert.ToInt32(nPag.Text) - 1);
        }

        private void leftleft_Click(object sender, EventArgs e)
        {
            llenarGrillaPublicaciones(0);
        }

        private void righttight_Click(object sender, EventArgs e)
        {
            String myq = queryLimpio.Replace("SELECT DISTINCT *", "SELECT DISTINCT COUNT(*)").Replace("ORDER BY id_grado,1", "");
            //MessageBox.Show(myq);
            BDManager.queryOptionalObject(myq, queryTypes.COUNT);
            llenarGrillaPublicaciones(((int)Math.Floor((double)BDManager.returnDummy/10)));
        }
    }