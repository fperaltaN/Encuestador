using Encuestador;
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
    public partial class frmPrincipal : Form
    {
        #region Constructor
        public frmPrincipal()
        {
            InitializeComponent();

        }
        #endregion

        #region Metodos
        private void frmPrincipal_Load(object sender, System.EventArgs e)
        {
            this.TopMost = false;
            // Set the child form's MdiParent property to 
            // the current form.
            
            MainMenuStrip.Enabled = false;
            Form login = new frmLogin();
            login.Show();
            login.Parent = this.ParentForm;
            login.FormClosing += new FormClosingEventHandler(form_FormClosing);
            login.TopMost = true;


            // Call the method that changes the background color.
            SetBackGroundColorOfMDIForm();
        }
        /// <summary>
        /// Obscurecemos los ocntroles del Form
        /// </summary>
        private void SetBackGroundColorOfMDIForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)

                // If the control is the correct type,
                // change the color.
                {
                    ctl.BackColor = System.Drawing.Color.Silver;
                }
            }

        }
        #endregion

        #region Eventos
        private void encuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nroEncuesta = new frmNroEncuesta();
            nroEncuesta.Show();
            nroEncuesta.Parent = this.ParentForm;
            nroEncuesta.TopMost = true;
        }

        private void nuevaEncuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nuevaEncusta = new frmNuevaEncuesta();
            nuevaEncusta.Show();
            nuevaEncusta.Parent = this.ParentForm;
            nuevaEncusta.TopMost = true;
        }

        private void resultadosEncuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form resultados = new frmExportar();
            resultados.Show();
            resultados.Parent = this.ParentForm;
            resultados.TopMost = true;
        }
        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MainMenuStrip.Enabled = true;

        }
        #endregion
    }
}
