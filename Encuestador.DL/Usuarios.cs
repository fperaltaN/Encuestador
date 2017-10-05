using System;
using System.Collections.Generic;
using Encuestador.Entities;

using System.Data.OleDb;
using System.Data;
using CapaDatos;
using System.Data.SqlClient;

namespace Encuestador.DL
{
    public class Usuarios
    {
        #region variables privadas
        private int transSucess = 0;
        private string valUsuario = "ValidaUsuario";
        private string getUsuario = "sel_Usuario";
        private string getUsuarioXId = "sel_byId_Usuario";
        private string addUsuario = "add_Usuario";
        private string updUsuario = "upd_Usuario";
        private string delUsuario = "del_Usuario";
        private string selALLUsuario = "sel_All_Usuarios";
        #endregion
        /// <summary>
        /// Regresa el Id si el usuario existe
        /// </summary>
        /// <param name="pUsers"> Entidad Usuario</param>
        /// <returns></returns>
        public DataSet IniciarSesion(EntUsuarios pUsers)
        {
            DataSet datos = new DataSet();
            SQLDatos obj = new SQLDatos();
            try
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@Usuario", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, pUsers.Usuario);
                param[1] = new SqlParameter("@Contraseña", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, pUsers.Contraseña);
                //param[2] = new SqlParameter("@IdUsuario", SqlDbType.Int, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, pUsers.Contraseña);
                transSucess = obj.getDataFromSP(getUsuario, param, "TblUsuario", datos);                
            }
            catch (Exception ex)
            {
                transSucess = 1;
                Console.WriteLine("Error:" + ex);
            }
            return datos;
        }

        /// <summary>
        /// Obtiene todos los Usuario y regresa un dataSet
        /// </summary>
        /// <returns></returns>
        public DataSet getAllUsuarios()
        {
            SQLDatos obj = new SQLDatos();
            DataSet datos = new DataSet();
            int opSatisfactoria = 0;
            opSatisfactoria = obj.getDataFromSP(selALLUsuario, "TblUsuario", datos);
            return datos;
        }

        /// <summary>
        /// Obtiene todos los Usuario de la BD
        /// </summary>
        /// <returns></returns>
        public DataSet getUsuariosGrid()
        {
            SQLDatos obj = new SQLDatos();
            DataSet datos = new DataSet();
            int opSatisfactoria = 0;
            opSatisfactoria = obj.getDataFromSP(getUsuario, "TblUsuario", datos);
            return datos;
        }

        /// <summary>
        /// Obtiene  la información de un Usuario
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        public DataSet getUsuarioById(int idUsuario)
        {
            DataSet datos = new DataSet();
            SQLDatos obj = new SQLDatos();
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@IdUsuario", SqlDbType.Int, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, idUsuario);
                transSucess = obj.getDataFromSP(getUsuarioXId, param, "TblUsuario", datos);
            }
            catch (Exception ex)
            {
                transSucess = 1;
            }

            return datos;
        }
    }
}
