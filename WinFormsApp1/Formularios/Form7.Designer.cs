﻿
namespace WinFormsApp1.Formularios {
    partial class Form7 {
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
            this.label7 = new System.Windows.Forms.Label();
            this.tabledata = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.input_prod = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_promedio = new System.Windows.Forms.Button();
            this.niño_promedio = new System.Windows.Forms.Label();
            this.joven_promedio = new System.Windows.Forms.Label();
            this.adulto_promedio = new System.Windows.Forms.Label();
            this.viejo_promedio = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Promedio Edad y Peso";
            // 
            // tabledata
            // 
            this.tabledata.AllowUserToAddRows = false;
            this.tabledata.AllowUserToDeleteRows = false;
            this.tabledata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabledata.Location = new System.Drawing.Point(12, 133);
            this.tabledata.MultiSelect = false;
            this.tabledata.Name = "tabledata";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "Materia";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabledata.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabledata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabledata.RowTemplate.Height = 25;
            this.tabledata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabledata.Size = new System.Drawing.Size(288, 212);
            this.tabledata.TabIndex = 64;
            this.tabledata.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tabledata_DataError);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 15);
            this.label4.TabIndex = 66;
            this.label4.Text = "Ingrese la cantidad de personas";
            // 
            // input_prod
            // 
            this.input_prod.Location = new System.Drawing.Point(12, 65);
            this.input_prod.Name = "input_prod";
            this.input_prod.Size = new System.Drawing.Size(54, 23);
            this.input_prod.TabIndex = 69;
            this.input_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_prod_KeyPress);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(72, 65);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(122, 23);
            this.btn_adicionar.TabIndex = 71;
            this.btn_adicionar.Text = "Agregar temperatura";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(306, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 82;
            this.label13.Text = "Resultado";
            // 
            // btn_promedio
            // 
            this.btn_promedio.Location = new System.Drawing.Point(306, 322);
            this.btn_promedio.Name = "btn_promedio";
            this.btn_promedio.Size = new System.Drawing.Size(122, 23);
            this.btn_promedio.TabIndex = 83;
            this.btn_promedio.Text = "Promedio";
            this.btn_promedio.UseVisualStyleBackColor = true;
            this.btn_promedio.Click += new System.EventHandler(this.btn_promedio_Click);
            // 
            // niño_promedio
            // 
            this.niño_promedio.AutoSize = true;
            this.niño_promedio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.niño_promedio.Location = new System.Drawing.Point(306, 170);
            this.niño_promedio.Name = "niño_promedio";
            this.niño_promedio.Size = new System.Drawing.Size(0, 15);
            this.niño_promedio.TabIndex = 84;
            // 
            // joven_promedio
            // 
            this.joven_promedio.AutoSize = true;
            this.joven_promedio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.joven_promedio.Location = new System.Drawing.Point(306, 204);
            this.joven_promedio.Name = "joven_promedio";
            this.joven_promedio.Size = new System.Drawing.Size(0, 15);
            this.joven_promedio.TabIndex = 85;
            // 
            // adulto_promedio
            // 
            this.adulto_promedio.AutoSize = true;
            this.adulto_promedio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adulto_promedio.Location = new System.Drawing.Point(306, 239);
            this.adulto_promedio.Name = "adulto_promedio";
            this.adulto_promedio.Size = new System.Drawing.Size(0, 15);
            this.adulto_promedio.TabIndex = 86;
            // 
            // viejo_promedio
            // 
            this.viejo_promedio.AutoSize = true;
            this.viejo_promedio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viejo_promedio.Location = new System.Drawing.Point(306, 274);
            this.viejo_promedio.Name = "viejo_promedio";
            this.viejo_promedio.Size = new System.Drawing.Size(0, 15);
            this.viejo_promedio.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 12);
            this.label9.TabIndex = 88;
            this.label9.Text = " * Para decimales utiliza la coma \",\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 12);
            this.label5.TabIndex = 89;
            this.label5.Text = " * La edad solo se recibe en enteros, pero el peso si puedes escribir decimales";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.viejo_promedio);
            this.Controls.Add(this.adulto_promedio);
            this.Controls.Add(this.joven_promedio);
            this.Controls.Add(this.niño_promedio);
            this.Controls.Add(this.btn_promedio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.input_prod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabledata);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Text = "7. Estadística de pesos de personas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form7_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tabledata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_prod;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_promedio;
        private System.Windows.Forms.Label niño_promedio;
        private System.Windows.Forms.Label joven_promedio;
        private System.Windows.Forms.Label adulto_promedio;
        private System.Windows.Forms.Label viejo_promedio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
    }
}