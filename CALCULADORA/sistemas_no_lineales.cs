using MathNet.Symbolics;
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
    public partial class sistemas_no_lineales : Form
    {
        public sistemas_no_lineales()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        private double[] MetodoJacobi(double[,] A, double[] b, double[] xInicial, int maxIter, double tol)
        {
            int n = b.Length;
            double[] xNuevo = new double[n];
            double[] xAnterior = (double[])xInicial.Clone();

            for (int iter = 0; iter < maxIter; iter++)
            {
                // Iteración de Jacobi
                for (int i = 0; i < n; i++)
                {
                    double suma = 0.0;
                    for (int j = 0; j < n; j++)
                    {
                        if (i != j)
                        {
                            suma += A[i, j] * xAnterior[j];
                        }
                    }
                    xNuevo[i] = (b[i] - suma) / A[i, i];
                }

                // Calcular el error
                double error = 0.0;
                for (int i = 0; i < n; i++)
                {
                    error += Math.Abs(xNuevo[i] - xAnterior[i]);
                }

                // Mostrar los resultados en cada iteración (opcional)
                MostrarResultados(xNuevo, iter + 1, error);

                // Verificar la tolerancia
                if (error < tol)
                {
                    return xNuevo; // Convergencia alcanzada
                }

                // Preparar para la próxima iteración
                Array.Copy(xNuevo, xAnterior, n);
            }

            return xNuevo; // Devuelve el resultado final tras maxIter iteraciones
        }

        // Método para mostrar los resultados en cada iteración
        private void MostrarResultados(double[] x, int iteracion, double error)
        {
            string resultado = $"Iteración {iteracion}: ";
            for (int i = 0; i < x.Length; i++)
            {
                resultado += $"x{i + 1} = {x[i]:F4} ";
            }
            resultado += $"Error: {error:F6}";
            listBoxResultados.Items.Add(resultado);
        }
        private void btnCalcularJacobi_Click(object sender, EventArgs e)
        {
            // Configura aquí tu matriz de coeficientes, términos independientes y valores iniciales
            double[,] A = ObtenerMatrizA();   // Método para extraer la matriz de coeficientes
            double[] b = ObtenerVectorB();     // Método para extraer el vector de términos independientes
            double[] xInicial = ObtenerValoresIniciales(); // Método para extraer el vector inicial

               
            double tol = 1e-6;    // Tolerancia

            listBoxResultados.Items.Clear(); // Limpiar resultados previos
            double[] resultado = MetodoJacobi(A, b, xInicial, int.Parse(maxIter.Text), tol);

            // Mostrar el resultado final
            MostrarResultados(resultado, int.Parse(maxIter.Text), tol);
        }

        private double[,] ObtenerMatrizA()
        {
            double[,] matriz = new double[4, 4];

            if (double.TryParse(txtFuncion.Text, out matriz[0, 0]) &&
                double.TryParse(textBox1.Text, out matriz[0, 1]) &&
                double.TryParse(textBox2.Text, out matriz[0, 2]) &&
                double.TryParse(textBox16.Text, out matriz[0, 3]) &&
                double.TryParse(textBox7.Text, out matriz[1, 0]) &&
                double.TryParse(textBox6.Text, out matriz[1, 1]) &&
                double.TryParse(textBox5.Text, out matriz[1, 2]) &&
                double.TryParse(textBox17.Text, out matriz[1, 3]) &&
                double.TryParse(textBox9.Text, out matriz[2, 0]) &&
                double.TryParse(textBox10.Text, out matriz[2, 1]) &&
                double.TryParse(textBox8.Text, out matriz[2, 2])&&
                double.TryParse(textBox19.Text, out matriz[2, 3])&&
                double.TryParse(textBox12.Text, out matriz[3, 0])&&
                double.TryParse(textBox13.Text, out matriz[3, 1]) &&
                double.TryParse(textBox14.Text, out matriz[3, 2]) &&
                double.TryParse(textBox18.Text, out matriz[3, 3]))
            {
                return matriz;
            }
            else
            {
                
                MessageBox.Show("Por favor, asegúrate de que todos los valores en la matriz de coeficientes sean números válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private double[] ObtenerVectorB()
        {
            double[] vector = new double[4];

            if (double.TryParse(textBox3.Text, out vector[0]) &&
                double.TryParse(textBox4.Text, out vector[1]) &&
                double.TryParse(textBox11.Text, out vector[2])&&
                double.TryParse(textBox15.Text, out vector[3]))
            {
                return vector;
            }
            else
            {
                MessageBox.Show("Por favor, asegúrate de que todos los valores en el vector de términos independientes sean números válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private double[] ObtenerValoresIniciales()
        {
            double[] valoresIniciales = new double[4];

            if (double.TryParse(textBoxX0_1.Text, out valoresIniciales[0]) &&
                double.TryParse(textBoxX0_2.Text, out valoresIniciales[1]) &&
                double.TryParse(textBoxX0_3.Text, out valoresIniciales[2])&&
               double.TryParse(textBox20.Text, out valoresIniciales[2])
                )

            {
                return valoresIniciales;
            }
            else
            {
                MessageBox.Show("Por favor, asegúrate de que todos los valores iniciales sean números válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void sistemas_no_lineales_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resolver_sistemas_de_ecuaciones_lineales resolver_Sistemas_De_Ecuaciones_Lineales = new Resolver_sistemas_de_ecuaciones_lineales();
            resolver_Sistemas_De_Ecuaciones_Lineales.Show();
            this.Hide();
            resolver_Sistemas_De_Ecuaciones_Lineales.FormClosed += (s, args) => this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Encontrar_raices encontrar_Raices = new Encontrar_raices(); 
            encontrar_Raices.Show();
            this.Hide();
            encontrar_Raices.FormClosed += (s, args) => this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_integracion_Click(object sender, EventArgs e)
        {
            Integracion integracion = new Integracion();    
            integracion.Show(); 
            this.Hide();    
            integracion.FormClosed += (s,args) =
        }
    }
 }

