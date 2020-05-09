using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_Mundo
{
    public partial class fOperaciones : Form
    {
        public fOperaciones()
        {
            InitializeComponent();
        }

        private void fOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void bSuma_Click(object sender, EventArgs e)
        {
            Suma S = new Suma();
            S.Valor1 = Convert.ToInt16(tValor1.Text);
            S.Valor2 = Convert.ToInt16(tValor2.Text);
            tResultado.Text = S.Operar().ToString();
        }

        private void bPotencia_Click(object sender, EventArgs e)
        {
            Potencia P = new Potencia();
            
            P.Valor1 = Convert.ToInt16(tValor1.Text);
            P.Valor2 = Convert.ToInt16(tValor2.Text);
            P.Operar();
            tResultado.Text = P.Resultado.ToString();
            
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            division d = new division();
            d.Valor1 = Convert.ToInt16(tValor1.Text);
            d.Valor2 = Convert.ToInt16(tValor2.Text);
            tResultado.Text = d.Operar().ToString();
        }

        private void cOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cOperaciones.SelectedIndex)
            {
                case 0:
                    Suma s = new Suma();
                    s.Valor1= Convert.ToInt16(tValor1.Text);
                    s.Valor2 = Convert.ToInt16(tValor2.Text);
                    tResultado.Text = s.Operar().ToString();
                    break;
                case 1:
                    Resta r = new Resta();
                    r.Valor1 = Convert.ToInt16(tValor1.Text);
                    r.Valor2 = Convert.ToInt16(tValor2.Text);
                    tResultado.Text = r.Operar().ToString();
                    break;
                case 2:

                    break;
            }
        }
    }
}
