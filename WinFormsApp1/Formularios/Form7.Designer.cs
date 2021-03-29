
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabledata = new System.Windows.Forms.DataGridView();
            this.tempMaxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempMini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.input_prod = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_promedio = new System.Windows.Forms.Button();
            this.niño_promedio = new System.Windows.Forms.Label();
            this.joven_promedio = new System.Windows.Forms.Label();
            this.adulto_promedio = new System.Windows.Forms.Label();
            this.viejo_promedio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).BeginInit();
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(64, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Promedio Edad y Peso";
            // 
            // tabledata
            // 
            this.tabledata.AllowUserToAddRows = false;
            this.tabledata.AllowUserToOrderColumns = true;
            this.tabledata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabledata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tempMaxi,
            this.tempMini});
            this.tabledata.Enabled = false;
            this.tabledata.Location = new System.Drawing.Point(47, 201);
            this.tabledata.MultiSelect = false;
            this.tabledata.Name = "tabledata";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "Materia";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabledata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabledata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabledata.RowTemplate.Height = 25;
            this.tabledata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabledata.Size = new System.Drawing.Size(432, 150);
            this.tabledata.TabIndex = 64;
            this.tabledata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableTemperature_CellContentClick);
            // 
            // tempMaxi
            // 
            this.tempMaxi.HeaderText = "Edad";
            this.tempMaxi.MinimumWidth = 8;
            this.tempMaxi.Name = "tempMaxi";
            this.tempMaxi.Width = 220;
            // 
            // tempMini
            // 
            this.tempMini.HeaderText = "Peso";
            this.tempMini.MinimumWidth = 8;
            this.tempMini.Name = "tempMini";
            this.tempMini.Width = 220;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 15);
            this.label4.TabIndex = 66;
            this.label4.Text = "Ingrese la cantidd de personas";
            // 
            // input_prod
            // 
            this.input_prod.Location = new System.Drawing.Point(64, 161);
            this.input_prod.Name = "input_prod";
            this.input_prod.Size = new System.Drawing.Size(80, 23);
            this.input_prod.TabIndex = 69;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(200, 161);
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
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(506, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 82;
            this.label13.Text = "Resultado";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // btn_promedio
            // 
            this.btn_promedio.Location = new System.Drawing.Point(341, 161);
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
            this.niño_promedio.Location = new System.Drawing.Point(506, 201);
            this.niño_promedio.Name = "niño_promedio";
            this.niño_promedio.Size = new System.Drawing.Size(59, 15);
            this.niño_promedio.TabIndex = 84;
            this.niño_promedio.Text = "Resultado";
            // 
            // joven_promedio
            // 
            this.joven_promedio.AutoSize = true;
            this.joven_promedio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.joven_promedio.Location = new System.Drawing.Point(506, 235);
            this.joven_promedio.Name = "joven_promedio";
            this.joven_promedio.Size = new System.Drawing.Size(59, 15);
            this.joven_promedio.TabIndex = 85;
            this.joven_promedio.Text = "Resultado";
            // 
            // adulto_promedio
            // 
            this.adulto_promedio.AutoSize = true;
            this.adulto_promedio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adulto_promedio.Location = new System.Drawing.Point(506, 270);
            this.adulto_promedio.Name = "adulto_promedio";
            this.adulto_promedio.Size = new System.Drawing.Size(59, 15);
            this.adulto_promedio.TabIndex = 86;
            this.adulto_promedio.Text = "Resultado";
            // 
            // viejo_promedio
            // 
            this.viejo_promedio.AutoSize = true;
            this.viejo_promedio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viejo_promedio.Location = new System.Drawing.Point(506, 305);
            this.viejo_promedio.Name = "viejo_promedio";
            this.viejo_promedio.Size = new System.Drawing.Size(59, 15);
            this.viejo_promedio.TabIndex = 87;
            this.viejo_promedio.Text = "Resultado";
            this.viejo_promedio.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Name = "Form7";
            this.Text = "7. Estadística de pesos de personas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form7_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).EndInit();
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
        private System.Windows.Forms.DataGridView tabledata;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempMaxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempMini;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_prod;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_promedio;
        private System.Windows.Forms.Label niño_promedio;
        private System.Windows.Forms.Label joven_promedio;
        private System.Windows.Forms.Label adulto_promedio;
        private System.Windows.Forms.Label viejo_promedio;
    }
}