using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Marlon Paz

namespace Hola_Mundo
{
    class Multiplicacion : Operaciones
    {
        public int Operar
        {
            protected set
            {
                resultado = valor1 * valor2;
            }
            get
            {
                return resultado;
            }
        }
    }
}
