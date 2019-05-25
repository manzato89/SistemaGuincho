using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGuincho.Repositorio;

namespace SistemaGuincho.Views {
    public partial class Senha : Form {
        public bool firstLogin = false;

        public Senha() {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            String senha = txtSenha.Text;

            if (firstLogin) {
                String confirmaSenha = txtConfirmaSenha.Text;

                if (senha.Length > 0 && confirmaSenha.Length > 0 && senha.Equals(confirmaSenha)) {
                    SQLServerDatabase.Instance.createConfigTable(senha);

                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Load += Menu_Load;
                    menu.FormClosed += Menu_FormClosed;
                    menu.Show();
                } else {
                    MessageBox.Show("As senhas não coincidem",
                        "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            } else {
                if (SQLServerDatabase.Instance.tryLogin(senha)) {
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Load += Menu_Load;
                    menu.FormClosed += Menu_FormClosed;
                    menu.Show();
                } else {
                    MessageBox.Show("Senha incorreta!",
                        "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e) {
            Close();
        }

        private void Menu_Load(object sender, EventArgs e) {
            Visible = false;
        }

        private void Senha_Load(object sender, EventArgs e) {
            if (SQLServerDatabase.Instance.firstLogin()) {
                firstLogin = true;
                txtConfirmaSenha.Visible = true;

                lblSenha.Text = "Defina a senha padrão para acesso ao sistema";
            }
        }
    }
}
