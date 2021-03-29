using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1.Formularios {
    public partial class Form6 : Form {
        Form menu;
        DataTable tabla;
        int num;
        public Form6(Form menu) {
            this.menu = menu;
            InitializeComponent();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e) {
            this.menu.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
            input_prod.Enabled = true;
            input_prod.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_numero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_operar_Click(object sender, EventArgs e)
        {
            num  = int.Parse(input_prod.Text);
            tabla = new DataTable();
            tabledata.DataSource = tabla;
            for (int i = 0; i < num; i++)
            {

                tabla.Rows.Add();
                tabledata.Refresh();
                tabledata.Rows[i].HeaderCell.Value = i + 1;

            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            int positivo = 0;
            int negativo = 0;
            int cero = 0;
            int cant;

            double numPositivos = 0;
            double numNegativos = 0;

            for (int i = 0; i < num; i++)
            {
                string value = tabledata.Rows[i].Cells[0].Value.ToString();
                

                 if (int.Parse(value) > 0)
                 {
                     positivo += 1;
                     numPositivos += int.Parse(value);
                 }
                 else
                     if (int.Parse(value) < 0)
                 {
                     negativo += 1;
                     numNegativos += int.Parse(value);
                 }
                 else
                 {
                     cero++;
                 }
            }
            npositivos.Text = "La cantidad de positivos son: "+ positivo +" y suman en total: "  + numPositivos;
            nnegativos.Text = "La cantidad de negativos son: "+ negativo +" y suman en total: "  + numNegativos;
            nneutros.Text = "La cantidad de negativos son: "+ cero +" y suman en total: "  + cero;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabledata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
