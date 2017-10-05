using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestador.Entities
{
    public class EntEncuesta
    {
        public int IdEncuesta { get; set; }

        public int NoEncuesta{ get; set; }
        public String NombreEncuesta{ get; set; }
        public Boolean ActivaPregunta { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
