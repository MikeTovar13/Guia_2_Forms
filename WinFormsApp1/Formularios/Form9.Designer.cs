
namespace WinFormsApp1.Formularios {
    partial class Form9 {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumEstudiantes = new System.Windows.Forms.TextBox();
            this.txtNumMaterias = new System.Windows.Forms.TextBox();
            this.btnCrearTabla = new System.Windows.Forms.Button();
            this.dgvPromedios = new System.Windows.Forms.DataGridView();
            this.btnPromedios = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedios)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Número de estudiantes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Número de materias";
            // 
            // txtNumEstudiantes
            // 
            this.txtNumEstudiantes.Location = new System.Drawing.Point(142, 59);
            this.txtNumEstudiantes.Name = "txtNumEstudiantes";
            this.txtNumEstudiantes.Size = new System.Drawing.Size(47, 23);
            this.txtNumEstudiantes.TabIndex = 16;
            this.txtNumEstudiantes.TextChanged += new System.EventHandler(this.txtNumEstudiantes_TextChanged);
            this.txtNumEstudiantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumEstudiantes_KeyPress);
            // 
            // txtNumMaterias
            // 
            this.txtNumMaterias.Location = new System.Drawing.Point(142, 102);
            this.txtNumMaterias.Name = "txtNumMaterias";
            this.txtNumMaterias.Size = new System.Drawing.Size(47, 23);
            this.txtNumMaterias.TabIndex = 17;
            this.txtNumMaterias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumMaterias_KeyPress);
            // 
            // btnCrearTabla
            // 
            this.btnCrearTabla.Location = new System.Drawing.Point(12, 149);
            this.btnCrearTabla.Name = "btnCrearTabla";
            this.btnCrearTabla.Size = new System.Drawing.Size(75, 23);
            this.btnCrearTabla.TabIndex = 18;
            this.btnCrearTabla.Text = "Crear tabla";
            this.btnCrearTabla.UseVisualStyleBackColor = true;
            this.btnCrearTabla.Click += new System.EventHandler(this.btnCrearTabla_Click);
            // 
            // dgvPromedios
            // 
            this.dgvPromedios.AllowUserToAddRows = false;
            this.dgvPromedios.AllowUserToDeleteRows = false;
            this.dgvPromedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromedios.Location = new System.Drawing.Point(197, 59);
            this.dgvPromedios.MultiSelect = false;
            this.dgvPromedios.Name = "dgvPromedios";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "Materia";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromedios.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPromedios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPromedios.RowTemplate.Height = 25;
            this.dgvPromedios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromedios.Size = new System.Drawing.Size(510, 150);
            this.dgvPromedios.TabIndex = 19;
            this.dgvPromedios.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromedios_CellEndEdit);
            this.dgvPromedios.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPromedios_DataError);
            // 
            // btnPromedios
            // 
            this.btnPromedios.Location = new System.Drawing.Point(713, 186);
            this.btnPromedios.Name = "btnPromedios";
            this.btnPromedios.Size = new System.Drawing.Size(75, 23);
            this.btnPromedios.TabIndex = 20;
            this.btnPromedios.Text = "Promedios";
            this.btnPromedios.UseVisualStyleBackColor = true;
            this.btnPromedios.Click += new System.EventHandler(this.btnPromedios_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Para agregar las notas, escribela en la celda corespondiente";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(367, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Promedio de notas para materias y estudiantes";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPromedios);
            this.Controls.Add(this.dgvPromedios);
            this.Controls.Add(this.btnCrearTabla);
            this.Controls.Add(this.txtNumMaterias);
            this.Controls.Add(this.txtNumEstudiantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.Text = "Crear tabla";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form9_FormClosed);
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumEstudiantes;
        private System.Windows.Forms.TextBox txtNumMaterias;
        private System.Windows.Forms.Button btnCrearTabla;
        private System.Windows.Forms.DataGridView dgvPromedios;
        private System.Windows.Forms.Button btnPromedios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}