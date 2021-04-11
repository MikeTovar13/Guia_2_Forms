
namespace WinFormsApp1 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label4 = new System.Windows.Forms.Label();
            this.grp_operaciones = new System.Windows.Forms.GroupBox();
            this.rb_dividir = new System.Windows.Forms.RadioButton();
            this.rb_restar = new System.Windows.Forms.RadioButton();
            this.rb_sumar = new System.Windows.Forms.RadioButton();
            this.rb_multiplicar = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.btn_operar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.grp_operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(616, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Este programa te hace la operación matemática que desees, escoge una opción:";
            // 
            // grp_operaciones
            // 
            this.grp_operaciones.Controls.Add(this.rb_dividir);
            this.grp_operaciones.Controls.Add(this.rb_restar);
            this.grp_operaciones.Controls.Add(this.rb_sumar);
            this.grp_operaciones.Controls.Add(this.rb_multiplicar);
            this.grp_operaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grp_operaciones.Location = new System.Drawing.Point(12, 67);
            this.grp_operaciones.Name = "grp_operaciones";
            this.grp_operaciones.Size = new System.Drawing.Size(200, 148);
            this.grp_operaciones.TabIndex = 13;
            this.grp_operaciones.TabStop = false;
            this.grp_operaciones.Text = "Operaciones";
            // 
            // rb_dividir
            // 
            this.rb_dividir.AutoSize = true;
            this.rb_dividir.Location = new System.Drawing.Point(18, 111);
            this.rb_dividir.Name = "rb_dividir";
            this.rb_dividir.Size = new System.Drawing.Size(66, 23);
            this.rb_dividir.TabIndex = 3;
            this.rb_dividir.TabStop = true;
            this.rb_dividir.Text = "Dividir";
            this.rb_dividir.UseVisualStyleBackColor = true;
            // 
            // rb_restar
            // 
            this.rb_restar.AutoSize = true;
            this.rb_restar.Location = new System.Drawing.Point(18, 53);
            this.rb_restar.Name = "rb_restar";
            this.rb_restar.Size = new System.Drawing.Size(65, 23);
            this.rb_restar.TabIndex = 1;
            this.rb_restar.TabStop = true;
            this.rb_restar.Text = "Restar";
            this.rb_restar.UseVisualStyleBackColor = true;
            // 
            // rb_sumar
            // 
            this.rb_sumar.AutoSize = true;
            this.rb_sumar.Checked = true;
            this.rb_sumar.Location = new System.Drawing.Point(18, 23);
            this.rb_sumar.Name = "rb_sumar";
            this.rb_sumar.Size = new System.Drawing.Size(66, 23);
            this.rb_sumar.TabIndex = 0;
            this.rb_sumar.TabStop = true;
            this.rb_sumar.Text = "Sumar";
            this.rb_sumar.UseVisualStyleBackColor = true;
            // 
            // rb_multiplicar
            // 
            this.rb_multiplicar.AutoSize = true;
            this.rb_multiplicar.Location = new System.Drawing.Point(18, 82);
            this.rb_multiplicar.Name = "rb_multiplicar";
            this.rb_multiplicar.Size = new System.Drawing.Size(91, 23);
            this.rb_multiplicar.TabIndex = 2;
            this.rb_multiplicar.TabStop = true;
            this.rb_multiplicar.Text = "Multiplicar";
            this.rb_multiplicar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(261, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Escribes los números a operar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(261, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Digita el número 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(261, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Digita el número 2:";
            // 
            // txt_numero1
            // 
            this.txt_numero1.Location = new System.Drawing.Point(393, 122);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(100, 23);
            this.txt_numero1.TabIndex = 17;
            this.txt_numero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero1_KeyPress);
            // 
            // txt_numero2
            // 
            this.txt_numero2.Location = new System.Drawing.Point(393, 151);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(100, 23);
            this.txt_numero2.TabIndex = 18;
            this.txt_numero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero2_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(555, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tu resultado es:";
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_resultado.Location = new System.Drawing.Point(687, 137);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(19, 21);
            this.lb_resultado.TabIndex = 20;
            this.lb_resultado.Text = "0";
            // 
            // btn_operar
            // 
            this.btn_operar.Location = new System.Drawing.Point(261, 191);
            this.btn_operar.Name = "btn_operar";
            this.btn_operar.Size = new System.Drawing.Size(75, 23);
            this.btn_operar.TabIndex = 21;
            this.btn_operar.Text = "Operar";
            this.btn_operar.UseVisualStyleBackColor = true;
            this.btn_operar.Click += new System.EventHandler(this.btn_operar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(262, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = " * Para decimales utiliza la coma \",\"";
            // 
            // Form1
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "1. Operaciones matemáticas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.grp_operaciones.ResumeLayout(false);
            this.grp_operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grp_operaciones;
        private System.Windows.Forms.RadioButton rb_dividir;
        private System.Windows.Forms.RadioButton rb_restar;
        private System.Windows.Forms.RadioButton rb_sumar;
        private System.Windows.Forms.RadioButton rb_multiplicar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Button btn_operar;
        private System.Windows.Forms.Label label9;
    }
}

