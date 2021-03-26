using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Formularios {
    public partial class Form2 : Form {

        Form menu;
        public Form2(Form menu) {
            this.menu = menu;
            InitializeComponent();
            txt_numero1.Enabled = true;
            txt_numero2.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e) {
            this.menu.Show();
        }

        private void btn_operar_Click(object sender, EventArgs e) {

            string operacion = "";
            double resultado = 0;
            double numero1;
            double numero2;


            foreach (RadioButton rb in grp_operaciones.Controls)
            {
                if (rb.Checked)
                {
                    operacion = rb.Name;
                }
            }

            // Obtener numeros de los textbox
            double.TryParse(txt_numero1.Text, out numero1);

            switch (operacion)
            {
                case "rb_raiz":
                    resultado = Math.Sqrt(numero1);
                    break;
                case "rb_exponencial2":
                    resultado = Math.Pow(numero1, 2);
                    break;
                case "rb_exponencial3":
                    resultado = Math.Pow(numero1, 3);
                    break;
                case "rb_ValorAbsoluto":
                    resultado = Math.Abs(numero1);
                    break;
                case "rb_seno":
                    double sen = Math.Sin(numero1);
                    resultado = sen;
                    break;
                case "rb_coseno":
                    double cos = Math.Cos(numero1);
                    resultado = cos;
                    break;
                case "rb_tangente":
                    double tan = Math.Tan(numero1);
                    resultado = tan;
                    break;
                case "rb_hipotenusa":
                    double.TryParse(txt_numero2.Text, out numero2);
                    double h2 = Math.Pow(numero1, 2) + Math.Pow(numero2, 2);
                      resultado = Math.Sqrt(h2);
                    break;
                case "rb_circunferencia":
                    resultado = Math.PI * Math.Pow(numero1, 2);
                    break;
                    
            }

            lb_resultado.Text = Math.Round(resultado, 2).ToString();
        }

        public void rb_raiz_CheckedChanged(object sender, EventArgs e) {

            RadioButton operation = sender as RadioButton;

            switch (operation.Name) {
                case "rb_hipotenusa":
                    txt_numero2.Enabled = true;
                    break;
                default:
                    txt_numero2.Enabled = false;
                    txt_numero2.Text = "";
                    break;
            }
        }

        public void txt_numero1_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarDecimal(e.KeyChar);
        }
    }

}


