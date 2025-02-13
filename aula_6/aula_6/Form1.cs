using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_6
{
    public partial class Form1 : Form
    {
        Personagem p = new Personagem(Velocidade: 15);
        Maca m = new Maca(Posicao_x: 380,Posicao_y: 160);

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += mover;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

            public async void mover(object evento, KeyEventArgs tecla)
            {
                switch (tecla.KeyCode)
                {
                    case Keys.W:
                        if (pic_personagem.Top >= 10)
                        {
                         pic_personagem.Top -= p.velocidade;
                        }
                        break;
                    case Keys.S:
                        if (pic_personagem.Top <= 380)
                        {
                            pic_personagem.Top += p.velocidade;
                        }
                        break;
                case Keys.A:
                    if (pic_personagem.Left >= 10)
                    {
                        pic_personagem.Left -= p.velocidade;
                    }
                    break;
                case Keys.D:
                    if (pic_personagem.Left <= 650)
                    {
                        pic_personagem.Left += p.velocidade;
                    }
                    break;
                case Keys.E:
                    int espaco_x = pic_personagem.Left - m.posicao_x;
                    int espaco_y = pic_personagem.Top - m.posicao_y;
                    if (espaco_x > 0 && espaco_x < 70 && espaco_y > 0 && espaco_y < 70)
                    {
                        pic_maca.Visible = false;
                        lb_maca.Text = "+ 25 HP";
                        p.hp += 25;
                        await Task.Delay(1000);
                        lb_maca.Visible = false;
                    }
                    break;
                        
            }
            }
        struct Personagem
        {
            public int posicao_x;
            public int posicao_y;
            public int velocidade;
            public int hp;

            public Personagem(int Velocidade)
            {
                this.posicao_x = 0;
                this.posicao_y = 0;
                this.velocidade = Velocidade;
                this.hp = 180;
            }
        }

        public struct Maca
        {
            public int posicao_x;
            public int posicao_y;
            public int tamanho;
            public int hp;

            public Maca(int Posicao_x, int Posicao_y)
            {
                this.posicao_x = Posicao_x;
                this.posicao_y = Posicao_y;
                this.tamanho = 60;
                this.hp = 25;
            }
        }

        private void pic_personagem_Click(object sender, EventArgs e)
        {

        }
    }
}
