using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Formularios {
    public partial class Form3 : Form {

        Form menu;
        public Form3(Form menu) {
            this.menu = menu;
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e) {
            //this.menu.Show();
        }

        private void btn_operar_Click(object sender, EventArgs e)
        {
            double correcta = 0, incorrecta = 0, blanco = 0;


            double.TryParse(txt_correctas.Text, out correcta);
            double.TryParse(txt_incorrectas.Text, out incorrecta);
            double.TryParse(txt_blanco.Text, out blanco);


            correcta = (correcta * 4);
            incorrecta = (incorrecta * -1);
            blanco = (0);

            lb_correctas.Text = correcta.ToString();
            lb_incorrectas.Text = incorrecta.ToString();
            lb_blanco.Text = blanco.ToString();
            lb_total.Text = (correcta + incorrecta + blanco).ToString();



        }

        private void txt_correctas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Utils.validarInt(e.KeyChar);
        }
    }
}
