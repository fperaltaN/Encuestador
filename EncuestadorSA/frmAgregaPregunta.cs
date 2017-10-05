using Encuestador.BL;
using Encuestador.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuestadorSA
{
    public partial class frmAgregaPregunta : Form
    {
        GestorAgregaPregunta GAP = new GestorAgregaPregunta();
        public frmAgregaPregunta()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GAP.agregaDatos(txtPregunta.Text, cmbDataTipoPregunta.Text);
                frmNuevaEncuesta obj = new frmNuevaEncuesta();
                obj.agregaColumnAgrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hubo un error en la ejecuión de la aplicación, Contacta al administrador:" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
