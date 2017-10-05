using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestador.Entities
{
    public class EntPregunta
    {
        public int IdPregunta { get; set; }
        public String DescripcionPregunta { get; set; }
        public string TipoPregunta { get; set; }
        public Boolean ActivaPregunta { get; set; }
        public DateTime FechaCreacion{ get; set; }
    }
}
