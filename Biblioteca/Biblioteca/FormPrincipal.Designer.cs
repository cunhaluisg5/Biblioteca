namespace Biblioteca
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuOperacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVisualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOperacoes,
            this.MenuAjuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuOperacoes
            // 
            this.MenuOperacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCadastrar,
            this.MenuItemVisualizar,
            this.toolStripSeparator1,
            this.MenuItemSair});
            this.MenuOperacoes.Name = "MenuOperacoes";
            this.MenuOperacoes.Size = new System.Drawing.Size(75, 20);
            this.MenuOperacoes.Text = "Operações";
            // 
            // MenuAjuda
            // 
            this.MenuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSobre});
            this.MenuAjuda.Name = "MenuAjuda";
            this.MenuAjuda.Size = new System.Drawing.Size(50, 20);
            this.MenuAjuda.Text = "Ajuda";
            // 
            // MenuItemCadastrar
            // 
            this.MenuItemCadastrar.Name = "MenuItemCadastrar";
            this.MenuItemCadastrar.Size = new System.Drawing.Size(180, 22);
            this.MenuItemCadastrar.Text = "Cadastrar Livro";
            this.MenuItemCadastrar.Click += new System.EventHandler(this.MenuItemCadastrar_Click);
            // 
            // MenuItemVisualizar
            // 
            this.MenuItemVisualizar.Name = "MenuItemVisualizar";
            this.MenuItemVisualizar.Size = new System.Drawing.Size(180, 22);
            this.MenuItemVisualizar.Text = "Visualizar Livros";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItemSair
            // 
            this.MenuItemSair.Name = "MenuItemSair";
            this.MenuItemSair.Size = new System.Drawing.Size(180, 22);
            this.MenuItemSair.Text = "Sair";
            // 
            // MenuItemSobre
            // 
            this.MenuItemSobre.Name = "MenuItemSobre";
            this.MenuItemSobre.Size = new System.Drawing.Size(180, 22);
            this.MenuItemSobre.Text = "Sobre";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuOperacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuAjuda;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadastrar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemVisualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSair;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSobre;
    }
}