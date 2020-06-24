using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo.GeoPreguntas
{
    public class Preguntas
    {
        public Preguntas(int iD, int grado, string descripcion, int tiempo, int valor)
        {
            ID = iD;
            Grado = grado;
            Descripcion = descripcion;
            Tiempo = tiempo;
            Valor = valor;
        }

        public int ID { get; set; }
        public int Grado { get; set; }
        public string Descripcion { get; set; }
        public int Tiempo { get; set; }
        public int Valor { get; set; }
    }

    public class Respuestas
    {
        public Respuestas(int preguntaID, string descripcion, bool correcta)
        {
            PreguntaID = preguntaID;
            Descripcion = descripcion;
            Correcta = correcta;
        }
        public int PreguntaID { get; set; }
        public string Descripcion { get; set; }
        public bool Correcta { get; set; }
    }
}
