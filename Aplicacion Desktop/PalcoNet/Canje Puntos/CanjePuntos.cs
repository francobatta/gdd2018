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
    public partial class CanjePuntos : Form
    {
        public CanjePuntos()
        {
            InitializeComponent();
        }
        private void CanjePuntos_Load(object sender, EventArgs e)
        {
            listadoPuntos.DataSource = BDManager.getData("SELECT fecha_compra, puntos FROM EQUISDE.compra WHERE username = '" +/* usuarioGlobal.usuarioLogueado.username*/"10125617" + "'");
            listadoComprasPuntos.DataSource = BDManager.getData("SELECT fecha_de_obtencion,puntos_necesarios FROM EQUISDE.premio_x_cliente pc JOIN EQUISDE.premio p ON(pc.id_premio = p.id_premio) WHERE username = '" + /*usuarioGlobal.usuarioLogueado.username*/ "10125617" + "'");
            List<int> listPuntos = new List<int>();
            foreach (DataGridViewRow item in listadoPuntos.Rows)
            {
                listPuntos.Add(Convert.ToInt32(item.Cells[1].Value));
            }
            List<int> listComprados = new List<int>();
            foreach (DataGridViewRow item in listadoComprasPuntos.Rows)
            {
                listComprados.Add(Convert.ToInt32(item.Cells[1].Value));
            }
            puntos_actual.Text = (listPuntos.Sum() - listComprados.Sum()).ToString(); 
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

        private void btn_elegir_premios_Click(object sender, EventArgs e)
        {
            CompraPremio compraPremio = new CompraPremio(Convert.ToInt32(puntos_actual.Text));
            compraPremio.Closed += (s, args) => this.Close();
            compraPremio.Show();
        }

        private void listadoActualPublicacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }