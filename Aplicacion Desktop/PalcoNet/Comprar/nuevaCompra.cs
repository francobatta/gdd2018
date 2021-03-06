﻿using PalcoNet.BDManager;
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
using PalcoNet.Comprar;

    public partial class NuevaCompra : Form
    {
        public publicacion pElegida { get; set; }
        public String queryLimpio;
        public List<ubicacion> ubicaciones = new List<ubicacion>();
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
                    throw new NoNullAllowedException();
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
                listaUbicaciones.DataSource = BDManager.getData("SELECT * FROM EQUISDE.ubicacion WHERE id_publicacion="+pElegida.id_publicacion);
                listaUbicaciones.Columns["id_ubicacion"].Visible = false;
                listaUbicaciones.Columns["id_publicacion"].Visible = false;
                listaUbicaciones.Columns["codigo_tipo"].Visible = false;
                listaUbicaciones.Columns["sin_numerar"].Visible = false;
            }
            catch (NoNullAllowedException) { MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar publicación", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
            query = "SELECT DISTINCT * FROM EQUISDE.publicacion WHERE id_estado=1 AND '" + ConfigurationManager.AppSettings["today"] +"' BETWEEN fecha_publicacion AND fecha_vencimiento AND fecha_vencimiento BETWEEN '" + fechaInicio.Value.ToShortDateString() + "' AND '" + fechaFin.Value.ToShortDateString() + "' AND descripcion LIKE '%" + descripcion.Text + "%'";
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
            email.Text = default(string);
            listaUbicacionesAComprar.DataSource = null;
            listadoPublicaciones.DataSource = null;
            left.Enabled = false;
            leftleft.Enabled = false;
            right.Enabled = false;
            righttight.Enabled = false;
            descripcion.Text = default(string);
            fechaInicio.Text = ConfigurationManager.AppSettings["today"].ToString();
            fechaFin.Text = ConfigurationManager.AppSettings["today"].ToString();
            listadoRubros.Items.Clear();
            nPag.Text = "--";
            listaUbicaciones.DataSource = null;
            idPublicacionElegida.Text = "-";
            pElegida = null;
            importeTotal.Text = "-";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones.inicializarValidador();
                Validaciones.esValido(email.Name, email.Text, new Validaciones.Email());
                Validaciones.esValido("Ubicaciones a comprar", listaUbicacionesAComprar.Rows.Count.ToString(), new Validaciones.NumeroNoCreo());
                if (!String.IsNullOrEmpty(Validaciones.camposInvalidos))
                    throw new CamposInvalidosException();
                compra_x_ubicacion cu = new compra_x_ubicacion();
                compra com = new compra();
                com.username = usuarioGlobal.usuarioLogueado.username;
                com.email = email.Text;
                //Falta atributo fecha
                com.fecha_compra = ConfigurationManager.AppSettings["today"].ToString();
                DateTime fecha = DateTime.ParseExact(com.fecha_compra, "dd-MM-yyyy",null);
                DateTime fechaVencimiento = fecha.AddMonths(3);
                com.fecha_vencimiento_puntos = fecha.ToString("s");
                com.cantidad = listaUbicacionesAComprar.Rows.Count.ToString();
                //los puntos es la cantidad de ubicaciones que compro por 3
                com.puntos = (listaUbicacionesAComprar.Rows.Count * 3).ToString();
                if (!BDManager.exists("tarjeta", "username", usuarioGlobal.usuarioLogueado.username))
                {
                    MessageBox.Show("Usted no posee tarjeta de crédito, por lo que asociará una ahora. Acepte este cuadro.", "Asociar tarjeta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevaTarjeta m = new NuevaTarjeta();
                    m.ShowDialog();
                }
                tarjeta t = new tarjeta();
                BDManager.selectIntoObjectByString("tarjeta","username",usuarioGlobal.usuarioLogueado.username,t);
                if (t.importe.Equals("NULL") || double.Parse(t.importe) <= 0 || double.Parse(t.importe) < double.Parse(importeTotal.Text))
                    throw new ImporteInvalidoException();
                com.forma_de_pago = "tarjeta";
                BDManager.insertIntoAndGetID("compra","id_compra", com);
                cu.id_compra = BDManager.idInsertado;
                foreach (DataGridViewRow dt in listaUbicacionesAComprar.Rows)
                {
                    cu.id_ubicacion = dt.Cells["id_ubicacion"].Value.ToString();
                    BDManager.insertInto("compra_x_ubicacion", cu);
                }
                cliente cli = new cliente();
                BDManager.selectIntoObjectByString("cliente", "username", usuarioGlobal.usuarioLogueado.username, cli);
                int ptos = Int32.Parse(cli.puntos);
                ptos += Int32.Parse(com.puntos);
                cli.puntos = ptos.ToString();
                t.importe = (double.Parse(t.importe) - double.Parse(importeTotal.Text)).ToString();
                BDManager.updateSetStringKey("cliente","username",usuarioGlobal.usuarioLogueado.username,cli);
                BDManager.updateSetStringKey("tarjeta", "username", usuarioGlobal.usuarioLogueado.username, t);
                MessageBox.Show("Gracias por su compra!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos de compra a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ImporteInvalidoException)
            {
                MessageBox.Show("El importe de la tarjeta es inválido o menor al total de compra", "Error al comprar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_agregarRubro_Click(object sender, EventArgs e)
        {
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

        private void btn_agregarUbicacion_Click(object sender, EventArgs e)
        {
            try
            {
                if(listaUbicaciones.CurrentRow == null || listaUbicaciones.SelectedRows[0].Index < 0)
                    throw new CamposInvalidosException();
                ubicacion u = new ubicacion();
                u.precio = listaUbicaciones.SelectedRows[0].Cells["precio"].Value.ToString();
                u.asiento = listaUbicaciones.SelectedRows[0].Cells["asiento"].Value.ToString();
                u.id_publicacion = listaUbicaciones.SelectedRows[0].Cells["id_publicacion"].Value.ToString();
                u.id_ubicacion = listaUbicaciones.SelectedRows[0].Cells["id_ubicacion"].Value.ToString();
                u.codigo_tipo = listaUbicaciones.SelectedRows[0].Cells["codigo_tipo"].Value.ToString();
                u.sin_numerar = listaUbicaciones.SelectedRows[0].Cells["sin_numerar"].Value.ToString();
                u.fila = listaUbicaciones.SelectedRows[0].Cells["fila"].Value.ToString();
                foreach (DataGridViewRow r in listaUbicacionesAComprar.Rows)
                {
                    if (u.id_ubicacion.Equals(r.Cells["id_ubicacion"].Value.ToString()))
                        throw new UbicacionRepetidaException();
                }
                    ubicaciones.Add(u);
                    listaUbicacionesAComprar.DataSource = null;
                    listaUbicacionesAComprar.DataSource = ubicaciones;
                    listaUbicacionesAComprar.Columns["id_ubicacion"].Visible = false;
                    listaUbicacionesAComprar.Columns["id_publicacion"].Visible = false;
                    listaUbicacionesAComprar.Columns["codigo_tipo"].Visible = false;
                    listaUbicacionesAComprar.Columns["sin_numerar"].Visible = false;
                    calcularImporteTotal();
               
            }
            catch (CamposInvalidosException) { MessageBox.Show("Debe elegir una ubicación para agregar", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (UbicacionRepetidaException) { MessageBox.Show("Ubicación ya seleccionada", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void calcularImporteTotal()
        {
            int sum = 0;
            foreach (DataGridViewRow r in listaUbicacionesAComprar.Rows)
            {
                sum += Int32.Parse(r.Cells["precio"].Value.ToString());
            }
            importeTotal.Text = sum.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listaUbicacionesAComprar.CurrentRow != null && listaUbicacionesAComprar.SelectedRows[0].Index > -1)
            {
                ubicaciones.RemoveAt(listaUbicacionesAComprar.CurrentCell.RowIndex);
                listaUbicacionesAComprar.DataSource = ubicaciones;
                listaUbicacionesAComprar.DataSource = null;
                listaUbicacionesAComprar.DataSource = ubicaciones;
                listaUbicacionesAComprar.Columns["id_ubicacion"].Visible = false;
                listaUbicacionesAComprar.Columns["id_publicacion"].Visible = false;
                listaUbicacionesAComprar.Columns["codigo_tipo"].Visible = false;
                listaUbicacionesAComprar.Columns["sin_numerar"].Visible = false;
                calcularImporteTotal();
            }
            else
                MessageBox.Show("Debe elegir una ubicación", "Fila no elegida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }