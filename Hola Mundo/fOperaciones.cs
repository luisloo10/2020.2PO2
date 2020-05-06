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
            Operaciones Op = new Operaciones();
            Suma Sm = new Suma();
            
        }
    }
}
