using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Hola_Mundo.GeoPreguntas
{
    public partial class MainPreguntas : Form
    {
        Random rnd;
        List<PictureBox> P = new List<PictureBox>();
        int PictureBoxSeleccionado;
        int ImagenRandom;

        Preguntas Preguntas;
        Respuestas Respuestas;
        List<Preguntas> ListaPreguntas;
        List<Respuestas> ListaRespuestas;

        
        public MainPreguntas()
        {
            InitializeComponent();
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            try
            {
                ImagenRandom = GetRandomNumber(8, 40);
                tRuleta.Enabled = true;
                PictureBoxSeleccionado = 1;

                CargarPreguntas();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tRuleta_Tick(object sender, EventArgs e)
        {
            if(ImagenRandom>0)
            {
                Ruleta(ref P);
                ImagenRandom--;
            }
            else
            {
                tRuleta.Enabled = false;
                MostrarPregunta();
            }
        }

        private void Ruleta(ref List<PictureBox> Preguntas)
        {
            foreach (PictureBox P in Preguntas)
            {
                P.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"GeoPreguntas\PreguntaImage.jpg";
            }

            switch (PictureBoxSeleccionado)
            {
                case 1:
                    p1.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"GeoPreguntas\PreguntaSeleccionada.jpg";
                    break;
                case 2:
                    p2.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"GeoPreguntas\PreguntaSeleccionada.jpg";
                    break;
                case 3:
                    p3.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"GeoPreguntas\PreguntaSeleccionada.jpg";
                    break;
                case 4:
                    p4.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"GeoPreguntas\PreguntaSeleccionada.jpg";
                    break;
                case 5:
                    p5.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"GeoPreguntas\PreguntaSeleccionada.jpg";
                    break;
                case 6:
                    p6.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"GeoPreguntas\PreguntaSeleccionada.jpg";
                    break;
                case 7:
                    p7.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"GeoPreguntas\PreguntaSeleccionada.jpg";
                    break;
                case 8:
                    p8.ImageLocation = Path.GetDirectoryName(Application.StartupPath).Substring(0, Path.GetDirectoryName(Application.StartupPath).Length - 3) + @"GeoPreguntas\PreguntaSeleccionada.jpg";
                    PictureBoxSeleccionado = 0;
                    break;
            }
            PictureBoxSeleccionado++;
        }

        private void MainPreguntas_Load(object sender, EventArgs e)
        {
            P.Add(p1);
            P.Add(p2);
            P.Add(p3);
            P.Add(p4);
            P.Add(p5);
            P.Add(p6);
            P.Add(p7);
            P.Add(p8);
        }

        public int GetRandomNumber(double min, double max)
        {
            rnd = new Random();
            return Convert.ToInt32(rnd.NextDouble() * (max - min) + min);
        }

        public void CargarPreguntas()
        {
            ListaPreguntas = new List<Preguntas>();
            ListaRespuestas = new List<Respuestas>();
            
            Preguntas = new Preguntas(1, 3,"Cuando comenzó el saqueo de América por parte del tirano Cristóbal Colón?",8,10);
            ListaPreguntas.Add(Preguntas);

            Respuestas = new Respuestas(1,"1492",true);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "1412", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "1480", false);
            ListaRespuestas.Add(Respuestas);

            Respuestas = new Respuestas(1, "1500", false);
            ListaRespuestas.Add(Respuestas);
        }

        public void MostrarPregunta()
        {
            tPregunta.Text = ListaPreguntas[0].Descripcion;

            foreach (Respuestas R in ListaRespuestas)
            {
                if (R.PreguntaID == ListaPreguntas[0].ID)
                {
                    lSetRespuestas.Items.Add(R.Descripcion);
                }
            }

            pTiempo.Maximum = ListaPreguntas[0].Tiempo;
            pTiempo.Value = pTiempo.Maximum;
            timerTiempo.Enabled = true;
        }

        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            if(pTiempo.Value>0)
            {
                pTiempo.Value--;
            }
            else
            {
                timerTiempo.Enabled = false;
                MessageBox.Show("Terminó!");
            }
            
        }

        private void bServer_Click(object sender, EventArgs e)
        {
            SocketFiles.SocketServer SS = new SocketFiles.SocketServer();
        }
    }
}
