using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Formularios {
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AbrirFormEnPanel(object formhija) {
            if (this.pnlRenderizar.Controls.Count > 0)
                this.pnlRenderizar.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlRenderizar.Controls.Add(fh);
            this.pnlRenderizar.Tag = fh;
            fh.Show();
        }

        private void renderizar_Click(object sender, EventArgs e) {
            Button b = sender as Button;
            switch (b.Name) {
                case "btn_form1":
                    this.AbrirFormEnPanel(new Form1(null));
                    break;
                case "btn_form2":
                    this.AbrirFormEnPanel(new Form2(null));
                    break;
                case "btn_form3":
                    this.AbrirFormEnPanel(new Form3(null));
                    break;
                case "btn_form4":
                    this.AbrirFormEnPanel(new Form4(null));
                    break;
                case "btn_form5":
                    this.AbrirFormEnPanel(new Form5(null));
                    break;
                case "btn_form6":
                    this.AbrirFormEnPanel(new Form6(null));
                    break;
                case "btn_form7":
                    this.AbrirFormEnPanel(new Form7(null));
                    break;
                case "btn_form8":
                    this.AbrirFormEnPanel(new Form8(null));
                    break;
                case "btn_form9":
                    this.AbrirFormEnPanel(new Form9(null));
                    break;
                case "btn_form10":
                    this.AbrirFormEnPanel(new Form10(null));
                    break;
            }
        }
    }
}
