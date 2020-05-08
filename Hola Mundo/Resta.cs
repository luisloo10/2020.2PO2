using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    class Resta : Operaciones
    {
        public int Operar
        {
            protected set
            {

                resultado = valor1 - valor2;
            }
            get
            {
                return resultado;
            }
        }

    }
}
