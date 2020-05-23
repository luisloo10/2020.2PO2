using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_Mundo
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        int Valor1, Valor2;
        
        private void b1_Click(object sender, EventArgs e)
        {
            Valor1 = 1;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Valor2 = 2;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            
        }

        private int Suma(int Valor1, int Valor2)
        {
            return Valor1 + Valor2;
        }

        private void bIgual_Click(object sender, EventArgs e)
        {
            tResultado.Text = Suma(Valor1, Valor2).ToString();
        }
    }
}
