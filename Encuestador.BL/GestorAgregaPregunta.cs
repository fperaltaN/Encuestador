using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encuestador.Entities;
using Encuestador.DL;
using System.Data;

namespace Encuestador.BL
{
    public class GestorAgregaPregunta
    {
        EntPreguntaTmp tmpPregunta = new EntPreguntaTmp();
        static List<EntPreguntaTmp> lstTmpPregunta = new List<EntPreguntaTmp>();
        static int rowNumero = 0;
        public void agregaDatos(string pregunta, string tipo)
        {
            tmpPregunta.Pregunta = pregunta;
            tmpPregunta.tipo = tipo;
            lstTmpPregunta.Add(tmpPregunta);
        }

        public List<EntPreguntaTmp> listaTmpPreguntas()
        {
            return lstTmpPregunta;
        }
        public  DataTable llenaGrid()
        {
            DataTable dtDatosTable = new DataTable("Tablatmp");            
            DataSet dtDatosGrid = new DataSet();
            dtDatosTable.Columns.Add("Num_Pregunta");
            dtDatosTable.Columns.Add("Pregunta");
            dtDatosTable.Columns.Add("Tipo_Pregunta");
            dtDatosTable.Columns.Add("Activa");

            foreach (var item in listaTmpPreguntas())
            {
                DataRow row = dtDatosTable.NewRow();
                row["Num_Pregunta"] = rowNumero++;
                row["Pregunta"] = item.Pregunta;
                row["Tipo_Pregunta"] = item.tipo;
                row["Activa"] = true;
                dtDatosTable.Rows.Add(row);                
            }
            dtDatosGrid.Tables.Add(dtDatosTable);
            return dtDatosTable;
        }
    }
}
