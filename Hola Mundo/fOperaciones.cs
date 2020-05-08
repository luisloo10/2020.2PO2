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
        Sumax5 SumPor5;

        public fOperaciones()
        {
            InitializeComponent();
        }

        private void fOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
