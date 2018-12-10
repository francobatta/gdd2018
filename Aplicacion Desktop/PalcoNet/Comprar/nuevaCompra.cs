﻿using PalcoNet.BDManager;
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
    public partial class NuevaCompra : Form
    {
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
 
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            listadoPublicaciones.DataSource = BDManager.getData("SELECT * FROM EQUISDE.publicacion WHERE id_estado=1 AND descripcion LIKE '%"+descripcion.Text+"%' ORDER BY id_grado");


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

    }