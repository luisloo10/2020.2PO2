using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    class Automovil
    {
        public Automovil(int llantas, string color, int puertas, int year, string marca, string modelo, int cilindraje, string transmision)
        {
            Llantas = llantas;
            this.Color = color;
            Puertas = puertas;
            Year = year;
            Marca = marca;
            Modelo = modelo;
            Cilindraje = cilindraje;
            Transmision = transmision;
        }

        public int Llantas;
        public string Color;
        public int Puertas;
        public int Year;
        public string Marca;
        public string Modelo;
        public int Cilindraje;
        public string Transmision;
    }
}
