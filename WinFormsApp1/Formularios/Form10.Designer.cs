
namespace WinFormsApp1.Formularios {
    partial class Form10 {
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_cc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dias = new System.Windows.Forms.TextBox();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_heNocturnas = new System.Windows.Forms.TextBox();
            this.txt_heDiurnas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_hRecargoNocturno = new System.Windows.Forms.TextBox();
            this.txt_heFestivas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.dgvNomina = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Calcular nómina de empeados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(582, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Llena los datos y cada vez que le des al botón \"Agregar\" calculará la nómina y ag" +
    "regará el empleado a la tabla";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(151, 99);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 23);
            this.txt_name.TabIndex = 31;
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(151, 66);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(100, 23);
            this.txt_cc.TabIndex = 30;
            this.txt_cc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cc_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nombre del empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cédula del empleado";
            // 
            // txt_dias
            // 
            this.txt_dias.Location = new System.Drawing.Point(350, 99);
            this.txt_dias.Name = "txt_dias";
            this.txt_dias.Size = new System.Drawing.Size(100, 23);
            this.txt_dias.TabIndex = 35;
            this.txt_dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dias_KeyPress);
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(350, 67);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(100, 23);
            this.txt_salario.TabIndex = 34;
            this.txt_salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_salario_KeyPress);
            this.txt_salario.Leave += new System.EventHandler(this.txt_salario_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(257, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Días trabajados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(257, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Salario (Valor)";
            // 
            // txt_heNocturnas
            // 
            this.txt_heNocturnas.Location = new System.Drawing.Point(568, 99);
            this.txt_heNocturnas.Name = "txt_heNocturnas";
            this.txt_heNocturnas.Size = new System.Drawing.Size(39, 23);
            this.txt_heNocturnas.TabIndex = 39;
            this.txt_heNocturnas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_heNocturnas_KeyPress);
            // 
            // txt_heDiurnas
            // 
            this.txt_heDiurnas.Location = new System.Drawing.Point(568, 67);
            this.txt_heDiurnas.Name = "txt_heDiurnas";
            this.txt_heDiurnas.Size = new System.Drawing.Size(39, 23);
            this.txt_heDiurnas.TabIndex = 38;
            this.txt_heDiurnas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_heDiurnas_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(456, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "H extras nocturnas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(458, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "H extras diurnas";
            // 
            // txt_hRecargoNocturno
            // 
            this.txt_hRecargoNocturno.Location = new System.Drawing.Point(721, 99);
            this.txt_hRecargoNocturno.Name = "txt_hRecargoNocturno";
            this.txt_hRecargoNocturno.Size = new System.Drawing.Size(39, 23);
            this.txt_hRecargoNocturno.TabIndex = 43;
            this.txt_hRecargoNocturno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hRecargoNocturno_KeyPress);
            // 
            // txt_heFestivas
            // 
            this.txt_heFestivas.Location = new System.Drawing.Point(721, 67);
            this.txt_heFestivas.Name = "txt_heFestivas";
            this.txt_heFestivas.Size = new System.Drawing.Size(39, 23);
            this.txt_heFestivas.TabIndex = 42;
            this.txt_heFestivas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_heFestivas_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(611, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 15);
            this.label12.TabIndex = 41;
            this.label12.Text = "H recargo nocturo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(613, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 15);
            this.label13.TabIndex = 40;
            this.label13.Text = "H extras festivas";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(713, 151);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 60;
            this.btn_calcular.Text = "Agregar";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // dgvNomina
            // 
            this.dgvNomina.AllowUserToAddRows = false;
            this.dgvNomina.AllowUserToDeleteRows = false;
            this.dgvNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNomina.Location = new System.Drawing.Point(12, 140);
            this.dgvNomina.Name = "dgvNomina";
            this.dgvNomina.ReadOnly = true;
            this.dgvNomina.RowTemplate.Height = 25;
            this.dgvNomina.Size = new System.Drawing.Size(693, 195);
            this.dgvNomina.TabIndex = 61;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvNomina);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_hRecargoNocturno);
            this.Controls.Add(this.txt_heFestivas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_heNocturnas);
            this.Controls.Add(this.txt_heDiurnas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_dias);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_cc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.Text = "10. Nómina de empleados ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form10_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_cc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dias;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_heNocturnas;
        private System.Windows.Forms.TextBox txt_heDiurnas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_hRecargoNocturno;
        private System.Windows.Forms.TextBox txt_heFestivas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.DataGridView dgvNomina;
    }
}