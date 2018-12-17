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

    public partial class RendicionComisiones : Form
    {
        public RendicionComisiones()
        {
            InitializeComponent();
        }
        private void RendicionComisiones_Load(object sender, EventArgs e)
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

        private void btn_verSinRendir_Click(object sender, EventArgs e)
        {

            listadoComprasNoRendidas.DataSource = BDManager.getData("SELECT * FROM EQUISDE.compra c WHERE NOT EXISTS (SELECT DISTINCT id_compra FROM EQUISDE.item i WHERE i.id_compra = c.id_compra) ORDER BY 4");
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            listadoComprasNoRendidas.DataSource = null;
        }

        private void rendirElegidas_Click(object sender, EventArgs e)
        {
            
        }

        private void agregar_a_rendir_Click(object sender, EventArgs e)
        {
            int intValue = -1;
            if (int.TryParse(nroComprasAAgregar.Text, out intValue) && intValue > 0)
            {
                listadoComprasARendir.DataSource = BDManager.getData("SELECT TOP " + intValue + " * FROM EQUISDE.compra c WHERE NOT EXISTS (SELECT DISTINCT id_compra FROM EQUISDE.item i WHERE i.id_compra = c.id_compra) ORDER BY 4");
                calcularImporteTotal();
            }
            else
                MessageBox.Show("Error: debe ingresar un número entero", "Error al dar compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void calcularImporteTotal()
        {
            int sum = 0;
            double sumComisiones = 0;
            foreach (DataGridViewRow r in listadoComprasARendir.Rows)
            {
                List<ubicacion> ubicaciones = new List<ubicacion>();
                String elId = r.Cells["id_compra"].Value.ToString();
                BDManager.getList("SELECT u.* EQUISDE.compra_x_ubicacion cu ON id_compra ="+elId+" JOIN EQUISDE.ubicacion u on u.id_ubicacion=cu.id_ubicacion", ubicaciones);
                foreach (ubicacion u in ubicaciones)
                {
                    grado g = new grado();
                    sum += Int32.Parse(u.precio);
                    BDManager.genericFillObject("SELECT g.* FROM EQUISDE.ubicacion JOIN EQUISDE.publicacion p ON p.id_publicacion="+u.id_publicacion+" JOIN EQUISDE.grado g ON g.id_grado=p.id_grado",g);
                    sumComisiones += double.Parse(u.precio) * double.Parse(g.porcentaje);
                }
            }
            total.Text = sum.ToString();
            totalComisiones.Text = sumComisiones.ToString();
            totalVendedores.Text = (sum - sumComisiones).ToString();
        }
    }
