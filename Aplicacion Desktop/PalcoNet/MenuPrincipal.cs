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

    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // funcionalidades de ESE rol
            List<object> listaTraidaDeBD = BDManager.getList(
                "SELECT f.id_funcionalidad, f.nombre FROM EQUISDE.funcionalidad f JOIN EQUISDE.rol_x_funcionalidad rf ON f.id_funcionalidad = rf.id_funcionalidad JOIN EQUISDE.rol r ON rf.id_rol = r.id_rol WHERE rf.id_rol =" + usuarioGlobal.rolLogueado.id_rol
                , new funcionalidad());
            List<funcionalidad>listaFuncionalidades = listaTraidaDeBD.Cast<funcionalidad>().ToList();
            foreach(funcionalidad f in listaFuncionalidades)
            {
                var btn = new Button
                {
                    Name = f.nombre,
                    Text = f.nombre,
                    Size = new Size(200, 100),
                    Font = new Font("Century Gothic", 12),
                    ForeColor = Color.Gainsboro,
                    BackColor = Color.DarkBlue
                };
                switch (btn.Text)
                {
                    case "AltaCliente":
                        btn.Text = "Alta de cliente";
                        break;
                    case "BusquedaPublicacionE":
                        btn.Text = "Editar publicación";
                        break;
                    case "BusquedaCliente":
                        btn.Text = "Búsqueda de clientes";
                        break;
                    case "AltaEmpresa":
                        btn.Text = "Alta de empresa";
                        break;
                    case "BusquedaEmpresa":
                        btn.Text = "Búsqueda de empresas";
                        break;
                    case "RendicionComisiones":
                        btn.Text = "Rendición de comisiones";
                        break;
                    case "CanjePuntos":
                        btn.Text = "Canje de puntos";
                        break;
                    case "BusquedaPublicacion":
                        btn.Text = "Búsqueda de publicación";
                        break;
                    case "AltaRol":
                        btn.Text = "Alta de rol";
                        break;
                    case "BusquedaRol":
                        btn.Text = "Búsqueda de rol";
                        break;
                    case "HistorialCliente":
                        btn.Text = "Historial de cliente";
                        break;
                    case "NuevaCompra":
                        btn.Text = "Realizar compra";
                        break;
                    case "AltaPublicacion":
                        btn.Text = "Alta de publicación";
                        break;
                    case "AltaUsuario":
                        btn.Text = "Alta de usuario";
                        break;
                    case "BusquedaUsuario":
                        btn.Text = "Búsqueda de usuario";
                        break;
                    case "ListadoEstadistico":
                        btn.Text = "Listado estadístico";
                        break;
                }
                    
                btn.Click += (s, efe) =>
                {
                    Type myType = Type.GetType(f.nombre);
                    Form formi = (Form)Activator.CreateInstance(myType);
                    formi.ShowDialog();
                };
                conjuntoBotones.Controls.Add(btn);
            }
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

        public Form formi { get; set; }
    }