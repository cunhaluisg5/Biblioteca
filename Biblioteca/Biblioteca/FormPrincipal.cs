﻿using System;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void MenuItemCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar novo = new FormCadastrar();
            novo.Show();
        }

        private void MenuItemVisualizar_Click(object sender, EventArgs e)
        {
            FormVisualizar novo = new FormVisualizar();
            novo.Show();
        }
    }
}
