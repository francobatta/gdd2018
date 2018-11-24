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

    public partial class BusquedaRol : Form
    {
        public BusquedaRol()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            listadoActualRoles.DataSource = BDManager.getData("SELECT id_rol, nombre, habilitado FROM EQUISDE.rol");
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
                DataGridViewRow filaElegida = listadoActualRoles.CurrentRow;
                if (filaElegida == null || filaElegida.Selected == false)
                    throw new CamposInvalidosException();
                rol rolACambiar = new rol();
                BDManager.selectIntoObject("rol", "id_rol", filaElegida.Cells["id_rol"].Value.ToString(), rolACambiar);
                ModificaRol modificaRol = new ModificaRol(rolACambiar); // SE LO PASO POR CONSTRUCTOR Y QUE EL MODIFICADOR SE ENCARGUE
                modificaRol.ShowDialog();
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar rol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            DataGridViewRow filaElegida = listadoActualRoles.CurrentRow;
            if (filaElegida == null || filaElegida.Selected == false)
                throw new CamposInvalidosException();
            rol rolACambiar = new rol();
            BDManager.selectIntoObject("rol", "id_rol", filaElegida.Cells["id_rol"].Value.ToString(), rolACambiar);
            rolACambiar.habilitado = "False";
            BDManager.updateSet("rol", "id_rol", rolACambiar);
            BDManager.deleteByField("rol_x_usuario", "id_rol", rolACambiar.id_rol); //les saco a los users el rol inhabilitado
            MessageBox.Show("Rol "+ rolACambiar.nombre +" inhabilitado con éxito. Rol quitado de los usuarios que lo posean.", "Inhabilitación de rol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CamposInvalidosException)
            {
                MessageBox.Show("Error: debe seleccionar una fila del grid", "Error al seleccionar rol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }