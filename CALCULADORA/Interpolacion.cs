using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Symbolics;

namespace CALCULADORA
{
    public partial class Interpolacion : Form
    {
        
        public Interpolacion()
        {
            InitializeComponent();
        }
       
        private List<(double x, double y)> ParsearPuntos(string input)
        {
            List<(double x, double y)> puntos = new List<(double, double)>();

            // Eliminar espacios y dividir en pares
            input = input.Replace(" ", ""); // Eliminar espacios
            var pares = input.Split(new[] { ')' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var par in pares)
            {
                if (par.StartsWith("("))
                {
                    var coords = par.Trim('(', ')').Split(',');
                    if (coords.Length == 2 &&
                        double.TryParse(coords[0], out double x) &&
                        double.TryParse(coords[1], out double y))
                    {
                        puntos.Add((x, y));
                    }
                    else
                    {
                        throw new FormatException("Formato de punto no válido.");
                    }
                }
            }

            return puntos;
        }

        private void btnLangrage_Click(object sender, EventArgs e)
        {
            string input = txtPuntos.Text;

            List<(double x, double y)> puntos;
            try
            {
                puntos = ParsearPuntos(input);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string polinomio = InterpolacionLagrange(puntos);
            txtResultado.Text = polinomio;
        }

        private string InterpolacionLagrange(List<(double x, double y)> puntos)
        {
            StringBuilder polinomio = new StringBuilder();
            int n = puntos.Count;

            for (int i = 0; i < n; i++)
            {
                double xi = puntos[i].x;
                double yi = puntos[i].y;

                // Empezamos a construir el término del polinomio
                StringBuilder term = new StringBuilder();
                term.Append(yi);

                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        term.Append($" * (x - {puntos[j].x}) / ({xi} - {puntos[j].x})");
                    }
                }

                if (polinomio.Length > 0)
                {
                    polinomio.Append(" + ");
                }
                polinomio.Append($"({term})");
            }

            return polinomio.ToString();
        }
        private string InterpolacionNewton(List<(double x, double y)> puntos)
        
            {
            int n = puntos.Count;
            double[,] coeficientes = new double[n, n];

            // Llenar la primera columna con los valores de y
            for (int i = 0; i < n; i++)
            {
                coeficientes[i, 0] = puntos[i].y;
            }

            // Calcular los coeficientes de diferencias divididas
            for (int j = 1; j < n; j++)
            {
                for (int i = 0; i < n - j; i++)
                {
                    coeficientes[i, j] = (coeficientes[i + 1, j - 1] - coeficientes[i, j - 1]) / (puntos[i + j].x - puntos[i].x);
                }
            }

            StringBuilder polinomio = new StringBuilder();
            polinomio.Append(coeficientes[0, 0]);

            for (int i = 1; i < n; i++)
            {
                StringBuilder term = new StringBuilder();
                term.Append(coeficientes[0, i]);

                for (int j = 0; j < i; j++)
                {
                    term.Append($" * (x - {puntos[j].x})");
                }

                if (polinomio.Length > 0)
                {
                    polinomio.Append(" + ");
                }
                polinomio.Append($"({term})");
            }

            return polinomio.ToString();
        }   
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularNewton_Click(object sender, EventArgs e)
        {
            string input = txtPuntos.Text;

            List<(double x, double y)> puntos;
            try
            {
                puntos = ParsearPuntos(input);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string polinomio = InterpolacionNewton(puntos);
            txtResultado.Text = polinomio;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diferenciacion diferenciacion = new Diferenciacion();
            diferenciacion.Show();
            this.Hide();
            diferenciacion.FormClosed += (s, args) => this.Close();
        }
    }



}
