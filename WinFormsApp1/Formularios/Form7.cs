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

        private void tableTemperature_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            num = int.Parse(input_prod.Text);
            tabla = new DataTable();
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
            int  edad, niño, joven, adulto, viejo;
            double peso, peso_niño, peso_joven, peso_adulto, peso_viejo;
            double promedio_niño, promedio_joven, promedio_adulto, promedio_viejo;

            niño = 0;
            edad = 0;
            peso = 0;
            joven = 0;
            adulto = 0;
            viejo = 0;
            peso_niño = 0;
            peso_joven = 0;
            peso_adulto = 0;
            peso_viejo = 0;
            promedio_niño = 0;
            promedio_joven = 0;
            promedio_adulto = 0;
            promedio_viejo = 0;

            for (int i = 0; i < num; i++)
            {
                string value = tabledata.Rows[i].Cells[0].Value.ToString();

                if (edad < 0)
                {
                    Console.Write("Edad no válida.");
                }
                else if (edad <= 13)
                {
                    peso_niño += peso;
                    niño++;
                }
                else if (edad <= 30)
                {
                    peso_joven += peso;
                    joven++;
                }
                else if (edad <= 60)
                {
                    peso_adulto = peso_adulto + peso;
                    adulto++;
                }
                else
                {
                    peso_viejo += peso;
                    viejo++;
                }
                promedio_niño = this.promedio(niño, peso_niño);
                promedio_joven = this.promedio(joven, peso_joven);
                promedio_adulto = this.promedio(adulto, peso_adulto);
                promedio_viejo = this.promedio(viejo, peso_viejo);

                niño_promedio.Text = "La cantidad de niños es: " + niño + " de  personas, su promedio de peso es: " + promedio_niño;
                joven_promedio.Text = "La cantidad de niños es: " + joven + " de  personas, su promedio de peso es: " + promedio_joven;
                adulto_promedio.Text = "La cantidad de niños es: " + adulto + " de  personas, su promedio de peso es: " + promedio_adulto;
                viejo_promedio.Text = "La cantidad de niños es: " + viejo + " de  personas, su promedio de peso es: " + promedio_viejo;

            }
                
        }
        private double promedio(double c, double s)
        {
            if (c > 0)
            {
                return s / c;
            }
            return 0;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
