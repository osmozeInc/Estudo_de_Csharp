using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_3
{
    public partial class Form1 : Form
    {
        float[] entradas = new float[20];
        string[] operadores = new string[20];
        int cont = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + "9";
        }

        private void mais_Click(object sender, EventArgs e)
        {
            armazenar_entradas("+");
            input.Text = "";
        }

        private void menos_Click(object sender, EventArgs e)
        {
            armazenar_entradas("-");
            input.Text = "";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            armazenar_entradas("*");
            input.Text = "";
        }

        private void div_Click(object sender, EventArgs e)
        {
            armazenar_entradas("/");
            input.Text = "";
        }

        public void armazenar_entradas(string operador)
        {
            entradas[cont] = Convert.ToSingle(input.Text);
            operadores[cont] = operador;
            cont++;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = "";
            entradas = new float[20];
            operadores = new string[20];
            cont = 0;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            float resultado = entradas[0];

            armazenar_entradas("=");

            for (int i = 1, j = 0; i <= cont; i++, j++)
            {
                if (operadores[j] == "+")
                {
                    resultado += entradas[i];
                }
                else if (operadores[j] == "-")
                {
                    resultado -= entradas[i];
                }
                else if (operadores[j] == "/")
                {
                    resultado = resultado / entradas[i];
                }
                else if (operadores[j] == "*")
                {
                    Console.WriteLine("operação de menos\n"
                        + "\noperador: " + operadores[j]
                        + "\nr: " + resultado * entradas[i]
                        + "\nn1: " + entradas[0]
                        + "\nn2: " + entradas[i]
                        + "\ncont: " + cont);
                    resultado = resultado * entradas[i];
                }
                else if (operadores[j] == "=")
                {
                    input.Text = Convert.ToString(resultado);
                }
            }
        }
    }
}
