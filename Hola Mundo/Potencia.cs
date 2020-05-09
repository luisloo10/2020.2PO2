using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    class Potencia : Operaciones
    {
        public int Operar
        {
            protected set
            {
                double resultado;
                resultado = Math.Pow(valor1, Valor2);
            }
            get
            {
                return resultado;
            }


        }


    }

}
