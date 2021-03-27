
namespace WinFormsApp1.Formularios {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_operar = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grp_operaciones = new System.Windows.Forms.GroupBox();
            this.rb_circunferencia = new System.Windows.Forms.RadioButton();
            this.rb_hipotenusa = new System.Windows.Forms.RadioButton();
            this.rb_tangente = new System.Windows.Forms.RadioButton();
            this.rb_coseno = new System.Windows.Forms.RadioButton();
            this.rb_seno = new System.Windows.Forms.RadioButton();
            this.rb_ValorAbsoluto = new System.Windows.Forms.RadioButton();
            this.rb_exponencial2 = new System.Windows.Forms.RadioButton();
            this.rb_raiz = new System.Windows.Forms.RadioButton();
            this.rb_exponencial3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp_operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DimGray;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_salir.Location = new System.Drawing.Point(713, 415);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grupo 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Electiva I";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Universidad ECCI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(237, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 12);
            this.label9.TabIndex = 38;
            this.label9.Text = " * Para decimales utiliza la coma \",\"";
            // 
            // btn_operar
            // 
            this.btn_operar.Location = new System.Drawing.Point(237, 263);
            this.btn_operar.Name = "btn_operar";
            this.btn_operar.Size = new System.Drawing.Size(75, 23);
            this.btn_operar.TabIndex = 37;
            this.btn_operar.Text = "Operar";
            this.btn_operar.UseVisualStyleBackColor = true;
            this.btn_operar.Click += new System.EventHandler(this.btn_operar_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_resultado.Location = new System.Drawing.Point(662, 205);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(19, 21);
            this.lb_resultado.TabIndex = 36;
            this.lb_resultado.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(530, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tu resultado es:";
            // 
            // txt_numero2
            // 
            this.txt_numero2.Location = new System.Drawing.Point(368, 218);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(100, 23);
            this.txt_numero2.TabIndex = 34;
            this.txt_numero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero1_KeyPress);
            // 
            // txt_numero1
            // 
            this.txt_numero1.Location = new System.Drawing.Point(368, 190);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(100, 23);
            this.txt_numero1.TabIndex = 33;
            this.txt_numero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(236, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Digita el número 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(236, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Digita el número 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(236, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Escribes los números a operar:";
            // 
            // grp_operaciones
            // 
            this.grp_operaciones.Controls.Add(this.rb_circunferencia);
            this.grp_operaciones.Controls.Add(this.rb_hipotenusa);
            this.grp_operaciones.Controls.Add(this.rb_tangente);
            this.grp_operaciones.Controls.Add(this.rb_coseno);
            this.grp_operaciones.Controls.Add(this.rb_seno);
            this.grp_operaciones.Controls.Add(this.rb_ValorAbsoluto);
            this.grp_operaciones.Controls.Add(this.rb_exponencial2);
            this.grp_operaciones.Controls.Add(this.rb_raiz);
            this.grp_operaciones.Controls.Add(this.rb_exponencial3);
            this.grp_operaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grp_operaciones.Location = new System.Drawing.Point(10, 122);
            this.grp_operaciones.Name = "grp_operaciones";
            this.grp_operaciones.Size = new System.Drawing.Size(200, 266);
            this.grp_operaciones.TabIndex = 29;
            this.grp_operaciones.TabStop = false;
            this.grp_operaciones.Text = "Operaciones";
            // 
            // rb_circunferencia
            // 
            this.rb_circunferencia.AutoSize = true;
            this.rb_circunferencia.Location = new System.Drawing.Point(18, 234);
            this.rb_circunferencia.Name = "rb_circunferencia";
            this.rb_circunferencia.Size = new System.Drawing.Size(113, 23);
            this.rb_circunferencia.TabIndex = 8;
            this.rb_circunferencia.TabStop = true;
            this.rb_circunferencia.Text = "Circunferencia";
            this.rb_circunferencia.UseVisualStyleBackColor = true;
            this.rb_circunferencia.CheckedChanged += new System.EventHandler(this.rb_raiz_CheckedChanged);
            // 
            // rb_hipotenusa
            // 
            this.rb_hipotenusa.AutoSize = true;
            this.rb_hipotenusa.Location = new System.Drawing.Point(18, 208);
            this.rb_hipotenusa.Name = "rb_hipotenusa";
            this.rb_hipotenusa.Size = new System.Drawing.Size(97, 23);
            this.rb_hipotenusa.TabIndex = 7;
            this.rb_hipotenusa.TabStop = true;
            this.rb_hipotenusa.Text = "Hipotenusa";
            this.rb_hipotenusa.UseVisualStyleBackColor = true;
            this.rb_hipotenusa.CheckedChanged += new System.EventHandler(this.rb_raiz_CheckedChanged);
            // 
            // rb_tangente
            // 
            this.rb_tangente.AutoSize = true;
            this.rb_tangente.Location = new System.Drawing.Point(18, 182);
            this.rb_tangente.Name = "rb_tangente";
            this.rb_tangente.Size = new System.Drawing.Size(124, 23);
            this.rb_tangente.TabIndex = 6;
            this.rb_tangente.TabStop = true;
            this.rb_tangente.Text = "Tangente - Tan()";
            this.rb_tangente.UseVisualStyleBackColor = true;
            this.rb_tangente.CheckedChanged += new System.EventHandler(this.rb_raiz_CheckedChanged);
            // 
            // rb_coseno
            // 
            this.rb_coseno.AutoSize = true;
            this.rb_coseno.Location = new System.Drawing.Point(18, 155);
            this.rb_coseno.Name = "rb_coseno";
            this.rb_coseno.Size = new System.Drawing.Size(118, 23);
            this.rb_coseno.TabIndex = 5;
            this.rb_coseno.TabStop = true;
            this.rb_coseno.Text = "Coseno - Cos()";
            this.rb_coseno.UseVisualStyleBackColor = true;
            this.rb_coseno.CheckedChanged += new System.EventHandler(this.rb_raiz_CheckedChanged);
            // 
            // rb_seno
            // 
            this.rb_seno.AutoSize = true;
            this.rb_seno.Location = new System.Drawing.Point(18, 129);
            this.rb_seno.Name = "rb_seno";
            this.rb_seno.Size = new System.Drawing.Size(101, 23);
            this.rb_seno.TabIndex = 4;
            this.rb_seno.TabStop = true;
            this.rb_seno.Text = "Seno - Sen()";
            this.rb_seno.UseVisualStyleBackColor = true;
            this.rb_seno.CheckedChanged += new System.EventHandler(this.rb_raiz_CheckedChanged);
            // 
            // rb_ValorAbsoluto
            // 
            this.rb_ValorAbsoluto.AutoSize = true;
            this.rb_ValorAbsoluto.Location = new System.Drawing.Point(18, 103);
            this.rb_ValorAbsoluto.Name = "rb_ValorAbsoluto";
            this.rb_ValorAbsoluto.Size = new System.Drawing.Size(117, 23);
            this.rb_ValorAbsoluto.TabIndex = 3;
            this.rb_ValorAbsoluto.TabStop = true;
            this.rb_ValorAbsoluto.Text = "Valor Absoluto";
            this.rb_ValorAbsoluto.UseVisualStyleBackColor = true;
            this.rb_ValorAbsoluto.CheckedChanged += new System.EventHandler(this.rb_raiz_CheckedChanged);
            // 
            // rb_exponencial2
            // 
            this.rb_exponencial2.AutoSize = true;
            this.rb_exponencial2.Location = new System.Drawing.Point(18, 50);
            this.rb_exponencial2.Name = "rb_exponencial2";
            this.rb_exponencial2.Size = new System.Drawing.Size(135, 23);
            this.rb_exponencial2.TabIndex = 1;
            this.rb_exponencial2.TabStop = true;
            this.rb_exponencial2.Text = "Exponencial a la 2";
            this.rb_exponencial2.UseVisualStyleBackColor = true;
            this.rb_exponencial2.CheckedChanged += new System.EventHandler(this.rb_raiz_CheckedChanged);
            // 
            // rb_raiz
            // 
            this.rb_raiz.AutoSize = true;
            this.rb_raiz.Checked = true;
            this.rb_raiz.Location = new System.Drawing.Point(18, 24);
            this.rb_raiz.Name = "rb_raiz";
            this.rb_raiz.Size = new System.Drawing.Size(51, 23);
            this.rb_raiz.TabIndex = 0;
            this.rb_raiz.TabStop = true;
            this.rb_raiz.Text = "Raiz";
            this.rb_raiz.UseVisualStyleBackColor = true;
            this.rb_raiz.CheckedChanged += new System.EventHandler(this.rb_raiz_CheckedChanged);
            // 
            // rb_exponencial3
            // 
            this.rb_exponencial3.AutoSize = true;
            this.rb_exponencial3.Location = new System.Drawing.Point(18, 76);
            this.rb_exponencial3.Name = "rb_exponencial3";
            this.rb_exponencial3.Size = new System.Drawing.Size(135, 23);
            this.rb_exponencial3.TabIndex = 2;
            this.rb_exponencial3.TabStop = true;
            this.rb_exponencial3.Text = "Exponencial a la 3";
            this.rb_exponencial3.UseVisualStyleBackColor = true;
            this.rb_exponencial3.CheckedChanged += new System.EventHandler(this.rb_raiz_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(598, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Este programa te hace la función matemática que desees, escoge una opción:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(63, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Grupo 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(63, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Electiva I";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(63, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Universidad ECCI";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_operar);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_numero2);
            this.Controls.Add(this.txt_numero1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grp_operaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Name = "Form2";
            this.Text = "2. Funciones matemáticas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp_operaciones.ResumeLayout(false);
            this.grp_operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_operar;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grp_operaciones;
        private System.Windows.Forms.RadioButton rb_ValorAbsoluto;
        private System.Windows.Forms.RadioButton rb_exponencial2;
        private System.Windows.Forms.RadioButton rb_raiz;
        private System.Windows.Forms.RadioButton rb_exponencial3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rb_circunferencia;
        private System.Windows.Forms.RadioButton rb_hipotenusa;
        private System.Windows.Forms.RadioButton rb_tangente;
        private System.Windows.Forms.RadioButton rb_coseno;
        private System.Windows.Forms.RadioButton rb_seno;
    }
}