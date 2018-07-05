using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void entrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            string nome = textoNome.Text;
            string senha = textoSenha.Text;

            if (!usuario.verificaNome(nome))
            {
                MessageBox.Show("Nome digitado incorretamente\nPor favor, tente novamente!");
            }
            else if (!usuario.verificaSenha(senha))
            {
                MessageBox.Show("Senha digitada incorretamente!\nPor favor, tente novamente!");
            }
            else if (!usuario.verificaLogin(nome, senha))
            {
                MessageBox.Show("Login incorreto!\nPor favor, tente novamente!");
            }
            else {
                FormPrincipal novaform = new FormPrincipal();
                novaform.Show();
                this.Visible = false;
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            textoNome.Text = ("");
            textoSenha.Text = ("");
            textoNome.Focus();
        }
    }
}
