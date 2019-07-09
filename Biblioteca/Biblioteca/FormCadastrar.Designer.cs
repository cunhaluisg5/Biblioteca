namespace Biblioteca
{
    partial class FormCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textoNome = new System.Windows.Forms.TextBox();
            this.textoGenero = new System.Windows.Forms.TextBox();
            this.textoQuantidade = new System.Windows.Forms.TextBox();
            this.textoAno = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textoAutor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textoPaginas = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.cadastrar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gênero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(544, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor:";
            // 
            // textoNome
            // 
            this.textoNome.Location = new System.Drawing.Point(150, 46);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(375, 20);
            this.textoNome.TabIndex = 5;
            // 
            // textoGenero
            // 
            this.textoGenero.Location = new System.Drawing.Point(152, 96);
            this.textoGenero.Name = "textoGenero";
            this.textoGenero.Size = new System.Drawing.Size(204, 20);
            this.textoGenero.TabIndex = 6;
            // 
            // textoQuantidade
            // 
            this.textoQuantidade.Location = new System.Drawing.Point(416, 152);
            this.textoQuantidade.Name = "textoQuantidade";
            this.textoQuantidade.Size = new System.Drawing.Size(95, 20);
            this.textoQuantidade.TabIndex = 7;
            this.textoQuantidade.Text = "0";
            // 
            // textoAno
            // 
            this.textoAno.Location = new System.Drawing.Point(594, 46);
            this.textoAno.Mask = "00/00/0000";
            this.textoAno.Name = "textoAno";
            this.textoAno.Size = new System.Drawing.Size(77, 20);
            this.textoAno.TabIndex = 9;
            this.textoAno.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Autor:";
            // 
            // textoAutor
            // 
            this.textoAutor.Location = new System.Drawing.Point(446, 94);
            this.textoAutor.Name = "textoAutor";
            this.textoAutor.Size = new System.Drawing.Size(227, 20);
            this.textoAutor.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Páginas:";
            // 
            // textoPaginas
            // 
            this.textoPaginas.Location = new System.Drawing.Point(152, 148);
            this.textoPaginas.Name = "textoPaginas";
            this.textoPaginas.Size = new System.Drawing.Size(99, 20);
            this.textoPaginas.TabIndex = 13;
            this.textoPaginas.Text = "0";
            this.textoPaginas.TextChanged += new System.EventHandler(this.textoPaginas_TextChanged);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(606, 150);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(67, 20);
            this.textoValor.TabIndex = 8;
            this.textoValor.Text = "0";
            // 
            // cadastrar
            // 
            this.cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("cadastrar.Image")));
            this.cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastrar.Location = new System.Drawing.Point(74, 259);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(151, 54);
            this.cadastrar.TabIndex = 14;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // limpar
            // 
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Image = ((System.Drawing.Image)(resources.GetObject("limpar.Image")));
            this.limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limpar.Location = new System.Drawing.Point(304, 259);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(151, 54);
            this.limpar.TabIndex = 15;
            this.limpar.Text = "Limpar";
            this.limpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Image = ((System.Drawing.Image)(resources.GetObject("sair.Image")));
            this.sair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sair.Location = new System.Drawing.Point(522, 259);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(151, 54);
            this.sair.TabIndex = 16;
            this.sair.Text = "Sair";
            this.sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.textoPaginas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textoAutor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textoAno);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.textoQuantidade);
            this.Controls.Add(this.textoGenero);
            this.Controls.Add(this.textoNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textoNome;
        private System.Windows.Forms.TextBox textoGenero;
        private System.Windows.Forms.TextBox textoQuantidade;
        private System.Windows.Forms.MaskedTextBox textoAno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textoAutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textoPaginas;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button sair;
    }
}