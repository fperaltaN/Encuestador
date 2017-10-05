using System;

namespace Encuestador.Entities
{
    public class EntRespuesta
    {
        public int IdRespuesta { get; set; }
        public int IdPregunta{ get; set; }
        public int IdEncuesta { get; set; }
        public String ComentariosRespuesta{ get; set; }
        public string ValorRespuesta { get; set; }
        public DateTime FechaRegistroRespuesta { get; set; }

    }
}
