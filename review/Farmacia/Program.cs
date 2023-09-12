using Farmacia.Model;
using System;

namespace farmacia
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {
            int opcao;

            /*Produto p1 = new Produto();

            Produto p2 = new Produto(1, "Paracetamol", 1, 20.00M);

            Produto p3 = new Produto("Paracetamol", 1, 20.00M);

            p1.Visualizar();
            p2.Visualizar();
            p3.Visualizar();*/

            while (true)
            {

                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("                Farmácia Bem Estar                   ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("            1 - Criar Produto                        ");
                Console.WriteLine("            2 - Listar todos os Produtos             ");
                Console.WriteLine("            3 - Buscar Produto por Id                ");
                Console.WriteLine("            4 - Atualizar Dados do Produto           ");
                Console.WriteLine("            5 - Apagar Produto                       ");
                Console.WriteLine("            6 - Sair                                 ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Entre com a opção desejada:                          ");
                Console.WriteLine("                                                     ");

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 6)
                {
                    Console.WriteLine("\n Farmácia Bem Estar - Remédio barato é aqui!");
                    Sobre();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Criar Produto\n\n");

                        KeyPress();
                        break;
                    case 2:
                        Console.WriteLine("Listar todos os Produtos\n\n");

                        KeyPress();
                        break;
                    case 3:
                        Console.WriteLine("Consultar dados do Produto - por Id\n\n");

                        KeyPress();
                        break;
                    case 4:
                        Console.WriteLine("Atualizar dados do Produto\n\n");

                        KeyPress();
                        break;
                    case 5:
                        Console.WriteLine("Apagar o Produto\n\n");

                        KeyPress();
                        break;
                    default:
                        Console.WriteLine("\nOpção Inválida!\n");
                        break;
                }
            }
        }

        static void Sobre()
        {
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Projeto Desenvolvido por: ");
            Console.WriteLine("Generation Brasil - generation@generation.org");
            Console.WriteLine("github.com/conteudoGeneration");
            Console.WriteLine("*********************************************************");
        }

        static void KeyPress()
        {
            do
            {
                Console.Write("\nPressione Enter para Continuar...\"");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }
    }
}