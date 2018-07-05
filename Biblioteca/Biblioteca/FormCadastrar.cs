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
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            textoNome.Text = ("");
            textoAno.Text = ("  /  /    ");
            textoGenero.Text = ("");
            textoAutor.Text = ("");
            textoPaginas.Text = ("");
            textoQuantidade.Text = ("");
            textoValor.Text = ("");
            textoNome.Focus();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            string nome = textoNome.Text;
            string ano = textoAno.Text;
            string genero = textoGenero.Text;
            string autor = textoAutor.Text;
            int paginas = Convert.ToInt16(textoPaginas.Text);
            int quantidade = Convert.ToInt16(textoQuantidade.Text);
            double valor = Convert.ToDouble(textoValor.Text);
            Livro livro = new Livro(nome, ano, genero, autor, paginas, quantidade, valor);
            if (livro.validaLivro())
            {

            }
            else {
                MessageBox.Show("Preencha todos os campos primeiro!");
            }
        }

        private void textoPaginas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
