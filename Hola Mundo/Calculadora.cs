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
        Calc C = new Calc();
        public Calculadora()
        {
            InitializeComponent();
        }
        
        private void Calculadora_Load(object sender, EventArgs e)
        {
            
        }

        private int Suma(int Valor1, int Valor2)
        {
            return Valor1 + Valor2;
        }

        private void bSuma_Click(object sender, EventArgs e)
        {
            C.Operacion(1);
        }

        private void bResta_Click(object sender, EventArgs e)
        {
            C.Operacion(2);
        }

        private void bMultiplicacion_Click(object sender, EventArgs e)
        {
            C.Operacion(3);
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            C.Operacion(4);
        }

        private void bRetroceder_Click(object sender, EventArgs e)
        {
            if(tResultado.Text.Length>0)
            {
                tResultado.Text = tResultado.Text.Substring(0, tResultado.Text.Length - 1);
            }
        }

        private void bIgual_Click(object sender, EventArgs e)
        {
            if(tResultado.Text.Length > 0)
            {
                tResultado.Text = C.Result(Convert.ToDouble(tResultado.Text));
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.SetResult(tResultado.Text, 1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.SetResult(tResultado.Text, 2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.SetResult(tResultado.Text, 3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.SetResult(tResultado.Text, 4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.SetResult(tResultado.Text, 5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.SetResult(tResultado.Text, 6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.SetResult(tResultado.Text, 7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.SetResult(tResultado.Text, 8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.SetResult(tResultado.Text, 9);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.SetResult(tResultado.Text, 0);
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.Reset();
        }

        private void bC_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.Reset();
        }

        private void bMasMenos_Click(object sender, EventArgs e)
        {
            tResultado.Text = C.ChangeSign(Convert.ToDouble(tResultado.Text));
        }
    }
}
