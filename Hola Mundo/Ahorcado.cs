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
    public partial class Ahorcado : Form
    {
        List<string> Palabras = new List<string>();
        AhorcadoComponents AhorcadoClase;

        public Ahorcado()
        {
            InitializeComponent();
        }

        private void Ahorcado_Load(object sender, EventArgs e)
        {
            AhorcadoClase = new AhorcadoComponents();
            Palabras = AhorcadoClase.SetWords();
        }

        public class AhorcadoComponents
        {
            public List<string> SetWords()
            {
                List<string> Word = new List<string>();
                Word.Add("arbol");
                Word.Add("perro");
                Word.Add("computadora");
                Word.Add("lapiz");
                Word.Add("pastel");
                Word.Add("manzana");
                Word.Add("pizza");
                Word.Add("dato");
                Word.Add("cacahuate");
                Word.Add("motocicleta");
                Word.Add("automovil");
                Word.Add("estudiante");
                Word.Add("cucaracha");
                Word.Add("cuarentena");

                return Word;
            }
        }

        private void bSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                int NumeroElemento = 1; //GetRandomNumber(0.0, Palabras.Count());
                string SelectedWord = Palabras[NumeroElemento].ToString();
                int Size = SelectedWord.Length;
                
                
                switch(Size)
                {
                    case 4:
                        p1.Visible = true;
                        break;
                    case 5:
                        p1.Visible = true;
                        p2.Visible = true;
                        p3.Visible = true;
                        p4.Visible = true;
                        p5.Visible = true;
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int GetRandomNumber(double min, double max)
        {
            Random rnd = new Random();
            return Convert.ToInt32(rnd.NextDouble() * (max - min) + min);
        }
    }
}
