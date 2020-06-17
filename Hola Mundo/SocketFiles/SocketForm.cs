using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_Mundo.SocketFiles
{
    public partial class SocketForm : Form
    {
        //public SocketFiles.SocketClass Sc;
        Point temp = new Point();
        public SocketForm()
        {
            InitializeComponent();
        }

        private void SocketForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Sc = new SocketFiles.SocketClass();
                //Sc.Ss.ExecuteServer();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            MoverRaqueta(ref pRaqueta1, 10);
        }

        public void MoverRaqueta(ref PictureBox raqueta, int Quantity)
        {
            temp.X = raqueta.Location.X;
            temp.Y = raqueta.Location.Y;
            //temp.Y += Quantity;
            temp.Y = Quantity;
            raqueta.Location = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoverRaqueta(ref pRaqueta1, -10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoverRaqueta(ref pRaqueta1, 10);
        }

        private void pRaqueta1_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(MousePosition.Y.ToString());
            //MessageBox.Show(pRaqueta1.Location.Y.ToString());
            MoverRaqueta(ref pRaqueta1, MousePosition.Y);
        }
    }
}
