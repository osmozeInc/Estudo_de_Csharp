class Program
{
    static void Main()
    {
        // array para armazenar respostas
        string[] resposta = new string[4];
        // leitor de tecla do console
        ConsoleKeyInfo confirm;

        while (true)
        {
            Console.Clear();
            Console.Write("Qual seu nome? ");
            resposta[0] = Console.ReadLine();

            Console.Clear();
            Console.Write("Bem vindo, " + resposta[0] + "\nqual sua idade? ");
            resposta[1] = Console.ReadLine();

            Console.Write("Qual seu curso? ");
            resposta[2] = Console.ReadLine();

            Console.Write("Qual seu Professor? ");
            resposta[3] = Console.ReadLine();

            Console.WriteLine("\nConfirme as informações:\n"
                + "\n> Aluno " + resposta[0] + " de " + resposta[1] + " anos "
                + "\n> Matriculado no curso " + resposta[2] + " com o professor " + resposta[3]
                + "\n\nConfirmo (enter) \nRefazer (qualquer tecla)");
            confirm = Console.ReadKey();

            // verifica se a string que armazena a idade pode ser convertida para int
            if (!float.TryParse(resposta[1], out float numero))
            {
                Console.WriteLine("idade inválida, repita");
                Console.ReadLine();
                continue;
            }
            // se a tecla lida for enter encerra o loop
            else if (confirm.Key == ConsoleKey.Enter)
                break;
        }

        
        Cliente cliente = Salvar_Cliente(resposta);

        Console.Clear();
        Console.WriteLine("Cliente salvo!\n"
            + "\nNome: " + cliente.nome
            + "\nIdade: "+ cliente.idade
            + "\nCurso: " + cliente.curso
            + "\nProfessor: " + cliente.professor
            );
    }

    static Cliente Salvar_Cliente(string[] resposta)
    {
        Cliente cliente = new Cliente();
        cliente.nome = resposta[0];
        cliente.idade = Convert.ToInt32(resposta[1]);
        cliente.curso = resposta[2];
        cliente.professor = resposta[3];

        return cliente;
    }

}

 
struct Cliente
{
    public string nome;
    public int idade;
    public string curso;
    public string professor;
}



/* Definir tipos


    Struct:

_declaração:
struct Cliente
{
    public string nome;
    public int idade;
}

_instância:
Cliente c = new Cliente();
    ou
var c = new Cliente();



    Array:

_instância:
string[] array = new string[3];
    ou
int[] array = { "1", "2", "3"};



*/