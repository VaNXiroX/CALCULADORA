namespace CALCULADORA
{
    partial class Resolver_sistemas_de_ecuaciones_lineales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_integracion = new System.Windows.Forms.Button();
            this.btn_derivar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btn_Gauusseidel = new System.Windows.Forms.Button();
            this.dgvVector = new System.Windows.Forms.DataGridView();
            this.lblResultado = new System.Windows.Forms.Label();
            this.numColumns = new System.Windows.Forms.NumericUpDown();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_jacobi = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btn_integracion);
            this.panel3.Controls.Add(this.btn_derivar);
            this.panel3.Controls.Add(this.btn_salir);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 573);
            this.panel3.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 78);
            this.button2.TabIndex = 12;
            this.button2.Text = "Resolver sistemas de ecuaciones lineales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 426);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 51);
            this.button5.TabIndex = 11;
            this.button5.Text = "Derivadas aproximadas ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 78);
            this.button4.TabIndex = 10;
            this.button4.Text = "Resolver sistemas de ecuaciones no lineales";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 59);
            this.button3.TabIndex = 9;
            this.button3.Text = "Encontrar raices";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_integracion
            // 
            this.btn_integracion.Location = new System.Drawing.Point(3, 135);
            this.btn_integracion.Name = "btn_integracion";
            this.btn_integracion.Size = new System.Drawing.Size(104, 34);
            this.btn_integracion.TabIndex = 8;
            this.btn_integracion.Text = "Integracion";
            this.btn_integracion.UseVisualStyleBackColor = true;
            this.btn_integracion.Click += new System.EventHandler(this.btn_integracion_Click);
            // 
            // btn_derivar
            // 
            this.btn_derivar.Location = new System.Drawing.Point(3, 95);
            this.btn_derivar.Name = "btn_derivar";
            this.btn_derivar.Size = new System.Drawing.Size(104, 34);
            this.btn_derivar.TabIndex = 7;
            this.btn_derivar.Text = "Derivar";
            this.btn_derivar.UseVisualStyleBackColor = true;
            this.btn_derivar.Click += new System.EventHandler(this.btn_derivar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_salir.Location = new System.Drawing.Point(-7, 523);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(117, 50);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(111, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(896, 50);
            this.panel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(75, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(713, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resolver sistemas de ecuaciones lineales";
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.AllowUserToDeleteRows = false;
            this.dgvMatriz.AllowUserToResizeColumns = false;
            this.dgvMatriz.AllowUserToResizeRows = false;
            this.dgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatriz.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgvMatriz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatriz.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvMatriz.EnableHeadersVisualStyles = false;
            this.dgvMatriz.Location = new System.Drawing.Point(154, 79);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMatriz.RowHeadersVisible = false;
            this.dgvMatriz.RowHeadersWidth = 51;
            this.dgvMatriz.RowTemplate.Height = 24;
            this.dgvMatriz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvMatriz.Size = new System.Drawing.Size(462, 241);
            this.dgvMatriz.TabIndex = 11;
            // 
            // btn_Gauusseidel
            // 
            this.btn_Gauusseidel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_Gauusseidel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Gauusseidel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Gauusseidel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Gauusseidel.Location = new System.Drawing.Point(721, 369);
            this.btn_Gauusseidel.Name = "btn_Gauusseidel";
            this.btn_Gauusseidel.Size = new System.Drawing.Size(200, 70);
            this.btn_Gauusseidel.TabIndex = 12;
            this.btn_Gauusseidel.Text = "Gauss-seidel";
            this.btn_Gauusseidel.UseVisualStyleBackColor = false;
            this.btn_Gauusseidel.Click += new System.EventHandler(this.btn_gausseidel_Click);
            // 
            // dgvVector
            // 
            this.dgvVector.AllowUserToAddRows = false;
            this.dgvVector.AllowUserToDeleteRows = false;
            this.dgvVector.AllowUserToResizeColumns = false;
            this.dgvVector.AllowUserToResizeRows = false;
            this.dgvVector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVector.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVector.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgvVector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVector.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVector.ColumnHeadersHeight = 29;
            this.dgvVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVector.ColumnHeadersVisible = false;
            this.dgvVector.Location = new System.Drawing.Point(731, 97);
            this.dgvVector.Name = "dgvVector";
            this.dgvVector.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVector.RowHeadersVisible = false;
            this.dgvVector.RowHeadersWidth = 51;
            this.dgvVector.RowTemplate.Height = 24;
            this.dgvVector.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvVector.Size = new System.Drawing.Size(168, 223);
            this.dgvVector.TabIndex = 13;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultado.Location = new System.Drawing.Point(139, 510);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(75, 18);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "Resultado";
            // 
            // numColumns
            // 
            this.numColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numColumns.Location = new System.Drawing.Point(476, 369);
            this.numColumns.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numColumns.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numColumns.Name = "numColumns";
            this.numColumns.Size = new System.Drawing.Size(59, 38);
            this.numColumns.TabIndex = 15;
            this.numColumns.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numRows
            // 
            this.numRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRows.Location = new System.Drawing.Point(271, 369);
            this.numRows.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numRows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(64, 38);
            this.numRows.TabIndex = 16;
            this.numRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(670, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(265, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Filas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(439, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Columnas";
            // 
            // btn_jacobi
            // 
            this.btn_jacobi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_jacobi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_jacobi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_jacobi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_jacobi.Location = new System.Drawing.Point(721, 472);
            this.btn_jacobi.Name = "btn_jacobi";
            this.btn_jacobi.Size = new System.Drawing.Size(200, 70);
            this.btn_jacobi.TabIndex = 20;
            this.btn_jacobi.Text = "Jacobi";
            this.btn_jacobi.UseVisualStyleBackColor = false;
            this.btn_jacobi.Click += new System.EventHandler(this.btn_jacobi_Click);
            // 
            // Resolver_sistemas_de_ecuaciones_lineales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(991, 574);
            this.Controls.Add(this.btn_jacobi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRows);
            this.Controls.Add(this.numColumns);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.dgvVector);
            this.Controls.Add(this.btn_Gauusseidel);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resolver_sistemas_de_ecuaciones_lineales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resolver_sistemas_de_ecuaciones_lineales";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_integracion;
        private System.Windows.Forms.Button btn_derivar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Gauusseidel;
        private System.Windows.Forms.DataGridView dgvVector;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.NumericUpDown numColumns;
        private System.Windows.Forms.NumericUpDown numRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_jacobi;
    }
}