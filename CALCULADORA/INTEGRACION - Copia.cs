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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Expr = MathNet.Symbolics.SymbolicExpression;


namespace CALCULADORA
{
    //private System.Windows.Forms.TextBox txtFuncion;
    //private Panel panelTeclado;

    public partial class Form1 : Form
    {

        private void txtFuncion_TextChanged(object sender, EventArgs e)
        {
            txtFuncion.SelectionStart = txtFuncion.Text.Length;
            txtFuncion.ScrollToCaret();
        }

        public Form1()
        {
            InitializeComponent();
            InicializarTeclado();
            CrearTecladoMatematico();
        }

        private void CrearTecladoMatematico()
        {
            // Crear el TextBox donde se mostrará la función
      
 

            // Crear el Panel para contener los botones
           

            // Definir los símbolos y funciones matemáticas para el teclado
            string[] simbolos = { "sin(x)", "cos(x)", "tan(x)", "log", "sqrt()", "π", "e", "+", "-", "*", "/", "^", "(", ")", "∫" };

            // Crear y organizar los botones en una cuadrícula dentro del panel
            int columnas = 5; // Número de columnas
            int x = 1, y = 5; // Posiciones iniciales para el primer botón , 220, 410

            for (int i = 0; i < simbolos.Length; i++)
            {
                // Crear un nuevo botón para cada símbolo
                System.Windows.Forms.Button boton = new System.Windows.Forms.Button ();
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
        private void ButtonFuncion_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button != null)
            {
                txtFuncion.Text += button.Text; // Agrega el texto del botón al TextBox
            }
        }
        private void InicializarTeclado()
        {
            // Agregar evento Click a todos los botones de funciones
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.Button && control.Tag?.ToString() == "funcion")
                {
                    control.Click += button29_Click;
                }
            }
        }
      
        private string ProcesarFuncion(string funcion)
        {
            // Usa expresiones regulares para insertar un * entre un número y una variable.
            // Esto cubrirá casos como "2x" o "3xy" convirtiéndolos en "2*x" o "3*x*y".
            string procesada = System.Text.RegularExpressions.Regex.Replace(funcion, @"(\d)([a-zA-Z])", "$1*$2");
            return procesada;


        }
        private string ProcesarResultado(string funcion)
        {
            // Usa expresiones regulares para insertar un * entre un número y una variable.
            // Esto cubrirá casos como "2x" o "3xy" convirtiéndolos en "2*x" o "3*x*y".
            string procesadafinal = System.Text.RegularExpressions.Regex.Replace(funcion, @"(\d)([a-zA-Z])", "$1*$2");
            return procesadafinal;


        }

        private void btn_derivar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la función ingresada
                string funcion = txtFuncion.Text;
                string funcionProcesada = ProcesarFuncion(funcion);
                

                // Convertir la función a una expresión simbólica
                Expr expr = Expr.Parse(funcionProcesada);

                // Derivar la función respecto a 'x'
                Expr derivada = expr.Differentiate("x").Expand();

                string Procesarfuncionfinal = ProcesarResultado(derivada.ToString());
                // Mostrar el resultado en el segundo TextBox
              
                

                txtResultado.Text = Procesarfuncionfinal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el cálculo: " + ex.Message);
            }

            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void button29_Click(object sender, EventArgs e)
        {
            
        }

       
    }


    

    }

  


