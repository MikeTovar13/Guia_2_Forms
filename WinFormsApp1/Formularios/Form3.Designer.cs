
namespace WinFormsApp1.Formularios {
    partial class Form3 {
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
            this.label9 = new System.Windows.Forms.Label();
            this.btn_operar = new System.Windows.Forms.Button();
            this.lb_correctas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_incorrectas = new System.Windows.Forms.TextBox();
            this.txt_correctas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_blanco = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_incorrectas = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_blanco = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(74, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 12);
            this.label9.TabIndex = 38;
            this.label9.Text = " * Para decimales utiliza la coma \",\"";
            // 
            // btn_operar
            // 
            this.btn_operar.Location = new System.Drawing.Point(225, 251);
            this.btn_operar.Name = "btn_operar";
            this.btn_operar.Size = new System.Drawing.Size(75, 23);
            this.btn_operar.TabIndex = 37;
            this.btn_operar.Text = "Operar";
            this.btn_operar.UseVisualStyleBackColor = true;
            this.btn_operar.Click += new System.EventHandler(this.btn_operar_Click);
            // 
            // lb_correctas
            // 
            this.lb_correctas.AutoSize = true;
            this.lb_correctas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_correctas.Location = new System.Drawing.Point(687, 122);
            this.lb_correctas.Name = "lb_correctas";
            this.lb_correctas.Size = new System.Drawing.Size(19, 21);
            this.lb_correctas.TabIndex = 36;
            this.lb_correctas.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(465, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Respuestas correctas:";
            // 
            // txt_incorrectas
            // 
            this.txt_incorrectas.Location = new System.Drawing.Point(305, 155);
            this.txt_incorrectas.Name = "txt_incorrectas";
            this.txt_incorrectas.Size = new System.Drawing.Size(100, 23);
            this.txt_incorrectas.TabIndex = 34;
            this.txt_incorrectas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_correctas_KeyPress);
            // 
            // txt_correctas
            // 
            this.txt_correctas.Location = new System.Drawing.Point(305, 125);
            this.txt_correctas.Name = "txt_correctas";
            this.txt_correctas.Size = new System.Drawing.Size(100, 23);
            this.txt_correctas.TabIndex = 33;
            this.txt_correctas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_correctas_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(66, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ingrese las respuestas incorrectas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(65, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ingrese las respuestas correctas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(65, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Escribes las respuestas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Este programa te muestra el total de respuestas:";
            // 
            // txt_blanco
            // 
            this.txt_blanco.Location = new System.Drawing.Point(305, 184);
            this.txt_blanco.Name = "txt_blanco";
            this.txt_blanco.Size = new System.Drawing.Size(100, 23);
            this.txt_blanco.TabIndex = 40;
            this.txt_blanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_correctas_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(66, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 19);
            this.label13.TabIndex = 39;
            this.label13.Text = "Ingrese las respuestas en blanco:";
            // 
            // lb_incorrectas
            // 
            this.lb_incorrectas.AutoSize = true;
            this.lb_incorrectas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_incorrectas.Location = new System.Drawing.Point(687, 152);
            this.lb_incorrectas.Name = "lb_incorrectas";
            this.lb_incorrectas.Size = new System.Drawing.Size(19, 21);
            this.lb_incorrectas.TabIndex = 42;
            this.lb_incorrectas.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(465, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 19);
            this.label15.TabIndex = 41;
            this.label15.Text = "Respuestas incorrectas:";
            // 
            // lb_blanco
            // 
            this.lb_blanco.AutoSize = true;
            this.lb_blanco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_blanco.Location = new System.Drawing.Point(687, 180);
            this.lb_blanco.Name = "lb_blanco";
            this.lb_blanco.Size = new System.Drawing.Size(19, 21);
            this.lb_blanco.TabIndex = 44;
            this.lb_blanco.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(465, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 19);
            this.label17.TabIndex = 43;
            this.label17.Text = "Respuestas en blanco:";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_total.Location = new System.Drawing.Point(687, 233);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(19, 21);
            this.lb_total.TabIndex = 46;
            this.lb_total.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(516, 237);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 19);
            this.label19.TabIndex = 45;
            this.label19.Text = "Tu puntaje total es:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lb_blanco);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lb_incorrectas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_blanco);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_operar);
            this.Controls.Add(this.lb_correctas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_incorrectas);
            this.Controls.Add(this.txt_correctas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "3. Validar respuestas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_operar;
        private System.Windows.Forms.Label lb_correctas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_incorrectas;
        private System.Windows.Forms.TextBox txt_correctas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_blanco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_incorrectas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_blanco;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label19;
    }
}