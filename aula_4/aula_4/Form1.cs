using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_4
{
    public partial class Form1 : Form
    {
        private int passo = 10; // Velocidade de movimento da cobra


        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Mover;
        }

        private async void Mover(object evento, KeyEventArgs tecla)
        {
            {
                switch (tecla.KeyCode)
                {
                    case Keys.Up:
                        if (snake.Top > 0)
                        {
                            snake.Top -= passo;
                            snake.Image = Properties.Resources.up;
                        }
                        break;
                    case Keys.Down:
                        if (snake.Top < 340)
                        {
                            snake.Top += passo;
                            snake.Image = Properties.Resources.down;
                        }
                        break;
                    case Keys.Left:
                        if (snake.Left > 0)
                        {
                            snake.Left -= passo;
                            snake.Image = Properties.Resources.left;
                        }
                        break;
                    case Keys.Right:
                        if (snake.Left < 361)
                        {
                            snake.Left += passo;
                            snake.Image = Properties.Resources.right;
                        }
                        break;
                }
            }
            await Task.Delay(300);
            Resetar_imagem();
        }

        private void Resetar_imagem()
        {
            snake.Image = Properties.Resources.pers_right;
        }


        private void Form1_Load(object evento, EventArgs tecla)
        {

        }
    }
}





/* README
 * 
 * O KeyDown é um evento que é disparado quando uma tecla do teclado é pressionada.
 * No contexto do Windows Forms, ele está associado ao formulário (Form) ou a controles
 * que podem receber entrada do teclado.
 * 
 * 
 * 
 * 
 * 
 * 
 */