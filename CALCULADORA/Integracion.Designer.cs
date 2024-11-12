namespace CALCULADORA
{
    partial class Integracion
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
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_integracion = new System.Windows.Forms.Button();
            this.btn_derivar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Integrarmetodosimpson = new System.Windows.Forms.Button();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.panelTeclado = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_trapecio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumIntervalos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLimiteSuperior = new System.Windows.Forms.TextBox();
            this.txtLimiteInferior = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(-7, -21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 616);
            this.panel3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 78);
            this.button2.TabIndex = 17;
            this.button2.Text = "Resolver sistemas de ecuaciones lineales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 51);
            this.button5.TabIndex = 11;
            this.button5.Text = "Derivadas aproximadas ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // 
            // btn_derivar
            // 
            this.btn_derivar.Location = new System.Drawing.Point(3, 95);
            this.btn_derivar.Name = "btn_derivar";
            this.btn_derivar.Size = new System.Drawing.Size(104, 34);
            this.btn_derivar.TabIndex = 7;
            this.btn_derivar.Text = "Derivar";
            this.btn_derivar.UseVisualStyleBackColor = true;
            this.btn_derivar.Click += new System.EventHandler(this.button1_Click);
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
            this.panel4.Location = new System.Drawing.Point(102, -21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(896, 73);
            this.panel4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(353, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Integracion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_Integrarmetodosimpson
            // 
            this.btn_Integrarmetodosimpson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_Integrarmetodosimpson.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Integrarmetodosimpson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Integrarmetodosimpson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Integrarmetodosimpson.Location = new System.Drawing.Point(518, 191);
            this.btn_Integrarmetodosimpson.Name = "btn_Integrarmetodosimpson";
            this.btn_Integrarmetodosimpson.Size = new System.Drawing.Size(200, 70);
            this.btn_Integrarmetodosimpson.TabIndex = 9;
            this.btn_Integrarmetodosimpson.Text = "Metodo de simpson";
            this.btn_Integrarmetodosimpson.UseVisualStyleBackColor = false;
            this.btn_Integrarmetodosimpson.Click += new System.EventHandler(this.btn_Integrar_Click);
            // 
            // txtFuncion
            // 
            this.txtFuncion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFuncion.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncion.Location = new System.Drawing.Point(50, 111);
            this.txtFuncion.Multiline = true;
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtFuncion.Size = new System.Drawing.Size(318, 34);
            this.txtFuncion.TabIndex = 10;
            this.txtFuncion.TextChanged += new System.EventHandler(this.txtFuncion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(153, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Funcion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Location = new System.Drawing.Point(462, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 129);
            this.panel1.TabIndex = 13;
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
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Consolas", 13.8F);
            this.txtResultado.Location = new System.Drawing.Point(14, 62);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(281, 34);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // panelTeclado
            // 
            this.panelTeclado.BackColor = System.Drawing.Color.White;
            this.panelTeclado.Location = new System.Drawing.Point(28, 161);
            this.panelTeclado.Name = "panelTeclado";
            this.panelTeclado.Size = new System.Drawing.Size(364, 172);
            this.panelTeclado.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_trapecio);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtNumIntervalos);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtLimiteSuperior);
            this.panel2.Controls.Add(this.txtLimiteInferior);
            this.panel2.Controls.Add(this.panelTeclado);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtFuncion);
            this.panel2.Controls.Add(this.btn_Integrarmetodosimpson);
            this.panel2.Location = new System.Drawing.Point(109, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 520);
            this.panel2.TabIndex = 15;
            // 
            // btn_trapecio
            // 
            this.btn_trapecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_trapecio.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_trapecio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_trapecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_trapecio.Location = new System.Drawing.Point(518, 281);
            this.btn_trapecio.Name = "btn_trapecio";
            this.btn_trapecio.Size = new System.Drawing.Size(200, 70);
            this.btn_trapecio.TabIndex = 20;
            this.btn_trapecio.Text = "Metodo del trapecio";
            this.btn_trapecio.UseVisualStyleBackColor = false;
            this.btn_trapecio.Click += new System.EventHandler(this.btn_trapecio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(102, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Num intervalos";
            // 
            // txtNumIntervalos
            // 
            this.txtNumIntervalos.Location = new System.Drawing.Point(166, 461);
            this.txtNumIntervalos.Name = "txtNumIntervalos";
            this.txtNumIntervalos.Size = new System.Drawing.Size(60, 22);
            this.txtNumIntervalos.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(207, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "lim superior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(55, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "lim inferior";
            // 
            // txtLimiteSuperior
            // 
            this.txtLimiteSuperior.Location = new System.Drawing.Point(220, 393);
            this.txtLimiteSuperior.Name = "txtLimiteSuperior";
            this.txtLimiteSuperior.Size = new System.Drawing.Size(60, 22);
            this.txtLimiteSuperior.TabIndex = 16;
            // 
            // txtLimiteInferior
            // 
            this.txtLimiteInferior.Location = new System.Drawing.Point(103, 393);
            this.txtLimiteInferior.Name = "txtLimiteInferior";
            this.txtLimiteInferior.Size = new System.Drawing.Size(60, 22);
            this.txtLimiteInferior.TabIndex = 15;
            // 
            // Integracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(991, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Integracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integracion";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_integracion;
        private System.Windows.Forms.Button btn_derivar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Integrarmetodosimpson;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Panel panelTeclado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLimiteInferior;
        private System.Windows.Forms.TextBox txtLimiteSuperior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumIntervalos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_trapecio;
        private System.Windows.Forms.Button button2;
    }
}