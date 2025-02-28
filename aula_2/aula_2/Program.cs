namespace aula_2
{
    internal class Program
    {
        // campo de classe
        private static Mercadinho mercadinho = new Mercadinho();


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
        
        // verifica a entrada, o tipo de dado, existencia e quantidade do produto
        static bool Validar_produto(string produto)
        {
            string[] quantidade_produto = produto.Trim().Split(new[] { " " }, 2, StringSplitOptions.RemoveEmptyEntries);

            if (quantidade_produto.Length != 2)
                Console.WriteLine("Erro");

            else if (quantidade_produto[0] == "" || quantidade_produto[1] == "") // verifica se a entrada é vazia
                Console.WriteLine("Digite a quantidade e o produto");

            else if (!float.TryParse(quantidade_produto[0], out float q)) // verifica se a quantidade é um numero
                Console.WriteLine("quantidade inválida");

            else if (!mercadinho.lista_de_produtos.Contains(quantidade_produto[1])) // verifica se o produto existe
                Console.WriteLine("esse produto não existe");

            else if (Convert.ToInt16(quantidade_produto[0]) > mercadinho.quantidade_de_produtos[quantidade_produto[1]]) // verifica se a quantidade do produto é suficiente
                Console.WriteLine("quantidade insuficiente");

            else
            {
                mercadinho.quantidade_de_produtos[quantidade_produto[1]] -= Convert.ToInt16(quantidade_produto[0]);
                return true;
            }

            Thread.Sleep(1000);
            return false;
        }

        // inicializa o mercadinho com seus respectivos valores e propriedades
        static Mercadinho Inicializar_mercado()
        {
            // lista de produtos
            mercadinho.lista_de_produtos = new string[] {"arroz", "feijão", "açúcar", "sal", "macarrão",
                "café", "leite", "manteiga", "pão", "queijo", "presunto", "iogurte", "sabonete",
                "shampoo", "detergente", "guardanapo", "água mineral", "suco", "biscoito", "bolacha"};

            mercadinho.lista_de_precos = new Dictionary<string, float>
            {
                { "arroz", 5.99f }, { "feijão", 8.49f }, { "açúcar", 3.99f }, { "sal", 1.99f },
                { "macarrão", 4.49f }, { "café", 12.99f }, { "leite", 4.79f }, { "manteiga", 6.99f },
                { "pão", 9.99f }, { "queijo", 15.99f }, { "presunto", 14.49f }, { "iogurte", 2.99f },
                { "sabonete", 1.49f }, { "shampoo", 12.99f }, { "detergente", 2.99f }, { "guardanapo", 4.99f },
                { "água mineral", 2.49f }, { "suco", 5.49f }, { "biscoito", 3.99f }, { "bolacha", 4.49f }
            };

            mercadinho.quantidade_de_produtos = new Dictionary<string, int>
            {
                { "arroz", 50 }, { "feijão", 40 }, { "açúcar", 30 }, { "sal", 20 },
                { "macarrão", 60 }, { "café", 25 }, { "leite", 35 }, { "manteiga", 15 },
                { "pão", 100 }, { "queijo", 10 }, { "presunto", 12 }, { "iogurte", 45 },
                { "sabonete", 70 }, { "shampoo", 22 }, { "detergente", 18 }, { "guardanapo", 55 },
                { "água mineral", 80 }, { "suco", 28 }, { "biscoito", 33 }, { "bolacha", 27 }
            };

            mercadinho.produtos_reembolsaveis = new string[] 
            { "café", "leite", "manteiga", "queijo", "presunto", "iogurte" };

            return mercadinho;
        }


        /* funções principais */

        // menu com as opções de ações
        static int Menu()
        {
            Console.Clear();
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


        static int Realizar_acao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Montar_carrinho();
                    break;
                case 2:
                    Tentar_reembolso();
                    break;
                case 3:
                    Listar_produtos();
                    break;
                case 4:
                    Console.WriteLine();
                    return 4;
                default:
                    Console.WriteLine("você foi expulso da loja\nGAME OVER.");
                    return 4;
            }
            return 0;
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
                    Console.WriteLine("produto adicionado: (" + produto + ")\n");
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
            float total_do_carrinho = 0;

            Console.Clear();
            Console.WriteLine("N\n"
                + "------------------------------------------------\n"
                + "NOTA FISCAL                 Mercadinho do seu Zé\n"
                + "------------------------------------------------\n"
                + "Produto             Qatd.    Vlr.Un    Vlr.Total\n");


            for (int i = 0; i < carrinho.Count; i++)
            {
                string[] quantidade_produto = carrinho[i].Trim().Split(new[] { " " }, 2, StringSplitOptions.RemoveEmptyEntries);
                string produto = quantidade_produto[1];
                int quantidade = Convert.ToInt32(quantidade_produto[0]);
                float preco_do_produto = mercadinho.lista_de_precos[produto];
                float total_por_produto = (preco_do_produto * quantidade);

                Console.WriteLine($"{produto, -15}  {quantidade, 4} {"R$ " + preco_do_produto, 13} {"R$ " + total_por_produto, 12}");
                total_do_carrinho += total_por_produto;
            }

            Console.WriteLine("------------------------------------------------\n"
                + $"Total: {total_do_carrinho, 41:C2}");

            Console.ReadKey();
        }


        static void Tentar_reembolso()
        {
            List<string> prateleira = new List<string>();
            string[] qatd_prod;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("digite a quantitade e o produto que quer devolver\n"
                    + "Ex: (2 cebolas)\n");
                string produto = Console.ReadLine();

                bool confirm = Validar_produto(produto);
                if (!confirm)
                {
                    continue;
                }

                qatd_prod = produto.Trim().Split(new[] { " " }, 2, StringSplitOptions.RemoveEmptyEntries);
                bool reembolso = mercadinho.produtos_reembolsaveis.Contains(qatd_prod[1]);
                if (!reembolso)
                {
                    Console.WriteLine("Produto não reembolsável.");
                    Thread.Sleep(1000);
                    continue;
                }
                else prateleira.Add(produto);

                Console.Clear();
                Console.WriteLine("Produto reembolsado\n"
                    + "\'enter\' Continuar\n"
                    + "\'Esc\' Finalizar");

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape) break;
            }

            Reembolsar(prateleira, Convert.ToInt16(qatd_prod[0]), qatd_prod[1]);
        }


        static void Reembolsar(List<string> prateleira, int quantidade, string produto)
        {
            float total_de_pagamento = 0;

            Console.Clear();
            Console.WriteLine("N\n"
                + "------------------------------------------------\n"
                + "NOTA FISCAL                 Mercadinho do seu Zé\n"
                + "------------------------------------------------\n"
                + "Produto             Qatd.    Vlr.Un    Vlr.Total\n");


            for (int i = 0; i < prateleira.Count; i++)
            {
                float preco_do_produto = mercadinho.lista_de_precos[produto];
                float total_por_produto = (preco_do_produto * quantidade);
                int tamanho_da_palavra = produto.Length;

                Console.WriteLine($"{produto,-15}  {quantidade,4} {"R$ " + preco_do_produto,13} {"R$ " + total_por_produto,12}");
                total_de_pagamento += total_por_produto;
            }

            Console.WriteLine("------------------------------------------------\n"
                + $"Total: {total_de_pagamento,41:C2}");

            Console.ReadKey();
        }


        static void Listar_produtos()
        {
            Console.Clear();
            Console.WriteLine("Produtos disponíveis:\n"
                + $"{"produto",-20} {"Qatd.",-10} {"Preço",10}\n"
                + "----------------------------------------");
            for (int i = 0; i < mercadinho.lista_de_produtos.Length; i++)
            {
                string produto = mercadinho.lista_de_produtos[i];
                int quantidade = mercadinho.quantidade_de_produtos[produto];
                float preco = mercadinho.lista_de_precos[produto];

                Console.WriteLine($"{produto,-20} {quantidade,-10} {preco,10}");
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            mercadinho = Inicializar_mercado();
            int opcao = 0;

            while (opcao != 4)
            {
                opcao = Menu();
                opcao = Realizar_acao(opcao);
            }

        }
    }

    
    struct Mercadinho
    {
        public string[] lista_de_produtos;
        public string[] produtos_reembolsaveis;
        public Dictionary<string, float> lista_de_precos;
        public Dictionary<string, int> quantidade_de_produtos;
    }
}
