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
            //this.menu.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
            input_prod.Enabled = true;
            input_prod.Text = "";
        }
        private void btn_operar_Click(object sender, EventArgs e)
        {
            num  = int.Parse(input_prod.Text);
            tabla = new DataTable();
            tabla.Columns.Add("Números", typeof(float));
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

            double numPositivos = 0;
            double numNegativos = 0;

            for (int i = 0; i < num; i++)
            {
                double value;
                double.TryParse(tabledata.Rows[i].Cells[0].Value.ToString(), out value);
                

                 if (value > 0)
                 {
                     positivo += 1;
                     numPositivos += value;
                 }
                 else
                     if (value < 0)
                 {
                     negativo += 1;
                     numNegativos += value;
                 }
                 else
                 {
                     cero++;
                 }
            }
            npositivos.Text = "La cantidad de positivos son: "+ positivo +" y suman en total: "  + numPositivos;
            nnegativos.Text = "La cantidad de negativos son: "+ negativo +" y suman en total: "  + numNegativos;
            nneutros.Text = "La cantidad de neutros son: "+ cero +" y suman en total: 0" ;
        }
        private void input_prod_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void tabledata_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            MessageBox.Show("Solo se reciben números. Para decimales usar coma \",\"", "Error de escritura");

        }
    }
}
