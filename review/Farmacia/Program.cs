using Farmacia.Controller;
using Farmacia.Model;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace farmacia
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {
            int opcao, id, tipo;
            decimal preco;
            string? nome, generico, fragancia;

            ProdutoController produtos = new();

            Medicamento m1 = new Medicamento(produtos.GerarId(), "Paracetamol 750mg", 1, 20.00M, "Paracetamol");
            produtos.Cadastrar(m1);

            Cosmetico m2 = new Cosmetico(produtos.GerarId(), "Sabonete Infantil", 1, 25.00M, "Neutro");
            produtos.Cadastrar(m2);

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

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite uma valor inteiro entre 1 e 9");
                    opcao = 0;
                    Console.ResetColor();
                }

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

                        Console.WriteLine("Digite o Nome do Produto: ");
                        nome = Console.ReadLine();

                        nome ??= string.Empty;

                        do
                        {
                            Console.WriteLine("Digite o Tipo do Produto: ");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        } while (tipo != 1 && tipo != 2);

                        Console.WriteLine("Digite o Preço do Produto: ");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Digite o Nome Genérico: ");
                                generico = Console.ReadLine();

                                generico ??= string.Empty;

                                produtos.Cadastrar(new Medicamento(produtos.GerarId(), nome, tipo, preco, generico));
                                break;
                            case 2:
                                Console.WriteLine("Digite o Nome Genérico: ");
                                fragancia = Console.ReadLine();

                                fragancia ??= string.Empty;

                                produtos.Cadastrar(new Medicamento(produtos.GerarId(), nome, tipo, preco, fragancia));
                                break;
                        }

                        KeyPress();
                        break;
                    case 2:
                        Console.WriteLine("Listar todos os Produtos\n\n");

                        produtos.ListarTodas();

                        KeyPress();
                        break;
                    case 3:
                        Console.WriteLine("Consultar dados do Produto - por Id\n\n");

                        Console.WriteLine("Digite o Id do Produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        produtos.ProcurarPorId(id);

                        KeyPress();
                        break;
                    case 4:
                        Console.WriteLine("Atualizar dados do Produto\n\n");

                        Console.WriteLine("Digite o Id do Produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        var produto = produtos.BuscarNaCollection(id);

                        if (produto is not null)
                        {
                            Console.WriteLine("Digite o Nome do Produto: ");
                            nome = Console.ReadLine();

                            nome ??= string.Empty;

                            tipo = produto.Tipo;

                            Console.WriteLine("Digite o Preço do Produto: ");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("Digite o Nome Genérico: ");
                                    generico = Console.ReadLine();

                                    generico ??= string.Empty;

                                    produtos.Atualizar(new Medicamento(id, nome, tipo, preco, generico));

                                    break;
                                case 2:
                                    Console.WriteLine("Digite o Nome Genérico: ");
                                    fragancia = Console.ReadLine();

                                    fragancia ??= string.Empty;

                                    produtos.Atualizar(new Medicamento(id, nome, tipo, preco, fragancia));

                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"O Produto não foi encontrada!");
                        }

                        KeyPress();
                        break;
                    case 5:
                        Console.WriteLine("Apagar o Produto\n\n");

                        Console.WriteLine("Digite o Id do Produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        produtos.Deletar(id);

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