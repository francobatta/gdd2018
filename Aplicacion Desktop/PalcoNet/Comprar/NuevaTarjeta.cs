using PalcoNet.BDManager;
using PalcoNet.Registro_de_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Login;
using PalcoNet.Comprar;

    public partial class NuevaTarjeta : Form
    {
        public NuevaTarjeta()
        {
            InitializeComponent();
        }

        private void NuevaTarjeta_Load(object sender, EventArgs e)
        {
            userNombre.Text = "De: " + usuarioGlobal.usuarioLogueado.username;
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

    }

    private void btn_asociar_Click(object sender, EventArgs e)
    {
        try
        {
            tarjeta t = new tarjeta();
            t.username = usuarioGlobal.usuarioLogueado.username;
            t.nro_tarjeta = nroTarje.Text;
            t.nombre_titular = titular.Text;
            t.cod_seguridad = codS.Text;
            t.fecha_vencimiento = fechaVto.Value.ToString("s");
            
            Validaciones.inicializarValidador();
            Validaciones.esValido("Nro. de tarjeta", nroTarje.Text, new Validaciones.Numeros());
            Validaciones.esValido("Nombre del titular", titular.Text, new Validaciones.Letras());
            Validaciones.esValido("Código de seguridad", codS.Text, new Validaciones.Numeros());
            if (!String.IsNullOrEmpty(Validaciones.camposInvalidos))
                throw new CamposInvalidosException();
            if(fechaVto.Value < DateTime.Today)
                throw new FechaInvalidaException();
            BDManager.insertInto("tarjeta", t);
            MessageBox.Show("Tarjeta ingresada con éxito", "Tarjeta aceptada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        catch (CamposInvalidosException) { MessageBox.Show(Validaciones.camposInvalidos, "Error al validar tarjeta nueva", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        catch (FechaInvalidaException) { MessageBox.Show("No puede ingresar una tarjeta vencida", "Error al validar tarjeta nueva", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }
     
    }