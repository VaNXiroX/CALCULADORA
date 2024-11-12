using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.RootFinding;

namespace CALCULADORA
{
    public partial class Encontrar_raices : Form
    {
        public Encontrar_raices()
        {
            InitializeComponent(); CrearTecladoMatematico();
        }

        
        private void btn_integracion_Click(object sender, EventArgs e)
        {
            Integracion integracion = new Integracion();
            integracion.Show(); 
            this.Hide();
            integracion.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
        }


        private void CrearTecladoMatematico()
        {

            string[] simbolos = {  "sqrt()", "π", "e", "+", "-", "*", "/", "^", "(", ")","x", "x^2","x^3","x^4"};


            int columnas = 5;
            int x = 1, y = 5;

            for (int i = 0; i < simbolos.Length; i++)
            {

                System.Windows.Forms.Button boton = new System.Windows.Forms.Button();
                boton.Text = simbolos[i];
                boton.Width = 50;
                boton.Height = 40;
                boton.Tag = "funcion";
                boton.Location = new System.Drawing.Point(x, y);

                boton.Click += ButtonFuncion_Click;

                panelTeclado.Controls.Add(boton);

                x += boton.Width + 5;
                if ((i + 1) % columnas == 0)
                {
                    x = 0;
                    y += boton.Height + 5;
                }
            }
        }

        private void ButtonFuncion_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button != null)
            {
                txtFuncion.Text += button.Text;
            }
        }

        private void btn_newtonraphson_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer la función y el valor inicial desde los TextBox
                string funcion = txtFuncion.Text;
                double x0 = Convert.ToDouble(txtX0.Text);
                double tolerancia = 1e-6; // Tolerancia para la convergencia
                double x1;
                int maxIteraciones = 1000; // Número máximo de iteraciones

                for (int i = 0; i < maxIteraciones; i++)
                {
                    double fx0 = EvaluarFuncion(funcion, x0);
                    double dfx0 = EvaluarDerivada(funcion, x0);

                    if (dfx0 == 0)
                    {
                        txtResultado.Text = "La derivada es cero. No se puede continuar.";
                        return;
                    }

                    // Método de Newton-Raphson
                    x1 = x0 - fx0 / dfx0;

                    // Verificar la convergencia
                    if (Math.Abs(x1 - x0) < tolerancia)
                    {
                        txtResultado.Text = $"Raíz encontrada: {x1}";
                        return;
                    }

                    x0 = x1;
                }
            }
            catch (Exception ex)
            {
                txtResultado.Text = $"Error: {ex.Message}";
            }
            txtResultado.Text = "No se encontró la raíz en el número máximo de iteraciones.";
        }

        private double EvaluarFuncion(string funcion, double x)
        {
            // Reemplazar 'x' por el valor actual y evaluar la función
            var expression = funcion.Replace("x", x.ToString());
            var result = new DataTable().Compute(expression, null);
            return Convert.ToDouble(result);
        }
        private double EvaluarDerivada(string funcion, double x)
        {
            // Usar un pequeño incremento para aproximar la derivada
            double h = 1e-6;
            double fxh = EvaluarFuncion(funcion, x + h);
            double fx = EvaluarFuncion(funcion, x);
            return (fxh - fx) / h;
        }


        private void btn_biseccion_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el valor de inicio de la raíz desde el TextBox
                double x0 = double.Parse(txtX0.Text);

                // Definir la función cuya raíz queremos encontrar
                Func<double, double> funcion = x => x * x - 4; // Ejemplo: f(x) = x^2 - 4

                // Calcular la raíz usando el método de Newton-Raphson
                double raiz = Bisection.FindRoot(funcion, -3.0, 3.0, 1e-6);

                // Mostrar el resultado en el Label
                txtResultado.Text = $"Raíz encontrada: {raiz:F4}";
            }
            catch (Exception ex)
            {
                txtResultado.Text = $"Error: {ex.Message}";
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEstimacionInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sistemas_no_lineales sistemas_No_Lineales = new sistemas_no_lineales();
            sistemas_No_Lineales.Show();
            this.Hide();
            sistemas_No_Lineales.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resolver_sistemas_de_ecuaciones_lineales resolver_Sistemas_De_Ecuaciones_Lineales = new Resolver_sistemas_de_ecuaciones_lineales();
            resolver_Sistemas_De_Ecuaciones_Lineales.Show();
            this.Hide();
            resolver_Sistemas_De_Ecuaciones_Lineales.FormClosed += (s, args) => this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Interpolacion interpolacion = new Interpolacion();
            interpolacion.Show();
            this.Hide();
            interpolacion.FormClosed += (s, args) => this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Diferenciacion diferenciacion = new Diferenciacion();
            diferenciacion.Show();
            this.Hide();
            diferenciacion.FormClosed += (s, args) => this.Close();
        }
    }

}
