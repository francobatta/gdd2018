﻿using PalcoNet.BDManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    public partial class HistorialCliente : Form
    {
        public HistorialCliente()
        {
            InitializeComponent();
        }
        private void HistorialCliente_Load(object sender, EventArgs e)
        {
            listadoActualCompras.DataSource = BDManager.getData("SELECT DISTINCT fecha_compra,email,c.cantidad,puntos,forma_de_pago FROM EQUISDE.compra c JOIN EQUISDE.item i ON(i.id_compra=c.id_compra) JOIN EQUISDE.factura f ON(f.id_factura=i.id_factura) WHERE username = '" + usuarioGlobal.usuarioLogueado.username + "'");
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
    }
