using System;
using System.Windows.Forms;
using Expr = MathNet.Symbolics.SymbolicExpression;


namespace CALCULADORA
{
    //private System.Windows.Forms.TextBox txtFuncion;
    //private Panel panelTeclado;

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InicializarTeclado();
            CrearTecladoMatematico();
        }

        private void CrearTecladoMatematico()
        {
            
            string[] simbolos = { "sin(x)", "cos(x)", "tan(x)", "log", "sqrt()", "π", "e", "+", "-", "*", "/", "^", "(", ")"};

           
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
        private void InicializarTeclado()
        {
            
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

       
        private void btn_integracion_Click(object sender, EventArgs e)
        {
            Integracion integracion = new Integracion();
            integracion.Show(); // Mostrar el nuevo formulario
            this.Hide();
            integracion.FormClosed += (s, args) => this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Encontrar_raices encontrar_raices = new Encontrar_raices();
            encontrar_raices.Show();
            this.Hide();
            encontrar_raices.FormClosed += (s, args) => this.Close();

        }
        private void txtFuncion_TextChanged(object sender, EventArgs e)
        {
            txtFuncion.SelectionStart = txtFuncion.Text.Length;
            txtFuncion.ScrollToCaret();
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
        private void panelTeclado_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
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




