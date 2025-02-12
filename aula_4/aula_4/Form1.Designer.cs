namespace aula_4
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.snake = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.snake)).BeginInit();
            this.SuspendLayout();
            // 
            // snake
            // 
            this.snake.BackColor = System.Drawing.Color.Transparent;
            this.snake.Image = global::aula_4.Properties.Resources.pers_right;
            this.snake.Location = new System.Drawing.Point(102, 169);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(100, 100);
            this.snake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snake.TabIndex = 0;
            this.snake.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.snake);
            this.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.snake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox snake;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

