using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encuestador.Entities;

using System.Data.OleDb;
using System.Data;
using System.Globalization;
using CapaDatos;
using System.Data.SqlClient;

namespace Encuestador.DL
{
    public class Respuestas
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
        public DataSet RegistrarEncuesta(EntRespuesta pRespuesta)
        {
            DataSet datos = new DataSet();
            SQLDatos obj = new SQLDatos();
            try
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@Usuario", SqlDbType.Int, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, pRespuesta.IdEncuesta);
                param[1] = new SqlParameter("@Contraseña", SqlDbType.Int, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, pRespuesta.IdPregunta);
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




        public static string RegistrarEncuestaXUsuario(int pIdUsuario, string pNombreUsuario, string pAmPm)
        {
            var conexion = OdbcClient.Conectar();
            OleDbTransaction trans = null;
            var filasAfectadas = 0;
            try
            {
                trans = conexion.BeginTransaction();
                string sql = "INSERT INTO NroEncuestaXUsuario (IdUsuario) VALUES (@IdUsuario)";
                var lstParametros = new List<OleDbParameter>();
                lstParametros.Add(new OleDbParameter("@IdUsuario", pIdUsuario));
                filasAfectadas = OdbcClient.EjecutarCommand(sql, lstParametros, conexion, trans);

                sql = "SELECT @@Identity";
                var idEncuesta = int.Parse(OdbcClient.EjecutarScalar(sql, conexion, trans));
                //var nroEncuesta = pNombreUsuario + "-"+pAmPm+"-"+idEncuesta.ToString().PadLeft(6, '0');
                int turno = 0;
                int horario = 0;
                if (pNombreUsuario.ToUpper() == "MAÑANA")
                    turno = 01;
                if (pNombreUsuario.ToUpper() == "TARDE")
                    turno = 02;
                if (pNombreUsuario.ToUpper() == "ADMIN")
                    turno = 03;
                if (pAmPm.ToUpper() == "AM")
                    horario = 001;
                if (pAmPm.ToUpper() == "PM")
                    horario = 002;

                var nroEncuesta = turno.ToString().PadLeft(2, '0') + "-" + horario.ToString().PadLeft(3, '0') + "-" + idEncuesta.ToString().PadLeft(6, '0');

                sql = "UPDATE NroEncuestaXUsuario SET NroEncuesta = @NroEncuesta WHERE IdEncuesta = @IdEncuesta AND IdUsuario = @IdUsuario";
                lstParametros = new List<OleDbParameter>();
                lstParametros.Add(new OleDbParameter("@NroEncuesta", nroEncuesta));
                lstParametros.Add(new OleDbParameter("@IdEncuesta", idEncuesta));
                lstParametros.Add(new OleDbParameter("@IdUsuario", pIdUsuario));
                filasAfectadas = OdbcClient.EjecutarCommand(sql, lstParametros, conexion, trans);
                if (filasAfectadas > 0)
                    trans.Commit();

                return nroEncuesta + "*" + idEncuesta;

            }
            catch (Exception ex)
            {
                if (trans != null)
                    trans.Rollback();
                throw new Exception("No se pudo registrar la encuesta");
            }
            finally
            {
                conexion.Close();
            }
        }

        public static int EliminarEncuestaXUsuario(string pNroEncuesta, int pIdEncuesta, int pIdUser)
        {
            var conexion = OdbcClient.Conectar();
            OleDbTransaction trans = null;
            var filasAfectadas = 0;
            try
            {
                trans = conexion.BeginTransaction();
                string comando = "DELETE FROM NroEncuestaXUsuario WHERE  NroEncuesta = @NroEncuesta and IdEncuesta = @IdEncuesta AND IdUsuario = @IdUsuario";
                var lstParametros = new List<OleDbParameter>();
                lstParametros.Add(new OleDbParameter("@NroEncuesta", pNroEncuesta));
                lstParametros.Add(new OleDbParameter("@IdEncuesta", pIdEncuesta));
                lstParametros.Add(new OleDbParameter("@IdUsuario", pIdUser));
                filasAfectadas = OdbcClient.EjecutarCommand(comando, lstParametros, conexion, trans);
                if (filasAfectadas > 0)
                    trans.Commit();
            }
            catch (Exception)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                throw new Exception("No se pudo borrar la encuesta");
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return filasAfectadas;
        }
    }
}
