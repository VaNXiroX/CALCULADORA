namespace CALCULADORA
{
    partial class sistemas_no_lineales
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
            this.button1 = new System.Windows.Forms.Button();
            this.Interpolacion = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_integracion = new System.Windows.Forms.Button();
            this.btn_derivar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.Resultados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcularNewton = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtValoresIniciales = new System.Windows.Forms.TextBox();
            this.panelTextBoxes = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Interpolacion);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btn_integracion);
            this.panel3.Controls.Add(this.btn_derivar);
            this.panel3.Controls.Add(this.btn_salir);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 616);
            this.panel3.TabIndex = 8;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "Derivadas aproximadas ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Interpolacion
            // 
            this.Interpolacion.Location = new System.Drawing.Point(3, 408);
            this.Interpolacion.Name = "Interpolacion";
            this.Interpolacion.Size = new System.Drawing.Size(104, 51);
            this.Interpolacion.TabIndex = 11;
            this.Interpolacion.Text = "Interpolacion";
            this.Interpolacion.UseVisualStyleBackColor = true;
            this.Interpolacion.Click += new System.EventHandler(this.Interpolacion_Click);
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
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_salir.Location = new System.Drawing.Point(-7, 566);
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
            this.panel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(75, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(765, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resolver sistemas de ecuaciones no lineales";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResultados);
            this.panel1.Controls.Add(this.Resultados);
            this.panel1.Location = new System.Drawing.Point(132, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 220);
            this.panel1.TabIndex = 10;
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(30, 85);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(740, 114);
            this.txtResultados.TabIndex = 9;
            // 
            // Resultados
            // 
            this.Resultados.AutoSize = true;
            this.Resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Resultados.Location = new System.Drawing.Point(334, 38);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(143, 32);
            this.Resultados.TabIndex = 8;
            this.Resultados.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(318, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sistema";
            // 
            // btnCalcularNewton
            // 
            this.btnCalcularNewton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCalcularNewton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalcularNewton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularNewton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularNewton.Location = new System.Drawing.Point(664, 108);
            this.btnCalcularNewton.Name = "btnCalcularNewton";
            this.btnCalcularNewton.Size = new System.Drawing.Size(216, 70);
            this.btnCalcularNewton.TabIndex = 1;
            this.btnCalcularNewton.Text = "Calcular Newton";
            this.btnCalcularNewton.UseVisualStyleBackColor = false;
            this.btnCalcularNewton.Click += new System.EventHandler(this.btnCalcularnewton_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(667, 202);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(222, 32);
            this.label24.TabIndex = 57;
            this.label24.Text = "Valores iniciales";
            // 
            // txtValoresIniciales
            // 
            this.txtValoresIniciales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValoresIniciales.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValoresIniciales.Location = new System.Drawing.Point(664, 245);
            this.txtValoresIniciales.Multiline = true;
            this.txtValoresIniciales.Name = "txtValoresIniciales";
            this.txtValoresIniciales.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtValoresIniciales.Size = new System.Drawing.Size(219, 34);
            this.txtValoresIniciales.TabIndex = 59;
            // 
            // panelTextBoxes
            // 
            this.panelTextBoxes.Location = new System.Drawing.Point(977, 58);
            this.panelTextBoxes.Name = "panelTextBoxes";
            this.panelTextBoxes.Size = new System.Drawing.Size(30, 560);
            this.panelTextBoxes.TabIndex = 70;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(141, 108);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(468, 23);
            this.textBox2.TabIndex = 71;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(141, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(468, 23);
            this.textBox1.TabIndex = 72;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(141, 138);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox3.Size = new System.Drawing.Size(468, 23);
            this.textBox3.TabIndex = 72;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(141, 167);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox4.Size = new System.Drawing.Size(468, 23);
            this.textBox4.TabIndex = 72;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(141, 196);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox5.Size = new System.Drawing.Size(468, 23);
            this.textBox5.TabIndex = 73;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(141, 256);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox6.Size = new System.Drawing.Size(468, 23);
            this.textBox6.TabIndex = 74;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(141, 285);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox7.Size = new System.Drawing.Size(468, 23);
            this.textBox7.TabIndex = 75;
            // 
            // sistemas_no_lineales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1009, 621);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtValoresIniciales);
            this.Controls.Add(this.panelTextBoxes);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.btnCalcularNewton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sistemas_no_lineales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sistemas_no_lineales";
            this.Load += new System.EventHandler(this.sistemas_no_lineales_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Interpolacion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_integracion;
        private System.Windows.Forms.Button btn_derivar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Resultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcularNewton;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtValoresIniciales;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Panel panelTextBoxes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
    }
}