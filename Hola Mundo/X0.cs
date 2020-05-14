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

namespace Hola_Mundo
{
    public partial class X0 : Form
    {
        int turno=0;
        public X0()
        {
            InitializeComponent();
        }

        private void p1_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref p1);
        }

        public void PictureBoxChangeValue(ref PictureBox P)
        {
            if(turno==0)
            {
                P.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\bin\Debug\0.jpg";
                turno = 1;
            }
            else
            {
                P.ImageLocation = @"C:\Users\luisl\Source\Repos\2020.2PO2\Hola Mundo\bin\Debug\X.jpg";
                turno = 0;
            }
            //P.ImageLocation = Path.GetDirectoryName(Application.ExecutablePath) + "\0.jpg";
            //MessageBox.Show(P.ImageLocation);
        }

        private void X0_Load(object sender, EventArgs e)
        {
            
            //MessageBox.Show(Path.GetDirectoryName(Application.ExecutablePath));
            
        }

        private void p2_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref p2);
        }

        private void p3_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref p3);
        }

        private void p4_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref p4);
        }

        private void p5_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref p5);
        }

        private void p6_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref p6);
        }

        private void p7_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref p7);
        }

        private void p8_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref p8);
        }

        private void p9_Click(object sender, EventArgs e)
        {
            PictureBoxChangeValue(ref p9);
        }
    }
}
