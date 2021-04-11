using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1 {
    public partial class Form1 : Form {

        Form menu;
        public Form1(Form menu) {
            this.menu = menu;
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
           // this.menu.Show();
        }

        private void btn_operar_Click(object sender, EventArgs e) {

            string operacion = "";
            double resultado = 0;
            double numero1;
            double numero2;

            foreach (RadioButton rb in grp_operaciones.Controls) {
                if (rb.Checked) {
                    operacion = rb.Name;
                }
            }

            // Obtener numeros de los textbox
            numero1 = double.Parse(txt_numero1.Text);
            numero2 = double.Parse(txt_numero2.Text);

            switch (operacion) {
                case "rb_sumar":
                    resultado = numero1 + numero2;            
                    break;
                case "rb_restar":
                    resultado = numero1 - numero2;
                    break;
                case "rb_multiplicar":
                    resultado = numero1 * numero2;
                    break;
                case "rb_dividir":
                    if (numero2 == 0) {
                        MessageBox.Show("La división por cero (0) no es posible.", "Warning");
                        return;
                    }
                    resultado = numero1 / numero2;
                    break;
            }

            lb_resultado.Text = Math.Round(resultado, 2).ToString();

        }

        private void txt_numero1_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarDecimal(e.KeyChar);
        }

        private void txt_numero2_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarDecimal(e.KeyChar);
        }
    }
}
