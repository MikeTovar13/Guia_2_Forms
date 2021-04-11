
namespace WinFormsApp1.Formularios {
    partial class Form4 {
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
            this.label7 = new System.Windows.Forms.Label();
            this.input_prod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.incentivoLabel = new System.Windows.Forms.Label();
            this.ingresoLabel = new System.Windows.Forms.Label();
            this.salarioLabel = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Salario promedio";
            // 
            // input_prod
            // 
            this.input_prod.Location = new System.Drawing.Point(302, 49);
            this.input_prod.Name = "input_prod";
            this.input_prod.Size = new System.Drawing.Size(211, 23);
            this.input_prod.TabIndex = 31;
            this.input_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_prod_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ingrese la producción realizada durante la semana";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(512, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 35;
            // 
            // incentivoLabel
            // 
            this.incentivoLabel.AutoSize = true;
            this.incentivoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incentivoLabel.Location = new System.Drawing.Point(12, 173);
            this.incentivoLabel.Name = "incentivoLabel";
            this.incentivoLabel.Size = new System.Drawing.Size(0, 15);
            this.incentivoLabel.TabIndex = 36;
            // 
            // ingresoLabel
            // 
            this.ingresoLabel.AutoSize = true;
            this.ingresoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingresoLabel.Location = new System.Drawing.Point(12, 205);
            this.ingresoLabel.Name = "ingresoLabel";
            this.ingresoLabel.Size = new System.Drawing.Size(0, 15);
            this.ingresoLabel.TabIndex = 37;
            // 
            // salarioLabel
            // 
            this.salarioLabel.AutoSize = true;
            this.salarioLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salarioLabel.Location = new System.Drawing.Point(12, 232);
            this.salarioLabel.Name = "salarioLabel";
            this.salarioLabel.Size = new System.Drawing.Size(0, 15);
            this.salarioLabel.TabIndex = 38;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(536, 49);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(116, 23);
            this.btn_calcular.TabIndex = 61;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(12, 142);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 62;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Enabled = false;
            this.btn_limpiar.Location = new System.Drawing.Point(657, 49);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(116, 23);
            this.btn_limpiar.TabIndex = 63;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.salarioLabel);
            this.Controls.Add(this.ingresoLabel);
            this.Controls.Add(this.incentivoLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_prod);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox input_prod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label incentivoLabel;
        private System.Windows.Forms.Label ingresoLabel;
        private System.Windows.Forms.Label salarioLabel;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btn_limpiar;
    }
}