namespace CALCULADORA
{
    partial class Encontrar_raices
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_integracion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.btn_newtonraphson = new System.Windows.Forms.Button();
            this.btn_biseccion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.panelTeclado = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(111, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(896, 50);
            this.panel4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(297, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Encontrar Raices";
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
            this.panel3.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 51);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Location = new System.Drawing.Point(618, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 129);
            this.panel1.TabIndex = 9;
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
            this.txtResultado.Size = new System.Drawing.Size(285, 34);
            this.txtResultado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(318, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Funcion";
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
            this.txtFuncion.TabIndex = 9;
            // 
            // btn_newtonraphson
            // 
            this.btn_newtonraphson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_newtonraphson.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_newtonraphson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_newtonraphson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_newtonraphson.Location = new System.Drawing.Point(676, 287);
            this.btn_newtonraphson.Name = "btn_newtonraphson";
            this.btn_newtonraphson.Size = new System.Drawing.Size(200, 70);
            this.btn_newtonraphson.TabIndex = 11;
            this.btn_newtonraphson.Text = "Newton-Rapshon";
            this.btn_newtonraphson.UseVisualStyleBackColor = false;
            this.btn_newtonraphson.Click += new System.EventHandler(this.btn_newtonraphson_Click);
            // 
            // btn_biseccion
            // 
            this.btn_biseccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_biseccion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_biseccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_biseccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_biseccion.Location = new System.Drawing.Point(676, 378);
            this.btn_biseccion.Name = "btn_biseccion";
            this.btn_biseccion.Size = new System.Drawing.Size(200, 70);
            this.btn_biseccion.TabIndex = 13;
            this.btn_biseccion.Text = "Biseccion";
            this.btn_biseccion.UseVisualStyleBackColor = false;
            this.btn_biseccion.Click += new System.EventHandler(this.btn_biseccion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(266, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Estimacion inicial";
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(360, 270);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(34, 22);
            this.txtX0.TabIndex = 15;
            this.txtX0.TextChanged += new System.EventHandler(this.txtEstimacionInicial_TextChanged);
            // 
            // panelTeclado
            // 
            this.panelTeclado.BackColor = System.Drawing.Color.White;
            this.panelTeclado.Location = new System.Drawing.Point(199, 311);
            this.panelTeclado.Name = "panelTeclado";
            this.panelTeclado.Size = new System.Drawing.Size(364, 172);
            this.panelTeclado.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 78);
            this.button2.TabIndex = 16;
            this.button2.Text = "Resolver sistemas de ecuaciones lineales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Encontrar_raices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1009, 621);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_biseccion);
            this.Controls.Add(this.panelTeclado);
            this.Controls.Add(this.btn_newtonraphson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Encontrar_raices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_integracion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Button btn_newtonraphson;
        private System.Windows.Forms.Button btn_biseccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Panel panelTeclado;
        private System.Windows.Forms.Button button2;
    }
}