namespace aula_2
{
    internal class Program
    {
        string[] lista_de_produtos = { "laranja", "uva" };

        /* funções alxiliares */

        // recebe o valor da entrada e só aceita se for um numero inteiro
        static int Receber_e_validar_entrada()
        {
            string resposta;
            float result;
            do
            {
                Console.Write("> ");
                resposta = Console.ReadLine();

                if (!float.TryParse(resposta, out result))
                {
                Console.WriteLine("\nresposta inválida, repita");
                }
                else break;
            }
            while (true);
            return Convert.ToInt16(result);
        }
        
        static bool Validar_produto(string produto)
        {
            Mercadinho mercadinho = Inicializar_mercado(new Mercadinho());
            string[] quantidade_produto = produto.Split(' ');

            if (quantidade_produto[0] == null || quantidade_produto[1] == null)
                Console.WriteLine("Digite algum produto");

            else if (!float.TryParse(quantidade_produto[0], out float quantidade))
                Console.WriteLine("quantidade inválida");

            else if (!mercadinho.lista_de_produtos.Contains(quantidade_produto[1]))
                Console.WriteLine("esse produto não existe");

            else return true;

            return false;
        }

        static Mercadinho Inicializar_mercado(Mercadinho mercadinho)
        {
            mercadinho.lista_de_produtos = new string[] {"laranja", "uva"};
            return mercadinho;
        }


        /* funções principais */

        // menu com as opções de ações
        static int Menu()
        {
            Console.WriteLine("Bem vindo a loja do seu zé.");

            while (true)
            {
                Console.WriteLine("o que deseja?\n"
                    + "1 - Comprar\n"
                    + "2 - Reembolso\n"
                    + "3 - Ver Produtos\n"
                    + "4 - Sair\n");
                return Receber_e_validar_entrada();
            }
        }

        static void Realizar_acao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Montar_carrinho();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("você foi expulso da loja\nGAME OVER.");
                    return;
            }
        }

        static void Montar_carrinho()
        {

            List<string> carrinho = new List<string>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("digite a quantitade e o produto que quer\n"
                    + "Ex: (2 cebolas)\n");
                string produto = Console.ReadLine();
                bool confirm = Validar_produto(produto);


                if (!confirm)
                {
                    continue;
                }
                else if (confirm)
                {
                    Console.Clear();
                    Console.WriteLine("produto adicionado: (" + produto + ")");
                    carrinho.Add(produto);
                }
                
                Console.WriteLine("continuar comprando?\n"
                    + "\'enter\' continuar com o carrinho\n"
                    + "\'Esc\' para finalizar");

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape) break;
            }

            Pagar(carrinho);
        }


        static void Pagar(List<string> carrinho)
        {
            Console.Clear();
            Console.WriteLine("\no seu carrinho é:");

            for (int i = 0; i < carrinho.Count; i++)
            {
                Console.WriteLine(carrinho[i]);
            }
        }


        static void Main(string[] args)
        {
            int opcao = Menu();
            Realizar_acao(opcao);
        }
    }

    
    struct Mercadinho
    {
        public string[] lista_de_produtos;
    }

}
