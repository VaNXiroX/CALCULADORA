namespace CALCULADORA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_derivar = new System.Windows.Forms.Button();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_integracion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.panelTeclado = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_derivar
            // 
            this.btn_derivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_derivar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_derivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_derivar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_derivar.Location = new System.Drawing.Point(676, 287);
            this.btn_derivar.Name = "btn_derivar";
            this.btn_derivar.Size = new System.Drawing.Size(200, 70);
            this.btn_derivar.TabIndex = 0;
            this.btn_derivar.Text = "derivar";
            this.btn_derivar.UseVisualStyleBackColor = false;
            this.btn_derivar.Click += new System.EventHandler(this.btn_derivar_Click);
            // 
            // txtFuncion
            // 
            this.txtFuncion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFuncion.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncion.Location = new System.Drawing.Point(222, 168);
            this.txtFuncion.Multiline = true;
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtFuncion.Size = new System.Drawing.Size(318, 34);
            this.txtFuncion.TabIndex = 2;
            this.txtFuncion.TextChanged += new System.EventHandler(this.txtFuncion_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btn_integracion);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_salir);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 616);
            this.panel3.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 51);
            this.button5.TabIndex = 11;
            this.button5.Text = "Derivadas aproximadas ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 78);
            this.button4.TabIndex = 10;
            this.button4.TabStop = false;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Derivar";
            this.button1.UseVisualStyleBackColor = true;
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
            this.panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(353, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Derivacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(318, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Funcion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 24);
            this.button6.TabIndex = 0;
            this.button6.Text = "1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(66, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 24);
            this.button7.TabIndex = 1;
            this.button7.Text = "2";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(112, 25);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(31, 24);
            this.button8.TabIndex = 2;
            this.button8.Text = "3";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(17, 68);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(31, 24);
            this.button9.TabIndex = 3;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(66, 68);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(31, 24);
            this.button10.TabIndex = 4;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(112, 68);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(31, 24);
            this.button11.TabIndex = 5;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(17, 110);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(31, 24);
            this.button12.TabIndex = 6;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(66, 110);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(31, 24);
            this.button13.TabIndex = 7;
            this.button13.Text = "8";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(112, 110);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(31, 24);
            this.button14.TabIndex = 8;
            this.button14.Text = "9";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(191, 25);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(31, 24);
            this.button15.TabIndex = 9;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(191, 68);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(31, 24);
            this.button16.TabIndex = 10;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(191, 110);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(31, 24);
            this.button17.TabIndex = 11;
            this.button17.Text = "/";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(191, 150);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(31, 24);
            this.button18.TabIndex = 12;
            this.button18.Text = "x";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(17, 150);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(60, 24);
            this.button19.TabIndex = 13;
            this.button19.Text = "sin(x)";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(83, 150);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(64, 24);
            this.button20.TabIndex = 14;
            this.button20.Text = "cos(x)";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(17, 180);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(60, 24);
            this.button21.TabIndex = 15;
            this.button21.Text = "tan(x)";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(83, 180);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(65, 24);
            this.button22.TabIndex = 16;
            this.button22.Text = "log";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(246, 110);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(31, 24);
            this.button23.TabIndex = 17;
            this.button23.Text = "√ ";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(246, 25);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(31, 24);
            this.button24.TabIndex = 18;
            this.button24.Text = "π ";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(246, 68);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(31, 24);
            this.button25.TabIndex = 19;
            this.button25.Text = "e";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(191, 180);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(31, 24);
            this.button26.TabIndex = 20;
            this.button26.Text = "(";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(246, 180);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(31, 24);
            this.button27.TabIndex = 21;
            this.button27.Text = ")";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(112, 210);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(82, 26);
            this.button28.TabIndex = 22;
            this.button28.Text = "Limpiar";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // panelTeclado
            // 
            this.panelTeclado.BackColor = System.Drawing.Color.White;
            this.panelTeclado.Location = new System.Drawing.Point(200, 226);
            this.panelTeclado.Name = "panelTeclado";
            this.panelTeclado.Size = new System.Drawing.Size(364, 172);
            this.panelTeclado.TabIndex = 9;
            this.panelTeclado.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTeclado_Paint);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Consolas", 13.8F);
            this.txtResultado.Location = new System.Drawing.Point(14, 62);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(281, 34);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(89, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Location = new System.Drawing.Point(618, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 129);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 78);
            this.button2.TabIndex = 17;
            this.button2.Text = "Resolver sistemas de ecuaciones lineales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1009, 621);
            this.Controls.Add(this.panelTeclado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_derivar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "             ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_derivar;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_integracion;
        private System.Windows.Forms.Button button1;
       
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Panel panelTeclado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

