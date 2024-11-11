using System;
using System.Windows.Forms;
using Expr = MathNet.Symbolics.SymbolicExpression;
using MathNet.Symbolics;
using System.Linq.Expressions;
using MathNet.Numerics.Integration;
using System.Net.Http;
using System.Threading.Tasks;

namespace CALCULADORA
{
    public partial class Integracion : Form
    {
        
        public Integracion()
        {
            InitializeComponent();
            CrearTecladoMatematico();
           
        }
        private string ProcesarFuncion(string funcion)
        {
            // Usa expresiones regulares para insertar un * entre un número y una variable.
            // Esto cubrirá casos como "2x" o "3xy" convirtiéndolos en "2*x" o "3*x*y".
            string procesada = System.Text.RegularExpressions.Regex.Replace(funcion, @"(\d)([a-zA-Z])", "$1*$2");
            return procesada;


        }
      
        private void txtFuncion_TextChanged(object sender, EventArgs e)
        {
            txtFuncion.SelectionStart = txtFuncion.Text.Length;
            txtFuncion.ScrollToCaret();
        }

        private void CrearTecladoMatematico()
        {

            // Definir los símbolos y funciones matemáticas para el teclado
            string[] simbolos = { "sin(x)", "cos(x)", "tan(x)", "log", "sqrt()", "π", "e", "+", "-", "*", "/", "^", "(", ")","x"};

            // Crear y organizar los botones en una cuadrícula dentro del panel
            int columnas = 5; // Número de columnas
            int x = 1, y = 5; // Posiciones iniciales para el primer botón , 220, 410

            for (int i = 0; i < simbolos.Length; i++)
            {
                // Crear un nuevo botón para cada símbolo
                System.Windows.Forms.Button boton = new System.Windows.Forms.Button();
                boton.Text = simbolos[i];
                boton.Width = 50;
                boton.Height = 40;
                boton.Tag = "funcion";
                boton.Location = new System.Drawing.Point(x, y);

                // Asignar el evento Click al botón
                boton.Click += ButtonFuncion_Click;

                // Agregar el botón al panel
                panelTeclado.Controls.Add(boton);

                // Actualizar posición para el siguiente botón en la cuadrícula
                x += boton.Width + 5; // 5 píxeles de espacio entre botones
                if ((i + 1) % columnas == 0) // Nueva fila después de cierto número de columnas
                {
                    x = 0;
                    y += boton.Height + 5;
                }
            }
        }

        private void btn_Integrar_Click(object sender, EventArgs e)
        {
            try
            {
                
             

                // Leer los límites y el número de intervalos
                double limiteInferior = double.Parse(txtLimiteInferior.Text);
                double limiteSuperior = double.Parse(txtLimiteSuperior.Text);
                int numIntervalos = int.Parse(txtNumIntervalos.Text);

                // Validar que el número de intervalos sea par
                if (numIntervalos % 2 != 0)
                {
                    label2.Text = "El número de intervalos debe ser par.";
                    return;
                }

                // Definir la función a integrar (puedes cambiar la función según desees)
                Func<double, double> funcion = x => Math.Pow(x, 2); // Ejemplo: f(x) = x^2

                // Calcular la integral usando el método de Simpson
                double resultado = MetodoSimpson(funcion, limiteInferior, limiteSuperior, numIntervalos);
                  
                // Mostrar el resultado
                txtResultado.Text = $"{resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la integral: " + ex.Message);
            }

            
        }


        private double MetodoSimpson(Func<double, double> f, double a, double b, int n)
        {
            // Tamaño de cada subintervalo
            double h = (b - a) / n;

            // Calcular los términos de Simpson
            double suma = f(a) + f(b);

            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                suma += (i % 2 == 0 ? 2 : 4) * f(x); // Alterna entre 4 y 2
            }

            // Aplicar el factor (h / 3)
            return suma * h / 3;
        }

        private double MetodoTrapecio(Func<double, double> f, double a, double b, int n)
        {
            // Tamaño de cada subintervalo
            double h = (b - a) / n;

            // Calcular la suma de las áreas de los trapecios
            double suma = f(a) + f(b);

            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                suma += 2 * f(x); // Sumar los valores de los puntos intermedios
            }
          
            // Aplicar el factor h / 2
            return suma * h / 2;
        }

        private void ButtonFuncion_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button != null)
            {
                txtFuncion.Text += button.Text; // Agrega el texto del botón al TextBox
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); 
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Encontrar_raices encontrar_raices = new Encontrar_raices();
            encontrar_raices.Show();
            this.Hide();
            encontrar_raices.FormClosed += (s, args) => this.Close();
        }

        private void btn_trapecio_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los límites y el número de intervalos
                double limiteInferior = double.Parse(txtLimiteInferior.Text);
                double limiteSuperior = double.Parse(txtLimiteSuperior.Text);
                int numIntervalos = int.Parse(txtNumIntervalos.Text);

                // Validar que el número de intervalos sea positivo
                if (numIntervalos <= 0)
                {
                    label2.Text = "El número de intervalos debe ser mayor que 0.";
                    return;
                }

                // Definir la función a integrar (puedes cambiar la función según desees)
                Func<double, double> funcion = x => Math.Pow(x, 2); // Ejemplo: f(x) = x^2

                // Calcular la integral usando el método del Trapecio
                double resultado = MetodoTrapecio(funcion, limiteInferior, limiteSuperior, numIntervalos);

                // Mostrar el resultado
                txtResultado.Text = $"{resultado}";
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
        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
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
    }
}

