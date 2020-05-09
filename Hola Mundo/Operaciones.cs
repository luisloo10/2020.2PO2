using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hola_Mundo;


//Ejercicios
//1: Crear una clase llamada Suma y agregar una funcion llamada Operar que asigne a la variable 'resultado' la suma de valor1 y valor2
//2: Crear una clase llamada Resta y agregar una funcion llamada Operar que asigne a la variable 'resultado' la resta de valor1 y valor2
//3: Crear una clase llamada Multiplicacion y agregar una funcion llamada Operar que asigne a la variable 'resultado' la multiplicacion de valor1 y valor2
//4: Crear una clase llamada Division y agregar una funcion llamada Operar que asigne a la variable 'resultado' la division de valor1 y valor2
//5: Crear una clase llamada Potencia y agregar una funcion llamada Operar que asigne a la variable 'resultado' el resultado de valor1 elevado a la potencia valor2.
//6: Crear una clase llamada Sumax5 y agregar una funcion llamada Operar que asigne a la variable 'resultado' la suma de valor1 y valor2 multiplicada por 5
//7: Crear una clase llamada DobleMultiplicacion y agregar una funcion llamada Operar que asigne a la variable 'resultado' la doble multiplicacion de valor1 y valor2

//Al terminar su ejercicio, subir el cambio al repositorio
namespace Hola_Mundo
{
    class Operaciones
    {
        protected int valor1;
        protected int valor2;
        protected int resultado;
        public int Valor1
        {
            set
            {
                valor1 = value;
            }
            get
            {
                return valor1;
            }
        }

        public int Valor2
        {
            set
            {
                valor2 = value;
            }
            get
            {
                return valor2;
            }
        }

        public int Resultado
        {
            protected set
            {
                resultado = value;
            }
            get
            {
                return resultado;
            }
        }
        
    }
}

 



