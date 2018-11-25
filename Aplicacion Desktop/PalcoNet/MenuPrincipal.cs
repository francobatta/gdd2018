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
                    BackColor = Color.DarkBlue,
                };
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