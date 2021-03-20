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
    }
}
