using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Formularios {
    public partial class Form4 : Form {
        
        Form menu;

        public Form4(Form menu) {
            this.menu = menu;
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e) {
            this.menu.Show();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double ingreso = 0, incentivo = 0, salario = 0;
            int producionSemanal;
            if (String.IsNullOrEmpty(input_prod.Text)) { MessageBox.Show("El campo es obligatorio", "Campo Vacio"); return; }
            
            producionSemanal = int.Parse(input_prod.Text);

            if (producionSemanal < 100)
            {
                // Ingreso 2 pesos
                ingreso = producionSemanal * 2;
                // Incentivo 0%
                incentivo = (ingreso * 0) / 100;

                labelError.Text = "Tu producción semanal no es suficiente, la miníma es 99, no recibirás incentivos";
            }
            else if (producionSemanal < 200)
            {
                // Ingreso 2 pesos
                ingreso = producionSemanal * 2;
                // Incentivo 10%
                incentivo = (ingreso * 10) / 100;
            }
            else if (producionSemanal < 300)
            {
                // Ingreso 2,5 pesos
                ingreso = producionSemanal * 2.5;
                // Incentivo 12%
                incentivo = (ingreso * 12) / 100;
            }
            else if (producionSemanal < 400)
            {
                // Ingreso 3 pesos
                ingreso = producionSemanal * 3;
                // Incentivo 14%
                incentivo = (ingreso * 14) / 100;
            }
            else if (producionSemanal >= 400)
            {
                // Ingreso 3,5 pesos
                ingreso = producionSemanal * 3.5;
                // Incentivo 16%
                incentivo = (ingreso * 16) / 100;
            }

            incentivoLabel.Text = "Tus incenitvos son: $" + incentivo;
            ingresoLabel.Text = "Tu ingreso es de: $" + ingreso;
            salario = incentivo + ingreso;
            salarioLabel.Text = "Tu salario de la semana es: $" + salario;

            input_prod.Enabled = false;
            btn_limpiar.Enabled = true;
            btn_calcular.Enabled = false;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            input_prod.Enabled = true;
            btn_limpiar.Enabled = false;
            btn_calcular.Enabled = true;
            input_prod.Text = "";
            incentivoLabel.Text = "";
            ingresoLabel.Text = "";
            salarioLabel.Text = "";
            labelError.Text = "";
        }

        private void input_prod_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }
    }
}
