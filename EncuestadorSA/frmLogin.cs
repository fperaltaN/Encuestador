using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using Encuestador.BL;
using Encuestador.Entities;
using EncuestadorSA;

namespace Encuestador
{
    public partial class frmLogin : Form
    {
        #region Variables
        private GestorUsuario gestorUsuarios = new GestorUsuario();
        #endregion

        #region Constructor
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                IniciarSesion();
        }
        #endregion

        #region Metodos
        private void IniciarSesion()
        {
            var usuario = new EntUsuarios();
            try
            {
                if (validarControles())
                {
                    usuario.Usuario = txtUsuario.Text.Trim();
                    usuario.Contraseña = txtPassword.Text.Trim();
                    var oAux = gestorUsuarios.Login(usuario);
                    if (oAux != null)
                    {
                        frmPrincipal frm = new frmPrincipal();
                        //frm.UsuarioConectado = oAux;
                       // frm.Show = true;
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("El Usuario o la Contraseña Ingresados no son correctos", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Focus();
                        txtPassword.Text = "";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("hubo un error en la ejecuión de la aplicación, Contacta al administrador:" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool validarControles()
        {
            if ((txtUsuario.Text != null && !txtUsuario.Text.Equals(string.Empty)) && txtUsuario.Text.Length <= 50)
            {
                if ((txtPassword.Text != null && !txtPassword.Text.Equals(string.Empty)) && txtPassword.Text.Length <= 50)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return false;
            }
        }
        #endregion

    }
}
