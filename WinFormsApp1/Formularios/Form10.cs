using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Formularios {
    public partial class Form10 : Form {
        DataTable tabla = new DataTable();
        Form menu;
        double salarioBasico = 908526; // Salario basico

        public Form10(Form menu) {
            this.menu = menu;
            InitializeComponent();
            dgvNomina.DataSource = tabla;
            tabla.Columns.Add("Cédula", typeof(string));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Salario", typeof(string));
            tabla.Columns.Add("Aux. de transporte", typeof(string));
            tabla.Columns.Add("Días trabajados", typeof(int));
            tabla.Columns.Add("Sueldo", typeof(string));
            tabla.Columns.Add("Horas diurnas", typeof(string));
            tabla.Columns.Add("Horas nocturas", typeof(string));
            tabla.Columns.Add("Horas festivas", typeof(string));
            tabla.Columns.Add("Recargo nocturno", typeof(string));
            tabla.Columns.Add("Total Devengado", typeof(string));
            tabla.Columns.Add("Salud", typeof(string));
            tabla.Columns.Add("Pensión", typeof(string));
            tabla.Columns.Add("Fondo de solidaridad", typeof(string));
            tabla.Columns.Add("Total deducciones", typeof(string));
            tabla.Columns.Add("Neto pagado", typeof(string));
            dgvNomina.ColumnHeadersDefaultCellStyle.Font = new Font(dgvNomina.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dgvNomina.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e) {
            this.menu.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btn_calcular_Click(object sender, EventArgs e) {

            double[] datos_in = new double[7];
            double[] datos_out = new double[13];

            if (String.IsNullOrEmpty(txt_cc.Text)) { MessageBox.Show("El campo cédula es obligatorio", "Campo Vacio"); return; }
            if (String.IsNullOrEmpty(txt_name.Text)){ MessageBox.Show("El campo nombre es obligatorio", "Campo Vacio"); return; }
            if (String.IsNullOrEmpty(txt_salario.Text)) { MessageBox.Show("El campo salario es obligatorio", "Campo Vacio"); return; }
            if (String.IsNullOrEmpty(txt_dias.Text)) { MessageBox.Show("El campo días trabajados es obligatorio", "Campo Vacio"); return; }
            if (int.Parse(txt_dias.Text)>30 || int.Parse(txt_dias.Text) == 0) { MessageBox.Show("El campo días trabajados debe ser un valor entre 1 y 30", "Campo Vacio"); return; }

            datos_in[0] = double.Parse(txt_salario.Text);
            datos_in[1] = double.Parse(txt_dias.Text) ;
            if (String.IsNullOrEmpty(txt_heDiurnas.Text)) datos_in[2] = 0;
            else datos_in[2] = double.Parse(txt_heDiurnas.Text);
            if (String.IsNullOrEmpty(txt_heNocturnas.Text)) datos_in[3] = 0;
            else datos_in[3] = double.Parse(txt_heNocturnas.Text);
            if (String.IsNullOrEmpty(txt_heFestivas.Text)) datos_in[4] = 0;
            else datos_in[4] = double.Parse(txt_heFestivas.Text);
            if (String.IsNullOrEmpty(txt_hRecargoNocturno.Text)) datos_in[5] = 0;
            else datos_in[5] = double.Parse(txt_hRecargoNocturno.Text);

            datos_out = this.calcularNomina(datos_in);

            tabla.Rows.Add(
                txt_cc.Text, txt_name.Text,
                datos_out[0].ToString("C"), datos_out[1].ToString("C"),
                datos_out[2], datos_out[3].ToString("C"),
                datos_out[4].ToString("C"), datos_out[5].ToString("C"),
                datos_out[6].ToString("C"), datos_out[7].ToString("C"),
                datos_out[8].ToString("C"), datos_out[9].ToString("C"),
                datos_out[10].ToString("C"), datos_out[11].ToString("C"),
                datos_out[12].ToString("C"), datos_out[13].ToString("C"));

            // Datos básicos
            txt_cc.Text =""; // Cedula
            txt_name.Text=""; // Nombre empleado
            txt_salario.Text=""; // Nombre empleado
            txt_dias.Text=""; // Nombre empleado
            txt_heDiurnas.Text=""; // Nombre empleado
            txt_heFestivas.Text= ""; // Nombre empleado
            txt_hRecargoNocturno.Text=""; // Nombre empleado
            txt_heNocturnas.Text = ""; // Nombre empleado


            dgvNomina.Refresh();

        }

        private double[] calcularNomina(double[] info_emp) {

            // Calculo basico
            double salarioDia = info_emp[0] / 30;
            double valorHora = salarioDia / 8;
            double sueldo = salarioDia * info_emp[1];
            double auxilioTransporte = 0;
            double fondoSolidaridad = 0;

            // Calculos extras
            double hExtraDiurna = ((valorHora * 125) / 100) * (double)info_emp[2]; // cobro al 1,25%
            double hExtraNocturna = ((valorHora * 175) / 100) * (double)info_emp[3]; // cobro al 1,75%
            double hExtraFestiva = ((valorHora * 175) / 100) * (double)info_emp[4]; // cobro al 1,75%;
            double recargoNocturno = ((valorHora * 35) / 100) * (double)info_emp[5];

            if ((double)info_emp[0] <= salarioBasico * 2) {
                auxilioTransporte = 106454;
            }

            if (sueldo >= salarioBasico * 4) {
                fondoSolidaridad = (sueldo * 1) / 100;
            }

            double horasExtras = hExtraFestiva + hExtraDiurna + hExtraNocturna + recargoNocturno;

            double total_1 = sueldo + horasExtras; // Sueldo total

            double salud = (total_1 * 4) / 100;
            double pension = (total_1 * 4) / 100;

            double deducciones = fondoSolidaridad + salud + pension;

            double total_2 = total_1 - deducciones + auxilioTransporte; // Sueldo con deducciones basicas

            // Sueldo total con deducciones y extras calculados
            return new double[]{info_emp[0], auxilioTransporte, info_emp[1], sueldo, hExtraDiurna, hExtraNocturna,
                hExtraFestiva, recargoNocturno, total_1, salud, pension, fondoSolidaridad, deducciones, total_2 };

        }

        private void txt_cc_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void txt_salario_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void txt_dias_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void txt_heDiurnas_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void txt_heNocturnas_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void txt_heFestivas_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void txt_hRecargoNocturno_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void txt_salario_TextChanged(object sender, EventArgs e) {
            double sl = Convert.ToDouble(txt_salario.Text);
            txt_salario.Text = sl.ToString("#,#");
        }
    }
}
