using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace aula_5
{
    public partial class Form1 : Form
    {
        string conexao = "Data Source=meuBanco.sqlite;Version=3;";

        public Form1()
        {
            InitializeComponent();
            SQLiteConnection.CreateFile("meuBanco.sqlite");
            using (SQLiteConnection conn = new SQLiteConnection(conexao))
            {
                conn.Open();

                DbCriarTabela(conn);
                DbInserirNaTabela(conn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entrada_usuario = tbx_user.Text;
            string entrada_senha = tbx_password.Text;
            string senha_correta = DbBuscarSenha(entrada_usuario);
            string erro = "senha incorreta";


            if (entrada_senha == senha_correta)
            {
                Form2 f = new Form2(entrada_usuario);
                f.Show();
            }
            else
            {
                lb_erro.Text = erro;
            }
        }

        private void DbCriarTabela(SQLiteConnection conn)
        {
            string comando = @"CREATE TABLE IF NOT EXISTS Usuarios(
                            Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                            User TEXT NOT NULL UNIQUE, 
                            Password TEXT NOT NULL)";

            using (SQLiteCommand cmd = new SQLiteCommand(comando, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void DbInserirNaTabela(SQLiteConnection conn)
        {
            string comando = @"INSERT INTO Usuarios (User, Password) VALUES (@user, @password)";

            using (SQLiteCommand cmd = new SQLiteCommand(comando, conn))
            {
                cmd.Parameters.AddWithValue("@user", "caio");
                cmd.Parameters.AddWithValue("@password", "123");
                cmd.ExecuteNonQuery();
            }
        }

        private string DbBuscarSenha(string usuario)
        {
            string comando = "SELECT Password FROM Usuarios WHERE User = @usuario";
            string senha = "oi";
            using (SQLiteConnection conn = new SQLiteConnection(conexao))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(comando, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        senha = result.ToString();
                    }
                }
            }

            return senha;
        }
    }
}
