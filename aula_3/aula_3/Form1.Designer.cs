namespace aula_3
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
            this.input = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.mais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.input.Location = new System.Drawing.Point(12, 12);
            this.input.Name = "input";
            this.input.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.input.Size = new System.Drawing.Size(230, 38);
            this.input.TabIndex = 3;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn0.Location = new System.Drawing.Point(12, 312);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(112, 52);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.equal.Location = new System.Drawing.Point(130, 312);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(53, 52);
            this.equal.TabIndex = 11;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.div.Location = new System.Drawing.Point(189, 312);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(53, 52);
            this.div.TabIndex = 12;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mult.Location = new System.Drawing.Point(189, 254);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(53, 52);
            this.mult.TabIndex = 16;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn2.Location = new System.Drawing.Point(71, 254);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 52);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // menos
            // 
            this.menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.menos.Location = new System.Drawing.Point(189, 196);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(53, 52);
            this.menos.TabIndex = 20;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = true;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn6.Location = new System.Drawing.Point(130, 196);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 52);
            this.btn6.TabIndex = 19;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn5.Location = new System.Drawing.Point(71, 196);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 52);
            this.btn5.TabIndex = 18;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn4.Location = new System.Drawing.Point(12, 196);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 52);
            this.btn4.TabIndex = 17;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn9.Location = new System.Drawing.Point(130, 138);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 52);
            this.btn9.TabIndex = 23;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn8.Location = new System.Drawing.Point(71, 138);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 52);
            this.btn8.TabIndex = 22;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn7.Location = new System.Drawing.Point(12, 138);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 52);
            this.btn7.TabIndex = 21;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.clear.Location = new System.Drawing.Point(189, 80);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(53, 52);
            this.clear.TabIndex = 28;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button23.Location = new System.Drawing.Point(130, 80);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(53, 52);
            this.button23.TabIndex = 27;
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button24.Location = new System.Drawing.Point(71, 80);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(53, 52);
            this.button24.TabIndex = 26;
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button25.Location = new System.Drawing.Point(12, 80);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(53, 52);
            this.button25.TabIndex = 25;
            this.button25.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn1.Location = new System.Drawing.Point(12, 254);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 52);
            this.btn1.TabIndex = 29;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn3.Location = new System.Drawing.Point(130, 254);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 52);
            this.btn3.TabIndex = 30;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // mais
            // 
            this.mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mais.Location = new System.Drawing.Point(190, 138);
            this.mais.Name = "mais";
            this.mais.Size = new System.Drawing.Size(53, 52);
            this.mais.TabIndex = 31;
            this.mais.Text = "+";
            this.mais.UseVisualStyleBackColor = true;
            this.mais.Click += new System.EventHandler(this.mais_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 383);
            this.Controls.Add(this.mais);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.div);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button mais;
    }
}

