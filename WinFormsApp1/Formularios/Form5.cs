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
        int nErrors = 0, nDias;
        double tempMax = 0, tempMin = 0, med = 0, max = 0, min = 0;
        double[][] temps;

        private void btn_show_Click(object sender, EventArgs e)
        {
            for (int ii = 0; ii < nDias; ii++)
            {
                this.calcularMedia(temps[ii]);
                this.calcularMaxima(temps[ii]);
                this.calcularMinima(temps[ii]);
            }
        }


        private void calcularMedia(double[] temps)
        {
            med = temps.Average();
            //Console.WriteLine("El promedio es {0}", med);
        }

        private void calcularMaxima(double[] temps)
        {
            max = temps.Max();
            //Console.WriteLine("La temperatura máxima es {0}", max);

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            // New row demo
            tabla = new DataTable();
            if (Int32.Parse(textTemMax.Text) == Int32.Parse(textTemMin.Text))
            {
                labelError.Text = "Las temperaturas no pueden ser iguales";
                nErrors = nErrors + 1;
                textTemMax.Text = "";
                textTemMin.Text = "";
            } else if (Int32.Parse(textTemMax.Text) == 9)
            {
                labelError.Text = "Temperatura invalida";
                nErrors = nErrors + 1;
                textTemMax.Text = "";
            } else  if (Int32.Parse(textTemMin.Text) == 9)
            {
                labelError.Text = "Temperatura invalida";
                nErrors = nErrors + 1;
                textTemMin.Text = "";
            } else if (Int32.Parse(textTemMin.Text) > Int32.Parse(textTemMax.Text))
            {
                labelError.Text = "La temperatura debe ser menor a la máxima, ingrese una temperatura minima: ";
                nErrors = nErrors + 1;
                textTemMin.Text = "";
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



            reportTempMediaA.Text = "Temperatura media: " + temperaturaMediaA.ToString();
            reportTempMediaB.Text = "Temperatura media: " + temperaturaMediaB.ToString();

            reportTempMaximaA.Text = "Temperatura Máxima: " + temperaturaMaximaA.ToString();
            reportTempMaximaB.Text = "Temperatura Máxima: " + temperaturaMaximaB.ToString();

            reportTempMinA.Text = "Temperatura Minima: " + temperaturaMinimaA.ToString();
            reportTempMinB.Text = "Temperatura Minima: " + temperaturaMinimaB.ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void calcularMinima(double[] temps)
        {
            min = temps.Min();
            //Console.WriteLine("La temperatura minima  es {0}", min);

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

        private void btn_calcular_Click(object sender, EventArgs e)
        {
          
        }
    }
}
