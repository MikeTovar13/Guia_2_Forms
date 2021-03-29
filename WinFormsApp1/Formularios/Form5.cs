using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp1.Formularios {
    public partial class Form5 : Form {

        Form menu;
        DataTable tabla;
        int nErrors = 0;

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            // New row demo
            tabla = new DataTable();
            if (String.IsNullOrEmpty(textTemMax.Text) || String.IsNullOrEmpty(textTemMin.Text)) {
                MessageBox.Show("Ambas stemperaturas son obligatorias");
                return;
            }
           if (Int32.Parse(textTemMax.Text) == Int32.Parse(textTemMin.Text))
            {
                labelError.Text = "Las temperaturas no pueden ser iguales";
                nErrors = nErrors + 1;
                textTemMax.Text = "";
                textTemMin.Text = "";
                return;
            } else if (Int32.Parse(textTemMax.Text) >= 9)
            {
                labelError.Text = "Temperatura invalida";
                nErrors = nErrors + 1;
                textTemMax.Text = "";
                return;
            } else  if (Int32.Parse(textTemMin.Text) >= 9)
            {
                labelError.Text = "Temperatura invalida";
                nErrors = nErrors + 1;
                textTemMin.Text = "";
                return;
            } else if (Int32.Parse(textTemMin.Text) > Int32.Parse(textTemMax.Text))
            {
                labelError.Text = "La temperatura debe ser menor a la máxima, ingrese una temperatura minima: ";
                nErrors = nErrors + 1;
                textTemMin.Text = "";
                return;
            } else
            {
                int addRow = tableTemperature.Rows.Add();

                tableTemperature.Rows[addRow].Cells[0].Value = textTemMax.Text;
                tableTemperature.Rows[addRow].Cells[1].Value = textTemMin.Text;

                textTemMax.Text = "";
                textTemMin.Text = "";
                labelError.Text = "";
            }
            reportCatErrores.Text = "Cantidad de errores: " + nErrors.ToString();

            double temperaturaMinimaA = tableTemperature.Rows.Cast<DataGridViewRow>()
                              .Min(r => Convert.ToDouble(r.Cells["tempMaxi"].Value));
            double temperaturaMaximaA = tableTemperature.Rows.Cast<DataGridViewRow>()
                              .Max(r => Convert.ToDouble(r.Cells["tempMaxi"].Value));
            double temperaturaMediaA = tableTemperature.Rows.Cast<DataGridViewRow>()
                              .Average(r => Convert.ToDouble(r.Cells["tempMaxi"].Value));

            double temperaturaMinimaB = tableTemperature.Rows.Cast<DataGridViewRow>()
                              .Min(r => Convert.ToDouble(r.Cells["tempMini"].Value));
            double temperaturaMaximaB = tableTemperature.Rows.Cast<DataGridViewRow>()
                              .Max(r => Convert.ToDouble(r.Cells["tempMini"].Value));
            double temperaturaMediaB = tableTemperature.Rows.Cast<DataGridViewRow>()
                              .Average(r => Convert.ToDouble(r.Cells["tempMini"].Value));



            reportTempMediaA.Text = "Temperatura media: " + Math.Round(temperaturaMediaA, 2).ToString();
            reportTempMediaB.Text = "Temperatura media: " + Math.Round(temperaturaMediaB, 2).ToString();

            reportTempMaximaA.Text = "Temperatura Máxima: " + Math.Round(temperaturaMaximaA, 2).ToString();
            reportTempMaximaB.Text = "Temperatura Máxima: " + Math.Round(temperaturaMaximaB, 2).ToString();

            reportTempMinA.Text = "Temperatura Minima: " + Math.Round(temperaturaMinimaA, 2).ToString();
            reportTempMinB.Text = "Temperatura Minima: " + Math.Round(temperaturaMinimaB, 2).ToString();
        }

        public Form5(Form menu) {
            this.menu = menu;
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e) {
            this.menu.Show();
        }

        private void textTemMax_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarDecimal(e.KeyChar);
        }
    }
}
