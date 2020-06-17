using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace Hola_Mundo.Practica_2
{
    
    public partial class TrafficCity : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "eFZpfupJzOeui3fRoilpgCXnpDaPv4djfI5qa0it",
            BasePath = "https://helloworld-f4153.firebaseio.com/"
        };

        int Status = 0;
        Lights L;

        int TimeRed, TimeYellow, TimeGreen;
        public TrafficCity()
        {
            InitializeComponent();
        }

        

        private void TrafficCity_Load(object sender, EventArgs e)
        {
            L = new Lights();
            TimeRed = 5;
            TimeYellow = 1;
            TimeGreen = 2;

            IFirebaseClient client;

            client = new FireSharp.FirebaseClient(config);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //var firebase = new FirebaseClient("https://dinosaur-facts.firebaseio.com/");
                var firebase = new FirebaseClient("https://console.firebase.google.com/proyecto/loo-express-1559099185634");

                var Tr = firebase.Child("Traffic")
                    .OrderByKey();
                MessageBox.Show(Tr.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            try
            {
                switch(Status)
                {
                    case 0:
                        L.Red(ref p1, ref p2, ref p3);
                        TimeRed--;
                        if (TimeRed == 0)
                        {
                            Status = 1;
                        }
                        break;

                    case 1:
                        L.Yellow(ref p1, ref p2, ref p3);
                        TimeYellow--;
                        if (TimeYellow == 0)
                        {
                            Status = 2;
                        }
                        break;

                    case 2:
                        L.Green(ref p1, ref p2, ref p3);
                        TimeGreen--;
                        if (TimeGreen == 0)
                        {
                            Status = 3;
                        }
                        break;
                    case 3:
                        TimeRed = 5;
                        TimeYellow = 1;
                        TimeGreen = 2;
                        Status = 0;
                        break;
                }
            }catch(Exception ex)
            {
                Temporizador.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            Temporizador.Enabled = true;
        }
    }

    public class Lights
    {
        public void Red(ref PictureBox P1, ref PictureBox P2, ref PictureBox P3)
        {
            P1.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\Practica 2\Lights\Red.jpg";
            P2.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\Practica 2\Lights\White.jpg";
            P3.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\Practica 2\Lights\White.jpg";
        }

        public void Yellow(ref PictureBox P1, ref PictureBox P2, ref PictureBox P3)
        {
            P1.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\Practica 2\Lights\White.jpg";
            P2.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\Practica 2\Lights\Yellow.jpg";
            P3.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\Practica 2\Lights\White.jpg";
        }

        public void Green(ref PictureBox P1, ref PictureBox P2, ref PictureBox P3)
        {
            P1.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\Practica 2\Lights\White.jpg";
            P2.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\Practica 2\Lights\White.jpg";
            P3.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\Practica 2\Lights\Green.jpg";
        }
    }
}
