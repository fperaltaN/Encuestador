using Encuestador.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encuestador.Entities;

namespace EncuestadorSA
{
    public partial class frmNuevaEncuesta : Form
    {
        #region Variables
        private GestorUsuario gestorUsuarios = new GestorUsuario();
        GestorAgregaPregunta GAP = new GestorAgregaPregunta();
        #endregion

        #region Constructor
        public frmNuevaEncuesta()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos        
        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form formAgregar = new frmAgregaPregunta();
            formAgregar.MdiParent = this.ParentForm;
            formAgregar.Show();
            formAgregar.TopMost = true;
            agregaColumnAgrid();
        }
        #endregion

        #region Métodos
        public void agregaColumnAgrid()
        {
            try
            {
                bindingSourceGrid.DataSource = GAP.llenaGrid();
                grdPreguntas.DataSource = bindingSourceGrid;
                
            }            
            catch (Exception ex)
            {
                MessageBox.Show("hubo un error en el llenado del grid, Contacta al administrador:" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        #endregion
    }
}
