using System;
using System.Collections;
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
    public partial class FormVisualizar : Form
    {
        public FormVisualizar()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            limpar_Click(sender, e);
            ArrayList lista = FormCadastrar.lista;
            foreach (Livro l in lista) {
                textoDados.AppendText(l.toString());
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            textoDados.Text = ("");
        }
    }
}
