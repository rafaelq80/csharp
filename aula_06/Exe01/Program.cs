namespace Exe01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<string> pilha = new Stack<string>();

            int opcao;

            string titulo;

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("**********************************************");
                Console.WriteLine("                                              ");
                Console.WriteLine("       1 - Adicionar Livro na Pilha           ");
                Console.WriteLine("       2 - Listar todos os  Livros da Pilha   ");
                Console.WriteLine("       3 - Retirar Livro da Pilha             ");
                Console.WriteLine("       0 - Sair                               ");
                Console.WriteLine("                                              ");
                Console.WriteLine("**********************************************");
                Console.WriteLine("Entre com a opção desejada:                   ");
                Console.WriteLine("                                              ");
                Console.ResetColor();

                opcao = Convert.ToInt32(Console.ReadLine());

                if(opcao == 0)
                {
                    Console.WriteLine("\nPrograma foi finalizado!");
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o Título do Livro: ");
                        titulo = Console.ReadLine();

                        pilha.Push(titulo);

                        Console.WriteLine("O Livro foi Adicionado com Sucesso!");
                        break;
                    case 2:
                        Console.WriteLine("Lista de Livros");

                        foreach(var livro in pilha)
                        {
                            Console.WriteLine(livro);
                        }
                        break;

                    case 3:

                        if (pilha.Count == 0)
                        {
                            Console.WriteLine("A Pilha está Vazia!");
                        }
                        else
                        {
                            pilha.Pop();
                            Console.WriteLine("O Livro foi Retirado com Sucesso!");
                        }

                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }
        }
    }
}