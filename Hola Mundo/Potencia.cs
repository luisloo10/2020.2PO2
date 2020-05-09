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
                Resultado = Convert.ToInt16(Math.Pow(Valor1, Valor2));
            }
            get
            {
                return Convert.ToInt16(Math.Pow(Valor1, Valor2));
            }
        }


    }

}
