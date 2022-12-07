namespace desafio2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.emoji = new System.Windows.Forms.PictureBox();
            this.botao1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emoji)).BeginInit();
            this.SuspendLayout();
            // 
            // emoji
            // 
            this.emoji.Image = ((System.Drawing.Image)(resources.GetObject("emoji.Image")));
            this.emoji.Location = new System.Drawing.Point(188, 99);
            this.emoji.Name = "emoji";
            this.emoji.Size = new System.Drawing.Size(516, 475);
            this.emoji.TabIndex = 0;
            this.emoji.TabStop = false;
            this.emoji.Click += new System.EventHandler(this.emoji_click);
            // 
            // botao1
            // 
            this.botao1.BackColor = System.Drawing.Color.Chartreuse;
            this.botao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao1.Location = new System.Drawing.Point(214, 12);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(119, 50);
            this.botao1.TabIndex = 1;
            this.botao1.Text = "clique";
            this.botao1.UseVisualStyleBackColor = false;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 617);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.emoji);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.emoji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox emoji;
        private System.Windows.Forms.Button botao1;
    }
}

