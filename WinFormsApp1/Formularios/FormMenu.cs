using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Formularios {
    public partial class FormMenu : Form {
        public FormMenu() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btn_siguiente_Click(object sender, EventArgs e) {

            var formulario = "";
            Form f = null; // Declaracion de formulario

            foreach (RadioButton rb in grpMenu.Controls) {
                if (rb.Checked) {
                    formulario = rb.Name;
                }
            }

           
            switch (formulario) {
                case "Form_1":
                    f = new Form1(this);
                    break;
                case "Form_2":
                    f = new Form2(this);
                    break;
                case "Form_3":
                    f = new Form3(this);
                    break;
                case "Form_4":
                    f = new Form4(this);
                    break;
                case "Form_5":
                    f = new Form5(this);
                    break;
                case "Form_6":
                    f = new Form6(this);
                    break;
                case "Form_7":
                    f = new Form7(this);
                    break;
                case "Form_8":
                    f = new Form8(this);
                    break;
                case "Form_9":
                    f = new Form9(this);
                    break;
                case "Form_10":
                    f = new Form10(this);
                    break;

            }

            this.Hide(); // Ocultar formulario principal
            f.Show(); // Ejecutar formulario escogido

           
        }

        private void btn_salir_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
