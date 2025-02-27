using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace aula_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            erro_email.Visible = false;
            label2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string regex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            erro_email.Visible = false;                 // recebe false antes de verificar a cada mudança

            if (!Regex.IsMatch(texto, regex))
            {
                erro_email.Visible = true;
            }
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            bool erro = erro_email.Visible;
            bool termo = termos.Checked;

            if (termo == true && texto != "" && erro == false)
            {
                EnviarEmail();
            }
        }

        private void EnviarEmail()
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            MailMessage mailMessage = new MailMessage();

            client.EnableSsl = true; // Usar SSL/TLS
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(RetornarValores("email"), RetornarValores("senha"));
            
            mailMessage.From = new MailAddress(RetornarValores("email"));
            mailMessage.To.Add(textBox1.Text);
            mailMessage.IsBodyHtml = false;
            
            mailMessage.Subject = "Cadastro";
            mailMessage.Body = "Cadastro realizado com sucesso!";

            client.Send(mailMessage);
            label2.Visible = true;
        }

        private string RetornarValores(string valores)
        {
            if (valores == "email")
            {
                return "caiomm076@gmail.com";
            }
            if (valores == "senha")
            {
                return "gbsz jjpc bzhb esaq";
            }
            else
            return "";
        }
    }
}


// conta.de.teste.caio@gmail.com