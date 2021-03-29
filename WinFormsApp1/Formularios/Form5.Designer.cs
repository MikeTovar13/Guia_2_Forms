
namespace WinFormsApp1.Formularios {
    partial class Form5 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableTemperature = new System.Windows.Forms.DataGridView();
            this.tempMaxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempMini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textTemMax = new System.Windows.Forms.TextBox();
            this.textTemMin = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.reportTempMediaA = new System.Windows.Forms.Label();
            this.reportTempMaximaA = new System.Windows.Forms.Label();
            this.reportTempMinA = new System.Windows.Forms.Label();
            this.reportCatErrores = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.reportTempMinB = new System.Windows.Forms.Label();
            this.reportTempMaximaB = new System.Windows.Forms.Label();
            this.reportTempMediaB = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTemperature)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Estación climatica";
            // 
            // tableTemperature
            // 
            this.tableTemperature.AllowUserToAddRows = false;
            this.tableTemperature.AllowUserToOrderColumns = true;
            this.tableTemperature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableTemperature.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tempMaxi,
            this.tempMini});
            this.tableTemperature.Enabled = false;
            this.tableTemperature.Location = new System.Drawing.Point(9, 223);
            this.tableTemperature.MultiSelect = false;
            this.tableTemperature.Name = "tableTemperature";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "Materia";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableTemperature.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableTemperature.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableTemperature.RowTemplate.Height = 25;
            this.tableTemperature.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tableTemperature.Size = new System.Drawing.Size(328, 150);
            this.tableTemperature.TabIndex = 63;
            // 
            // tempMaxi
            // 
            this.tempMaxi.HeaderText = "Temperatura máxima";
            this.tempMaxi.MinimumWidth = 8;
            this.tempMaxi.Name = "tempMaxi";
            this.tempMaxi.Width = 220;
            // 
            // tempMini
            // 
            this.tempMini.HeaderText = "Temperatura mínima";
            this.tempMini.MinimumWidth = 8;
            this.tempMini.Name = "tempMini";
            this.tempMini.Width = 220;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 65;
            this.label4.Text = "Ingrese las temperaturas ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 66;
            this.label5.Text = "Máxima";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(108, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 67;
            this.label8.Text = "Mínima";
            // 
            // textTemMax
            // 
            this.textTemMax.Location = new System.Drawing.Point(12, 167);
            this.textTemMax.Name = "textTemMax";
            this.textTemMax.Size = new System.Drawing.Size(80, 23);
            this.textTemMax.TabIndex = 68;
            // 
            // textTemMin
            // 
            this.textTemMin.Location = new System.Drawing.Point(108, 167);
            this.textTemMin.Name = "textTemMin";
            this.textTemMin.Size = new System.Drawing.Size(80, 23);
            this.textTemMin.TabIndex = 69;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(216, 163);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(122, 23);
            this.btn_adicionar.TabIndex = 70;
            this.btn_adicionar.Text = "Agregar temperatura";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(410, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 71;
            // 
            // reportTempMediaA
            // 
            this.reportTempMediaA.AutoSize = true;
            this.reportTempMediaA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportTempMediaA.Location = new System.Drawing.Point(396, 247);
            this.reportTempMediaA.Name = "reportTempMediaA";
            this.reportTempMediaA.Size = new System.Drawing.Size(0, 15);
            this.reportTempMediaA.TabIndex = 72;
            // 
            // reportTempMaximaA
            // 
            this.reportTempMaximaA.AutoSize = true;
            this.reportTempMaximaA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportTempMaximaA.Location = new System.Drawing.Point(396, 278);
            this.reportTempMaximaA.Name = "reportTempMaximaA";
            this.reportTempMaximaA.Size = new System.Drawing.Size(0, 15);
            this.reportTempMaximaA.TabIndex = 73;
            // 
            // reportTempMinA
            // 
            this.reportTempMinA.AutoSize = true;
            this.reportTempMinA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportTempMinA.Location = new System.Drawing.Point(396, 308);
            this.reportTempMinA.Name = "reportTempMinA";
            this.reportTempMinA.Size = new System.Drawing.Size(0, 15);
            this.reportTempMinA.TabIndex = 74;
            // 
            // reportCatErrores
            // 
            this.reportCatErrores.AutoSize = true;
            this.reportCatErrores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportCatErrores.Location = new System.Drawing.Point(396, 340);
            this.reportCatErrores.Name = "reportCatErrores";
            this.reportCatErrores.Size = new System.Drawing.Size(0, 15);
            this.reportCatErrores.TabIndex = 75;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(9, 189);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(396, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 77;
            this.label9.Text = "Temperatura máxima";
            // 
            // reportTempMinB
            // 
            this.reportTempMinB.AutoSize = true;
            this.reportTempMinB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportTempMinB.Location = new System.Drawing.Point(593, 308);
            this.reportTempMinB.Name = "reportTempMinB";
            this.reportTempMinB.Size = new System.Drawing.Size(0, 15);
            this.reportTempMinB.TabIndex = 80;
            // 
            // reportTempMaximaB
            // 
            this.reportTempMaximaB.AutoSize = true;
            this.reportTempMaximaB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportTempMaximaB.Location = new System.Drawing.Point(593, 278);
            this.reportTempMaximaB.Name = "reportTempMaximaB";
            this.reportTempMaximaB.Size = new System.Drawing.Size(0, 15);
            this.reportTempMaximaB.TabIndex = 79;
            // 
            // reportTempMediaB
            // 
            this.reportTempMediaB.AutoSize = true;
            this.reportTempMediaB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportTempMediaB.Location = new System.Drawing.Point(593, 247);
            this.reportTempMediaB.Name = "reportTempMediaB";
            this.reportTempMediaB.Size = new System.Drawing.Size(0, 15);
            this.reportTempMediaB.TabIndex = 78;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(396, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 81;
            this.label13.Text = "Reporte";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(593, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 15);
            this.label14.TabIndex = 82;
            this.label14.Text = "Temperatura mínima";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.reportTempMinB);
            this.Controls.Add(this.reportTempMaximaB);
            this.Controls.Add(this.reportTempMediaB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.reportCatErrores);
            this.Controls.Add(this.reportTempMinA);
            this.Controls.Add(this.reportTempMaximaA);
            this.Controls.Add(this.reportTempMediaA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.textTemMin);
            this.Controls.Add(this.textTemMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableTemperature);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Name = "Form5";
            this.Text = "5. Estación climática";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tableTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempMaxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempMini;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTemMax;
        private System.Windows.Forms.TextBox textTemMin;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label reportTempMediaA;
        private System.Windows.Forms.Label reportTempMaximaA;
        private System.Windows.Forms.Label reportTempMinA;
        private System.Windows.Forms.Label reportCatErrores;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label reportTempMinB;
        private System.Windows.Forms.Label reportTempMaximaB;
        private System.Windows.Forms.Label reportTempMediaB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}