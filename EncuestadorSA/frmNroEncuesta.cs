using System;
using System.Windows.Forms;
using Encuestador.Entities;
using Encuestador.BL;
using System.Globalization;

namespace Encuestador
{
    public partial class frmNroEncuesta : Form
    {
        #region Variables
        private GestorRespuestas gestorRespuestas = new GestorRespuestas();
        private int pIdEncuesta;
        #endregion

        #region Propiedades
        public EntUsuarios UsuarioConectado { get; set; }
        #endregion

        #region Constructor
        public frmNroEncuesta()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        public bool validarControles()
        {
            if (cmbDataEncuesta.Text == null || cmbDataEncuesta.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el Número de Encuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void LoadDatos()
        {
            this.Text = this.Text + " - " + UsuarioConectado.Usuario;
            //var ampm=  DateTime.Now.Hour<12 ? "am" : "pm";
            var ampm = DateTime.Now.ToString("tt", CultureInfo.InvariantCulture) == "AM" ? "am" : "pm";
            var pNroRespuesta = gestorRespuestas.RegistrarEncuestaXUsuario(UsuarioConectado.IdUsuario, UsuarioConectado.Usuario,ampm).Split('*');
            cmbDataEncuesta.Text = pNroRespuesta[0];
            pIdEncuesta = int.Parse(pNroRespuesta[1]);
        }

        private void IrASitiosEncuestas()
        {
            if (validarControles())
            {
                frmControl formEncuesta = new frmControl();
                formEncuesta.NroEncuesta = cmbDataEncuesta.Text;
                formEncuesta.UsuarioConectado = UsuarioConectado;
                formEncuesta.IdEncuesta = pIdEncuesta;
                this.Close();
                formEncuesta.ShowDialog();
            }
        }

        #endregion

        #region Eventos
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            IrASitiosEncuestas();
        }
        private void frmNroEncuesta_Load(object sender, EventArgs e)
        {
            LoadDatos();
        }
        private void txtNroEncuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
                e.Handled = true;
            if ((int)e.KeyChar == (int)Keys.Enter)
                IrASitiosEncuestas();
        }

        #endregion

    }
}
