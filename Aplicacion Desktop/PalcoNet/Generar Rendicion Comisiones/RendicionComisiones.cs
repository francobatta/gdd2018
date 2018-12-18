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
using PalcoNet.Generar_Rendicion_Comisiones;

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
            listadoComprasARendir.DataSource = null;
            nroComprasAAgregar.Text = default(string);
        }

        private void rendirElegidas_Click(object sender, EventArgs e)
        {
            try
            {
                if(listadoComprasARendir.Rows.Count <= 0)
                    throw new NoHayComprasARendirException();
                factura fact = new factura();
                fact.factura_total = totalComisiones.Text;
                fact.fecha_emision = ConfigurationManager.AppSettings["today"].ToString();
                BDManager.insertIntoAndGetID("factura", "id_factura", fact);
                item itemAInsertar = new item();
                itemAInsertar.id_factura = BDManager.idInsertado;
                foreach (DataGridViewRow r in listadoComprasARendir.Rows)
                {
                    String elId = r.Cells["id_compra"].Value.ToString();
                    List<object> listaFuncionalidadesGeneralesBD = BDManager.getList("SELECT u.* FROM EQUISDE.compra_x_ubicacion cu JOIN EQUISDE.ubicacion u on u.id_ubicacion=cu.id_ubicacion WHERE id_compra =" + elId, new ubicacion());
                    List<ubicacion> ubicaciones = listaFuncionalidadesGeneralesBD.Cast<ubicacion>().ToList();
                    itemAInsertar.id_compra = elId;
                    foreach (ubicacion u in ubicaciones)
                    {
                        grado g = new grado();
                        int sum = Int32.Parse(u.precio);
                        BDManager.genericFillObject("SELECT g.* FROM EQUISDE.ubicacion JOIN EQUISDE.publicacion p ON p.id_publicacion=" + u.id_publicacion + " JOIN EQUISDE.grado g ON g.id_grado=p.id_grado", g);
                        double comision = double.Parse(u.precio) * double.Parse(g.porcentaje);
                        itemAInsertar.importe_venta = sum.ToString();
                        itemAInsertar.importe_comision = comision.ToString();
                        itemAInsertar.descripcion = "comision por compra";
                        itemAInsertar.cantidad = "1";
                        BDManager.insertInto("item", itemAInsertar);
                    }
                }
                MessageBox.Show("Se ha realizado correctamente la rendicion. \nNro_Factura: " + itemAInsertar.id_factura + "\nMonto: " + fact.factura_total, "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NoHayComprasARendirException) { MessageBox.Show("No hay compras seleccionadas para rendir", "Error al rendir", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
                String elId = r.Cells["id_compra"].Value.ToString();
                List<object> listaFuncionalidadesGeneralesBD = BDManager.getList("SELECT u.* FROM EQUISDE.compra_x_ubicacion cu JOIN EQUISDE.ubicacion u on u.id_ubicacion=cu.id_ubicacion WHERE id_compra ="+elId, new ubicacion());
                List<ubicacion> ubicaciones = listaFuncionalidadesGeneralesBD.Cast<ubicacion>().ToList();
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
