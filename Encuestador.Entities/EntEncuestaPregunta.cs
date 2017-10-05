using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestador.Entities
{
    public class EntEncuestaPregunta
    {
        public int IdEncuestaPregunta { get; set; }
        public int IdEncuesta { get; set; }
        public int IdPregunta { get; set; }
        public int IdUsuario { get; set; }
    }
}
