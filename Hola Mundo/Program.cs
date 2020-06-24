﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_Mundo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new X0());
            //Application.Run(new Calculadora());
            //Application.Run(new Practica_2.TrafficCity());
            //Application.Run(new SocketFiles.SocketForm());
            Application.Run(new GeoPreguntas.MainPreguntas());
        }
    }
}
