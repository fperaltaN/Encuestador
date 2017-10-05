using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuestador.Entities
{
    public class EntPreguntaTmp
    {
        private String _Pregunta;

        public String Pregunta
        {
            get { return _Pregunta; }
            set { _Pregunta = value; }
        }

        private String _tipo;
        public String tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }
}
