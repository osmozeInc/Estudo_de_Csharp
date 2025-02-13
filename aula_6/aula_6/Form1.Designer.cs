namespace aula_6
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
            this.lb_maca = new System.Windows.Forms.Label();
            this.pic_maca = new System.Windows.Forms.PictureBox();
            this.pic_personagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_maca
            // 
            this.lb_maca.AutoSize = true;
            this.lb_maca.ForeColor = System.Drawing.Color.Lime;
            this.lb_maca.Location = new System.Drawing.Point(436, 171);
            this.lb_maca.Name = "lb_maca";
            this.lb_maca.Size = new System.Drawing.Size(10, 13);
            this.lb_maca.TabIndex = 2;
            this.lb_maca.Text = " ";
            // 
            // pic_maca
            // 
            this.pic_maca.Image = global::aula_6.Properties.Resources.rz3done;
            this.pic_maca.Location = new System.Drawing.Point(410, 190);
            this.pic_maca.Name = "pic_maca";
            this.pic_maca.Size = new System.Drawing.Size(30, 30);
            this.pic_maca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_maca.TabIndex = 1;
            this.pic_maca.TabStop = false;
            // 
            // pic_personagem
            // 
            this.pic_personagem.Image = global::aula_6.Properties.Resources.character;
            this.pic_personagem.Location = new System.Drawing.Point(0, 0);
            this.pic_personagem.Name = "pic_personagem";
            this.pic_personagem.Size = new System.Drawing.Size(50, 50);
            this.pic_personagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_personagem.TabIndex = 0;
            this.pic_personagem.TabStop = false;
            this.pic_personagem.Click += new System.EventHandler(this.pic_personagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(714, 441);
            this.Controls.Add(this.lb_maca);
            this.Controls.Add(this.pic_maca);
            this.Controls.Add(this.pic_personagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_maca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_personagem;
        private System.Windows.Forms.PictureBox pic_maca;
        private System.Windows.Forms.Label lb_maca;
    }
}

