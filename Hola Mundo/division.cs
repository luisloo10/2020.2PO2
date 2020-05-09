using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    class division : Operaciones
    {
        public int Operar()
        {
            if(valor2==0)
            {
                return 0;
            }
            else
            {
                return resultado = valor1 / valor2;
            }
        }
    }
}
