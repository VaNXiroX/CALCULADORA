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
    public partial class Resolver_sistemas_de_ecuaciones_lineales : Form
    {
        public Resolver_sistemas_de_ecuaciones_lineales()
        {
            InitializeComponent();

            // Configura el evento ValueChanged para ambos NumericUpDown
            numColumns.ValueChanged += new EventHandler(ActualizarDataGridView);
            numRows.ValueChanged += new EventHandler(ActualizarDataGridView);

            // Establece valores iniciales para el tamaño del DataGridView
            numColumns.Value = 3;
            numRows.Value = 3;
            ActualizarDataGridView(null, null);
        }
        private void ActualizarDataGridView(object sender, EventArgs e)
        {
            int columnas = (int)numColumns.Value;
            int filas = (int)numRows.Value;

            columnas = Math.Min(columnas, 6);
            filas = Math.Min(filas, 9);

            // Configura el número de columnas del DataGridView
            dgvMatriz.ColumnCount = columnas;
            for (int i = 0; i < columnas; i++)
            {
                dgvMatriz.Columns[i].Name = $"x^{i + 1}";
                dgvMatriz.Columns[i].Width = 60;
            }

            // Configura el número de filas del DataGridView
            dgvMatriz.RowCount = filas;
            dgvVector.RowCount = filas;

            // Opcional: nombra filas en ambos DataGridView
            for (int i = 0; i < filas; i++)
            {
                dgvMatriz.Rows[i].HeaderCell.Value = $"Ecuación {i + 1}";
                dgvVector.Rows[i].HeaderCell.Value = $"Ecuación {i + 1}";
            }

            // Ajuste automático del tamaño de las celdas
            dgvMatriz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVector.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resolver_sistemas_de_ecuaciones_lineales resolver_Sistemas_De_Ecuaciones_Lineales = new Resolver_sistemas_de_ecuaciones_lineales();
            resolver_Sistemas_De_Ecuaciones_Lineales.Show();
            this.Hide();
            resolver_Sistemas_De_Ecuaciones_Lineales.FormClosed += (s, args) => this.Close();
        }

        private void btn_gausseidel_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer matriz de coeficientes y vector de términos independientes
                double[,] matriz = LeerMatriz();
                double[] vector = LeerVector();

                // Verificar si la matriz es diagonalmente dominante
                if (!EsDiagonalmenteDominante(matriz))
                {
                    MessageBox.Show("La matriz no es diagonalmente dominante. Esto puede causar que el método no converja.");
                    return;
                }

                // Valores iniciales
                double[] solucionInicial = new double[vector.Length];

                // Ejecutar el método de Gauss-Seidel
                var resultado = MetodoGaussSeidel(matriz, vector, solucionInicial, maxIter: 100, tol: 1e-4);

                // Mostrar resultados
                lblResultado.Text = $"Soluciones: {string.Join(", ", resultado)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double[] MetodoGaussSeidel(double[,] matriz, double[] vector, double[] solucionInicial, int maxIter = 100, double tol = 1e-6)
        {
            int n = vector.Length;
            double[] x = (double[])solucionInicial.Clone();

            for (int iter = 0; iter < maxIter; iter++)
            {
                double[] x_old = (double[])x.Clone();
                for (int i = 0; i < n; i++)
                {
                    double suma = vector[i];
                    for (int j = 0; j < n; j++)
                    {
                        if (j != i)
                            suma -= matriz[i, j] * x[j];
                    }
                    x[i] = suma / matriz[i, i];

                    // Verificar convergencia
                    if (Math.Abs(x[i] - x_old[i]) < tol)
                        return x;
                }
            }

            throw new Exception("No converge en las iteraciones dadas");
        }


        private double[,] LeerMatriz()
        {
            int filas = dgvMatriz.RowCount;
            int columnas = dgvMatriz.ColumnCount;
            double[,] matriz = new double[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (dgvMatriz[j, i].Value == null || !double.TryParse(dgvMatriz[j, i].Value.ToString(), out matriz[i, j]))
                    {
                        throw new Exception($"Valor inválido en la celda ({i + 1},{j + 1}). Asegúrate de que todas las celdas contienen valores numéricos.");
                    }
                }
            }

            return matriz;
        }

        private double[] LeerVector()
        {
            int filas = dgvVector.RowCount;
            double[] vector = new double[filas];

            for (int i = 0; i < filas; i++)
            {
                if (dgvVector[0, i].Value == null || !double.TryParse(dgvVector[0, i].Value.ToString(), out vector[i]))
                {
                    throw new Exception($"Valor inválido en el vector en la fila {i + 1}. Asegúrate de que todas las celdas contienen valores numéricos.");
                }
            }

            return vector;
        }

        private bool EsDiagonalmenteDominante(double[,] matriz)
        {
            int n = matriz.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                double sumaFila = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                        sumaFila += Math.Abs(matriz[i, j]);
                }
                if (Math.Abs(matriz[i, i]) < sumaFila)
                    return false;
            }
            return true;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btn_jacobi_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer la matriz de coeficientes y el vector de términos independientes
                double[,] matriz = LeerMatriz();
                double[] vector = LeerVector();

                // Valores iniciales (puedes poner valores arbitrarios o ceros)
                double[] solucion = new double[vector.Length];
                double[] solucionAnterior = new double[vector.Length];

                // Parámetros de iteración
                int maxIter = 100; // Máximo número de iteraciones
                double tolerancia = 1e-6; // Tolerancia para la convergencia

                // Método de Jacobi
                for (int iter = 0; iter < maxIter; iter++)
                {
                    // Copiar la solución anterior
                    Array.Copy(solucion, solucionAnterior, solucion.Length);

                    // Realizar la iteración de Jacobi
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        double suma = 0;
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            if (i != j) // Excluir el término de la diagonal
                            {
                                suma += matriz[i, j] * solucionAnterior[j];
                            }
                        }
                        solucion[i] = (vector[i] - suma) / matriz[i, i];
                    }

                    // Verificar si la solución ha convergido
                    bool convergencia = true;
                    for (int i = 0; i < solucion.Length; i++)
                    {
                        if (Math.Abs(solucion[i] - solucionAnterior[i]) > tolerancia)
                        {
                            convergencia = false;
                            break;
                        }
                    }

                    if (convergencia)
                    {
                        break; // Si la solución ha convergido, salimos del bucle
                    }
                }

                // Mostrar el resultado
                lblResultado.Text = $"Soluciones: {string.Join("  ,   ", solucion)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_derivar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
        }

        private void btn_integracion_Click(object sender, EventArgs e)
        {
            Integracion integracion = new Integracion();
            integracion.Show();
            this.Hide();
            integracion.FormClosed += (s, args) => this.Close();
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
            sistemas_no_lineales Sistemas_No_Lineales = new sistemas_no_lineales();
            Sistemas_No_Lineales.Show();
            this.Hide();
            Sistemas_No_Lineales.FormClosed += (s, args) => this.Close();
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
