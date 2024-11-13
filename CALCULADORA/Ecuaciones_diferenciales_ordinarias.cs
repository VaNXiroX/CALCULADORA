using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Ecuaciones_diferenciales_ordinarias : Form
    {
        public Ecuaciones_diferenciales_ordinarias()
        {
            InitializeComponent();
        }

        private void btn_Taylor_Click(object sender, EventArgs e)
        {
            try
            {
                string function = textBox1.Text;
                double expansionPoint = double.Parse(textBox2.Text);
                int order = int.Parse(textBox3.Text);

                if (order < 0 || order > 20)
                {
                    MessageBox.Show("El orden debe ser un número entero entre 0 y 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string taylorSeries = CalculateTaylorSeries(function, expansionPoint, order);
                MessageBox.Show("La serie de Taylor es:\n\n" + taylorSeries, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}
