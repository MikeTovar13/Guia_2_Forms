
namespace WinFormsApp1.Formularios {
    partial class Form8 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.btn_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_dias = new System.Windows.Forms.TextBox();
            this.txt_gallinas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DimGray;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_salir.Location = new System.Drawing.Point(713, 415);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 9;
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
            this.label3.TabIndex = 13;
            this.label3.Text = "Grupo 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Electiva I";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Universidad ECCI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cálculo de producción de huevos por gallinas:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(12, 257);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 30;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_resultado.Location = new System.Drawing.Point(572, 190);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(19, 21);
            this.lb_resultado.TabIndex = 29;
            this.lb_resultado.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(392, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "La producción será de:";
            // 
            // txt_dias
            // 
            this.txt_dias.Location = new System.Drawing.Point(224, 209);
            this.txt_dias.Name = "txt_dias";
            this.txt_dias.Size = new System.Drawing.Size(100, 23);
            this.txt_dias.TabIndex = 27;
            this.txt_dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dias_KeyPress);
            // 
            // txt_gallinas
            // 
            this.txt_gallinas.Location = new System.Drawing.Point(224, 174);
            this.txt_gallinas.Name = "txt_gallinas";
            this.txt_gallinas.Size = new System.Drawing.Size(100, 23);
            this.txt_gallinas.TabIndex = 26;
            this.txt_gallinas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gallinas_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ingrese la cantidad de días:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ingrese la cantidad de gallinas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Para calcular la producción debemos saber los datos:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_dias);
            this.Controls.Add(this.txt_gallinas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Name = "Form8";
            this.Text = "8. Producción de granja (Huevos)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form8_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_dias;
        private System.Windows.Forms.TextBox txt_gallinas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}