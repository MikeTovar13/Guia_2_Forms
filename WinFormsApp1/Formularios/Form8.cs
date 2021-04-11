using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Formularios {
    public partial class Form8 : Form {
        
        Form menu;
        public Form8(Form menu) {
            this.menu = menu;
            InitializeComponent();
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e) {
            //this.menu.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btn_calcular_Click(object sender, EventArgs e) {

            int numeroGallinas;
            int numeroDias;
            double resultado;

            // Obtener numeros de los textbox
            numeroGallinas = int.Parse(txt_gallinas.Text);
            numeroDias = int.Parse(txt_dias.Text);

            resultado = calcular_produccion(numeroGallinas, numeroDias);

            lb_resultado.Text = Math.Round(resultado, 2).ToString();

        }

        private double calcular_produccion(int x, int n) {
            double prod = 0;
            for (int i = 0; i <= n; i++) {
                prod = prod + Math.Pow(x, i) / this.fact(i);
            }
            return Math.Round(prod, 1);
        }

        private double fact(int f) {
            if (f < 2) {
                return 1;
            }
            return f * this.fact(f - 1);
        }

        private void txt_gallinas_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void txt_dias_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = Utils.validarInt(e.KeyChar);
        }

        private void Form8_Load(object sender, EventArgs e) {

        }
    }
}
