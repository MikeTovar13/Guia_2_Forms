using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Formularios {
    public partial class Form2 : Form
    {

        Form menu;
        public Form2(Form menu)
        {
            this.menu = menu;
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.menu.Show();
        }

        private void btn_operar_Click(object sender, EventArgs e)
        {
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
            double.TryParse(txt_numero2.Text, out numero2);


            switch (operacion)
            {
                case "rb_raiz":
                    resultado = Math.Sqrt(numero1);
                    break;
                case "rb_exponencial2":
                    resultado = Math.Pow(numero1, 2);
                    break;
                case "rb_exponencia3":
                    resultado = Math.Pow(numero1, 3);
                    break;
                case "rb_ValorAbsoluto":
                    resultado = Math.Abs(numero1);
                    break;
                case "rb_seno":
                    resultado = Math.Sin(numero1);
                    break;
                case "rb_coseno":
                    resultado = Math.Cos(numero1);
                    break;
                case "rb_tangente":
                    resultado = Math.Tan(numero1);
                    break;
                case "rb_hipotenusa":
                      double h2 = Math.Pow(numero1, 2) + Math.Pow(numero2, 2);
                      resultado = Math.Sqrt(h2);
                    break;
                case "rb_circunferencia":
                    resultado = Math.PI * Math.Pow(numero1, 2);
                    break;

                    lb_resultado.Text = Math.Round(resultado, 2).ToString();
            }
        }

            public void rb_raiz_CheckedChanged(object sender, EventArgs e)
            {
                CheckBox c = sender as CheckBox;

                switch (c.Name)
                {
                    case "rb_raiz":
                        txt_numero1.Enabled = true;
                        txt_numero2.Enabled = false;

                        break;

                    case "rb_exponencial2":
                        txt_numero1.Enabled = true;
                        txt_numero2.Enabled = false;

                        break;

                    case "rb_ValorAbsoluto":
                        txt_numero1.Enabled = true;
                        txt_numero2.Enabled = false;

                        break;

                    case "rb_seno":
                        txt_numero1.Enabled = true;
                        txt_numero2.Enabled = false;

                        break;

                    case "rb_coseno":
                        txt_numero1.Enabled = true;
                        txt_numero2.Enabled = false;

                        break;

                    case "rb_tangente":
                        txt_numero1.Enabled = true;
                        txt_numero2.Enabled = false;

                        break;

                    case "rb_hipotenusa":
                        txt_numero1.Enabled = true;
                        txt_numero2.Enabled = true;

                        break;
                    case "rb_circunferencia":
                        txt_numero1.Enabled = true;
                        txt_numero2.Enabled = false;
                        break;





                }
            }

            

            public void txt_numero1_KeyPress(object sender, KeyPressEventArgs e)
            {
                e.Handled = Utils.validarInt(e.KeyChar);
            }
        }


    }


