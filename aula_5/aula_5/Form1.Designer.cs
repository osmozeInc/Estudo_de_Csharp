namespace aula_5
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
            this.button1 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.tbx_user = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_erro = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(272, 200);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(38, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Senha";
            // 
            // tbx_user
            // 
            this.tbx_user.Location = new System.Drawing.Point(348, 124);
            this.tbx_user.Name = "tbx_user";
            this.tbx_user.Size = new System.Drawing.Size(100, 20);
            this.tbx_user.TabIndex = 3;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(348, 193);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(100, 20);
            this.tbx_password.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // lb_erro
            // 
            this.lb_erro.AutoSize = true;
            this.lb_erro.ForeColor = System.Drawing.Color.Red;
            this.lb_erro.Location = new System.Drawing.Point(348, 220);
            this.lb_erro.Name = "lb_erro";
            this.lb_erro.Size = new System.Drawing.Size(10, 13);
            this.lb_erro.TabIndex = 7;
            this.lb_erro.Text = " ";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(272, 131);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(43, 13);
            this.user.TabIndex = 8;
            this.user.Text = "Usuário";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user);
            this.Controls.Add(this.lb_erro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_user);
            this.Controls.Add(this.password);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox tbx_user;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_erro;
        private System.Windows.Forms.Label user;
    }
}

