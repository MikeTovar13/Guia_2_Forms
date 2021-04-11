using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Formularios {
    public partial class Form9 : Form {

        Form menu;
        DataTable tabla;
        int num_estudiantes = 0;
        int num_materias = 0;
        public Form9(Form menu) {
            this.menu = menu;
            InitializeComponent();
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e) {
            this.menu.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtNumEstudiantes_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void txtNumMaterias_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void btnCrearTabla_Click(object sender, EventArgs e) {
            int.TryParse(txtNumEstudiantes.Text, out num_estudiantes);
            int.TryParse(txtNumMaterias.Text, out num_materias);
            tabla = new DataTable();
            for (int i = 0; i < num_estudiantes; i++) {
                tabla.Columns.Add("Estudiante " + (i + 1), typeof(float));
            }
            dgvPromedios.DataSource = tabla;
            for (int i = 0; i < num_materias; i++) {
                tabla.Rows.Add();
                dgvPromedios.Refresh();
                dgvPromedios.Rows[i].HeaderCell.Value = "Materia " + (i + 1);
            }
        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void btnPromedios_Click(object sender, EventArgs e) {
            if (dgvPromedios.Columns.Count==num_estudiantes){ 
                dgvPromedios.Columns.Add("Promedio","Promedio");
            }
            if (dgvPromedios.Rows.Count == num_materias) {
                tabla.Rows.Add();
                dgvPromedios.Refresh();
                dgvPromedios.Rows[num_materias].HeaderCell.Value = "Promedio";
            }
            for (int i = 0; i < num_materias; i++) {
                float promedio_mat = 0;
                for (int j = 0; j < num_estudiantes; j++) {
                    float conversion;
                    float.TryParse(dgvPromedios.Rows[i].Cells[j].Value.ToString(), out conversion);
                    promedio_mat += conversion;
                }
                dgvPromedios.Rows[i].Cells[num_estudiantes].Value = Math.Round(promedio_mat / num_estudiantes, 2);
            }
            for (int i = 0; i < num_estudiantes; i++) {
                float promedio_mat = 0;
                for (int j = 0; j < num_materias; j++) {
                    float conversion;
                    float.TryParse(dgvPromedios.Rows[j].Cells[i].Value.ToString(), out conversion);
                    promedio_mat += conversion;
                }
                dgvPromedios.Rows[num_materias].Cells[i].Value = Math.Round(promedio_mat / num_materias, 2);
            }
        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void txtNumEstudiantes_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPromedios_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            MessageBox.Show("Las notas deben ser números positivos entre 1 y 5. Para decimales usar coma \",\"", "Error de escritura");

        }

        private void dgvPromedios_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            double valor;
            double.TryParse(dgvPromedios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out valor);

            if (valor > 5 || valor < 0) {
                dgvPromedios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
            }
        }

        private void Form9_Load(object sender, EventArgs e) {

        }
    }
}
