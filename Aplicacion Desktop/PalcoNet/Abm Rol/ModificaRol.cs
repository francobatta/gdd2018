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

    public partial class ModificaRol : Form
    {
        public rol rolAModificar {get;set;}
        public List<funcionalidad> listaFuncionalidades = new List<funcionalidad>();
        public ModificaRol(rol _rol)
        {
            InitializeComponent();
            this.rolAModificar = _rol;
        }
        private void ModificaRol_Load(object sender, EventArgs e)
        {
            nombre.Text = rolAModificar.nombre;
            // estados
            if (rolAModificar.habilitado == "False")
                btn_habilitar_rol.Enabled = true;
            else
                btn_habilitar_rol.Enabled = false;
            // todas funcionalidades
            List<object> listaFuncionalidadesGeneralesBD = BDManager.getList("SELECT * FROM EQUISDE.funcionalidad", new funcionalidad());
            List<funcionalidad> listaFuncionalidadesGenerales = listaFuncionalidadesGeneralesBD.Cast<funcionalidad>().ToList();
            funcionalidades.DataSource = listaFuncionalidadesGenerales;
            // funcionalidades de ESE rol
            List<object> listaTraidaDeBD = BDManager.getList(
                "SELECT f.id_funcionalidad, f.nombre FROM EQUISDE.funcionalidad f JOIN EQUISDE.rol_x_funcionalidad rf ON f.id_funcionalidad = rf.id_funcionalidad JOIN EQUISDE.rol r ON rf.id_rol = r.id_rol WHERE rf.id_rol ="+rolAModificar.id_rol
                , new funcionalidad());
            listaFuncionalidades = listaTraidaDeBD.Cast<funcionalidad>().ToList();
            funcionalidades.DisplayMember = "nombre";
            listaFuncionalidadesAsignadas.DataSource = listaFuncionalidades;
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
            funcionalidad func = funcionalidades.SelectedValue as funcionalidad;
            if (funcionalidades.SelectedItem != null && !listaFuncionalidades.Any(n => n.id_funcionalidad.Equals(func.id_funcionalidad)))
            {
                listaFuncionalidades.Add(funcionalidades.SelectedItem as funcionalidad);
                listaFuncionalidadesAsignadas.DataSource = null;
                listaFuncionalidadesAsignadas.DataSource = listaFuncionalidades;
                listaFuncionalidadesAsignadas.DisplayMember = "nombre";
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            listaFuncionalidades.Remove(listaFuncionalidadesAsignadas.SelectedItem as funcionalidad);
            listaFuncionalidadesAsignadas.DataSource = null;
            listaFuncionalidadesAsignadas.DataSource = listaFuncionalidades;
            listaFuncionalidadesAsignadas.DisplayMember = "nombre";
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
                rolAModificar.nombre = nombre.Text;
                BDManager.updateSet("rol", "id_rol", rolAModificar);
                BDManager.deleteByField("rol_x_funcionalidad", "id_rol", rolAModificar.id_rol);
                foreach (funcionalidad f in listaFuncionalidadesAsignadas.Items)
                {
                    BDManager.insertInto("rol_x_funcionalidad", new rol_x_funcionalidad { id_funcionalidad = f.id_funcionalidad, id_rol = rolAModificar.id_rol });
                }                
            }
            catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar campos del rol a insertar", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }

        private void btn_habilitar_rol_Click(object sender, EventArgs e)
        {
            rolAModificar.habilitado = "True";
            btn_habilitar_rol.Enabled = false;
        }
    }