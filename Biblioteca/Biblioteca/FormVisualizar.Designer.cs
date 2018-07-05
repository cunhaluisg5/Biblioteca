namespace Biblioteca
{
    partial class FormVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizar));
            this.label1 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.textoDados = new System.Windows.Forms.RichTextBox();
            this.limpar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busque todos os livros cadastrados";
            // 
            // buscar
            // 
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Image = ((System.Drawing.Image)(resources.GetObject("buscar.Image")));
            this.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscar.Location = new System.Drawing.Point(482, 25);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(124, 59);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "Buscar";
            this.buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // textoDados
            // 
            this.textoDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDados.Location = new System.Drawing.Point(40, 90);
            this.textoDados.Name = "textoDados";
            this.textoDados.Size = new System.Drawing.Size(715, 261);
            this.textoDados.TabIndex = 2;
            this.textoDados.Text = "";
            // 
            // limpar
            // 
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Image = ((System.Drawing.Image)(resources.GetObject("limpar.Image")));
            this.limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limpar.Location = new System.Drawing.Point(40, 368);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(118, 57);
            this.limpar.TabIndex = 3;
            this.limpar.Text = "Limpar";
            this.limpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.limpar.UseVisualStyleBackColor = true;
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Image = ((System.Drawing.Image)(resources.GetObject("sair.Image")));
            this.sair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sair.Location = new System.Drawing.Point(637, 368);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(118, 57);
            this.sair.TabIndex = 4;
            this.sair.Text = "Sair";
            this.sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sair.UseVisualStyleBackColor = true;
            // 
            // FormVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.textoDados);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Livros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.RichTextBox textoDados;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button sair;
    }
}