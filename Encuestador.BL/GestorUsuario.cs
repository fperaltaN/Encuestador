using Encuestador.Entities;
using System;
using System.Collections.Generic;
using Encuestador.DL;
namespace Encuestador.BL
{
    public class GestorUsuario
    {
        Usuarios obj = new Usuarios();
        /// <summary>
        /// Agraga el Id una vez consultado
        /// </summary>
        /// <param name="pUsers"></param>
        /// <returns></returns>
        public EntUsuarios Login(EntUsuarios pUsers)
        {
            pUsers.IdUsuario = Convert.ToInt32(obj.IniciarSesion(pUsers).Tables[0].Rows[0]["IdUsuario"]);
            return pUsers;
        }

        public List<Entities.EntUsuarios> ObtenerTodosUsuarios()
        {
            return null;
        }

    }
}
