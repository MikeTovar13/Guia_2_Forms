﻿
namespace WinFormsApp1.Formularios {
    partial class Form6 {
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
            this.input_prod = new System.Windows.Forms.TextBox();
            this.btn_operar = new System.Windows.Forms.Button();
            this.tabledata = new System.Windows.Forms.DataGridView();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.npositivos = new System.Windows.Forms.Label();
            this.nnegativos = new System.Windows.Forms.Label();
            this.nneutros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(595, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Este programa cuenta la cantidad de numeros positivos y numeros negativos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cantidad de numeros a evaluar:";
            // 
            // input_prod
            // 
            this.input_prod.Location = new System.Drawing.Point(12, 99);
            this.input_prod.Name = "input_prod";
            this.input_prod.Size = new System.Drawing.Size(40, 23);
            this.input_prod.TabIndex = 34;
            this.input_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_prod_KeyPress);
            // 
            // btn_operar
            // 
            this.btn_operar.Location = new System.Drawing.Point(64, 99);
            this.btn_operar.Name = "btn_operar";
            this.btn_operar.Size = new System.Drawing.Size(75, 23);
            this.btn_operar.TabIndex = 38;
            this.btn_operar.Text = "Crear tabla";
            this.btn_operar.UseVisualStyleBackColor = true;
            this.btn_operar.Click += new System.EventHandler(this.btn_operar_Click);
            // 
            // tabledata
            // 
            this.tabledata.AllowUserToAddRows = false;
            this.tabledata.AllowUserToDeleteRows = false;
            this.tabledata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabledata.Location = new System.Drawing.Point(12, 132);
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
            this.tabledata.Size = new System.Drawing.Size(156, 196);
            this.tabledata.TabIndex = 39;
            this.tabledata.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tabledata_DataError);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(174, 305);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 40;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(174, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 78;
            this.label9.Text = "Resultado";
            // 
            // npositivos
            // 
            this.npositivos.AutoSize = true;
            this.npositivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.npositivos.Location = new System.Drawing.Point(174, 162);
            this.npositivos.Name = "npositivos";
            this.npositivos.Size = new System.Drawing.Size(0, 15);
            this.npositivos.TabIndex = 79;
            // 
            // nnegativos
            // 
            this.nnegativos.AutoSize = true;
            this.nnegativos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nnegativos.Location = new System.Drawing.Point(174, 192);
            this.nnegativos.Name = "nnegativos";
            this.nnegativos.Size = new System.Drawing.Size(0, 15);
            this.nnegativos.TabIndex = 80;
            // 
            // nneutros
            // 
            this.nneutros.AutoSize = true;
            this.nneutros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nneutros.Location = new System.Drawing.Point(174, 220);
            this.nneutros.Name = "nneutros";
            this.nneutros.Size = new System.Drawing.Size(0, 15);
            this.nneutros.TabIndex = 81;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nneutros);
            this.Controls.Add(this.nnegativos);
            this.Controls.Add(this.npositivos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.tabledata);
            this.Controls.Add(this.btn_operar);
            this.Controls.Add(this.input_prod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "6. Algoritmo de suma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_prod;
        private System.Windows.Forms.Button btn_operar;
        private System.Windows.Forms.DataGridView tabledata;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label npositivos;
        private System.Windows.Forms.Label nnegativos;
        private System.Windows.Forms.Label nneutros;}
}