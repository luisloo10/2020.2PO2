using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    class Potencia : Operaciones
    {
        public void Operar()
        {
            Resultado = Convert.ToInt16(Math.Pow(Valor1, Valor2));
        }
    }

}
