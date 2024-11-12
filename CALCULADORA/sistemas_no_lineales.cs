using MathNet.Numerics.LinearAlgebra;
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
using Expr = MathNet.Symbolics.Expression;

namespace CALCULADORA
{
    public partial class sistemas_no_lineales : Form
    {
        private List<TextBox> equationTextBoxes = new List<TextBox>();
        public sistemas_no_lineales()
        {
            InitializeComponent();
           
        }

        
        private void btnCalcularnewton_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
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
            integracion.FormClosed += (s, args) => this.Close();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Interpolacion_Click(object sender, EventArgs e)
        {
            Interpolacion interpolacion = new Interpolacion();
            interpolacion.Show();
            this.Hide();
            interpolacion.FormClosed += (s, args) => this.Close();
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

