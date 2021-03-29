using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Formularios {
    public partial class Form7 : Form {
        
        Form menu;
        DataTable tabla;
        int num;
        public Form7(Form menu) {
            this.menu = menu;
            InitializeComponent();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e) {
            this.menu.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            int.TryParse(input_prod.Text, out num);
            tabla = new DataTable();
            tabla.Columns.Add("Edad", typeof(int));
            tabla.Columns.Add("Peso", typeof(float));
            tabledata.DataSource = tabla;
            for (int i = 0; i < num; i++)
            {
                tabla.Rows.Add();
                tabledata.Refresh();
                tabledata.Rows[i].HeaderCell.Value = i + 1;
            }
        }

        private void btn_promedio_Click(object sender, EventArgs e)
        {
            int  niño, joven, adulto, viejo;
            double peso_niño, peso_joven, peso_adulto, peso_viejo;
            double promedio_niño, promedio_joven, promedio_adulto, promedio_viejo;

            niño = 0;
            joven = 0;
            adulto = 0;
            viejo = 0;
            peso_niño = 0;
            peso_joven = 0;
            peso_adulto = 0;
            peso_viejo = 0;

            for (int i = 0; i < num; i++)
            {
                int edad;
                double peso;
                int.TryParse(tabledata.Rows[i].Cells[0].Value.ToString(), out edad);
                double.TryParse(tabledata.Rows[i].Cells[1].Value.ToString(), out peso);

                if (edad > 60) {
                    peso_viejo += peso;
                    viejo++;
                } else if (edad > 30) {
                    peso_adulto += peso;
                    adulto++;
                } else if (edad > 13) {
                    peso_joven += peso;
                    joven++;
                } else if (edad > 0) {
                    peso_niño += peso;
                    niño++;
                }
                promedio_niño = this.promedio(niño, peso_niño);
                promedio_joven = this.promedio(joven, peso_joven);
                promedio_adulto = this.promedio(adulto, peso_adulto);
                promedio_viejo = this.promedio(viejo, peso_viejo);

                niño_promedio.Text = "La cantidad de niños es: " + niño + " de "+num+" personas, su promedio de peso es: " + promedio_niño;
                joven_promedio.Text = "La cantidad de jovenes es: " + joven + " de " + num + " personas, su promedio de peso es: " + promedio_joven;
                adulto_promedio.Text = "La cantidad de adultos es: " + adulto + " de " + num + " personas, su promedio de peso es: " + promedio_adulto;
                viejo_promedio.Text = "La cantidad de viejos es: " + viejo + " de " + num + " personas, su promedio de peso es: " + promedio_viejo;

            }
                
        }
        private double promedio(double c, double s)
        {
            if (c > 0)
            {
                return Math.Round(s / c, 2);
            }
            return 0;
        }

        private void input_prod_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void tabledata_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            if (e.ColumnIndex == 0) {
                MessageBox.Show("La edad debe ser número entero", "Error de escritura");
            } else {
                MessageBox.Show("El peso debe ser un número. Para decimales usar coma \",\"", "Error de escritura");
            }

        }
    }
}
