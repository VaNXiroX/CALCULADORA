namespace CALCULADORA
{
    partial class Diferenciacion
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
            this.button29 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_integracion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btnCalcularDerivada = new System.Windows.Forms.Button();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.txtResultadoDerivada = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_derivar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button29);
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
            this.panel3.TabIndex = 6;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(0, 334);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(110, 78);
            this.button29.TabIndex = 18;
            this.button29.Text = "Interpolacion";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 78);
            this.button2.TabIndex = 17;
            this.button2.Text = "Resolver sistemas de ecuaciones lineales";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 418);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 51);
            this.button5.TabIndex = 11;
            this.button5.Text = "Derivadas aproximadas ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 78);
            this.button4.TabIndex = 10;
            this.button4.TabStop = false;
            this.button4.Text = "Resolver sistemas de ecuaciones no lineales";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 59);
            this.button3.TabIndex = 9;
            this.button3.Text = "Encontrar raices";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_integracion
            // 
            this.btn_integracion.Location = new System.Drawing.Point(3, 61);
            this.btn_integracion.Name = "btn_integracion";
            this.btn_integracion.Size = new System.Drawing.Size(104, 34);
            this.btn_integracion.TabIndex = 8;
            this.btn_integracion.Text = "Integracion";
            this.btn_integracion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 21);
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
            // 
            // btnCalcularDerivada
            // 
            this.btnCalcularDerivada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCalcularDerivada.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalcularDerivada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularDerivada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularDerivada.Location = new System.Drawing.Point(756, 228);
            this.btnCalcularDerivada.Name = "btnCalcularDerivada";
            this.btnCalcularDerivada.Size = new System.Drawing.Size(200, 70);
            this.btnCalcularDerivada.TabIndex = 19;
            this.btnCalcularDerivada.Text = "Calcular derivada";
            this.btnCalcularDerivada.UseVisualStyleBackColor = false;
            this.btnCalcularDerivada.Click += new System.EventHandler(this.btnCalcularDerivada_Click);
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(279, 121);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(187, 22);
            this.txtPuntos.TabIndex = 20;
            // 
            // txtResultadoDerivada
            // 
            this.txtResultadoDerivada.Location = new System.Drawing.Point(402, 276);
            this.txtResultadoDerivada.Name = "txtResultadoDerivada";
            this.txtResultadoDerivada.Size = new System.Drawing.Size(187, 22);
            this.txtResultadoDerivada.TabIndex = 21;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(-7, 527);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 50);
            this.button6.TabIndex = 23;
            this.button6.Text = "SALIR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_derivar
            // 
            this.btn_derivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_derivar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_derivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_derivar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_derivar.Location = new System.Drawing.Point(754, 109);
            this.btn_derivar.Name = "btn_derivar";
            this.btn_derivar.Size = new System.Drawing.Size(200, 70);
            this.btn_derivar.TabIndex = 22;
            this.btn_derivar.Text = "derivar";
            this.btn_derivar.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 470);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 51);
            this.button7.TabIndex = 24;
            this.button7.Text = "Ordinarias";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Diferenciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(991, 574);
            this.Controls.Add(this.btn_derivar);
            this.Controls.Add(this.txtResultadoDerivada);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.btnCalcularDerivada);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diferenciacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diferenciacion";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_integracion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btnCalcularDerivada;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.TextBox txtResultadoDerivada;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_derivar;
        private System.Windows.Forms.Button button7;
    }
}