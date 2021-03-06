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

    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
        }
        private void AltaRol_Load(object sender, EventArgs e)
        {
            List<object> listaTraidaDeBD = BDManager.getList("SELECT * FROM EQUISDE.funcionalidad", new funcionalidad());
            List<funcionalidad> listaFuncionalidades = listaTraidaDeBD.Cast<funcionalidad>().ToList();
            funcionalidades.DataSource = listaFuncionalidades;
            funcionalidades.DisplayMember = "nombre";
            listaFuncionalidadesAsignadas.DisplayMember = "nombre";
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            nombre.Text = default(String);
            listaFuncionalidadesAsignadas.Items.Clear();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
        if(funcionalidades.SelectedItem != null && !listaFuncionalidadesAsignadas.Items.Contains(funcionalidades.SelectedItem))
            listaFuncionalidadesAsignadas.Items.Add(funcionalidades.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaFuncionalidadesAsignadas.SelectedItem != null)
                listaFuncionalidadesAsignadas.Items.Remove(listaFuncionalidadesAsignadas.SelectedItem);
            else
                MessageBox.Show("Seleccione item a eliminar de la lista", "No hay item seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones.inicializarValidador();
                Validaciones.esValido(nombre.Name, nombre.Text, new Validaciones.Letras());
                Validaciones.esValido("funcionalidades asignadas", listaFuncionalidadesAsignadas.Items.Count.ToString(), new Validaciones.NumeroNoCreo());
                if (!String.IsNullOrEmpty(Validaciones.camposInvalidos))
                    throw new CamposInvalidosException();
                // fin validaciones regex
                    BDManager.insertInto("rol", new rol { nombre = nombre.Text, habilitado = "True" });
                    rol rolDummy = new rol();
                    BDManager.selectIntoObjectByString("rol", "nombre", nombre.Text, rolDummy);
                    foreach (funcionalidad f in listaFuncionalidadesAsignadas.Items)
                        BDManager.insertInto("rol_x_funcionalidad", new rol_x_funcionalidad { id_funcionalidad = f.id_funcionalidad, id_rol = rolDummy.id_rol});
                    MessageBox.Show("El rol ha sido dado de alta", "Rol dado de alta correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
            }
            catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos del rol a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }