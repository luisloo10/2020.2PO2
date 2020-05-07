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

    public partial class Form1 : Form
    {
        Automovil Auto;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tLlantas.Focus();
        }

        private void bHola_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try 
            {
                Auto = new Automovil(Convert.ToInt16(tLlantas.Value), tColor.Text, Convert.ToInt16(tPuertas.Text),
                                Convert.ToInt16(tAño.Text), tMarca.Text, tModelo.Text, Convert.ToInt16(tCilindraje.Text),tTransmision.Text);

                gDatos.Rows.Add(gDatos.Rows.Count, Auto.Llantas, Auto.Color, Auto.Puertas, Auto.Year, Auto.Marca, Auto.Modelo, Auto.Cilindraje, Auto.Transmision);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpiar()
        {
            tLlantas.Value = 0;
            tColor.Clear();
            tPuertas.Clear();
            tAño.Clear();
            tMarca.Clear();
            tModelo.Clear();
            tCilindraje.Clear();
            tTransmision.Clear();
        }

        private void bOperaciones_Click(object sender, EventArgs e)
        {
            try
            {
                fOperaciones F = new fOperaciones();
                F.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
