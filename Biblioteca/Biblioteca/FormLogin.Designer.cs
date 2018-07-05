namespace Biblioteca
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoNome = new System.Windows.Forms.TextBox();
            this.textoSenha = new System.Windows.Forms.TextBox();
            this.entrar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // textoNome
            // 
            this.textoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNome.Location = new System.Drawing.Point(127, 61);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(317, 26);
            this.textoNome.TabIndex = 2;
            // 
            // textoSenha
            // 
            this.textoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSenha.Location = new System.Drawing.Point(127, 127);
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.PasswordChar = '*';
            this.textoSenha.Size = new System.Drawing.Size(317, 26);
            this.textoSenha.TabIndex = 3;
            this.textoSenha.TextChanged += new System.EventHandler(this.textoSenha_TextChanged);
            // 
            // entrar
            // 
            this.entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.Image = ((System.Drawing.Image)(resources.GetObject("entrar.Image")));
            this.entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.entrar.Location = new System.Drawing.Point(51, 194);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(114, 56);
            this.entrar.TabIndex = 4;
            this.entrar.Text = "Entrar";
            this.entrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // limpar
            // 
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Image = ((System.Drawing.Image)(resources.GetObject("limpar.Image")));
            this.limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limpar.Location = new System.Drawing.Point(188, 194);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(114, 56);
            this.limpar.TabIndex = 5;
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
            this.sair.Location = new System.Drawing.Point(330, 194);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(114, 56);
            this.sair.TabIndex = 6;
            this.sair.Text = "Sair";
            this.sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 275);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.textoSenha);
            this.Controls.Add(this.textoNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoNome;
        private System.Windows.Forms.TextBox textoSenha;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button sair;
    }
}

