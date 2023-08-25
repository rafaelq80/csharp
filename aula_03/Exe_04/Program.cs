namespace Exe_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? palavra1, palavra2, palavra3;

            Console.WriteLine("Digite a primeira palavra: ");
            palavra1 = Console.ReadLine();

            Console.WriteLine("Digite a segunda palavra: ");
            palavra2 = Console.ReadLine(); 
            
            Console.WriteLine("Digite a terceira palavra: ");
            palavra3 = Console.ReadLine();

            if(palavra1 is not null && palavra2 is not null && palavra3 is not null)
            {
                // Verificando se é Vertebrado ou Invertebrado
                if (palavra1.Equals("vertebrado"))
                {
                    /* Verificando se é Ave ou Mamífero */
                    if (palavra2.Equals("ave"))
                    {
                        if (palavra3.Equals("carnivoro"))
                        {
                            Console.WriteLine("Águia");
                        }
                        else
                        {
                            Console.WriteLine("Pomba");
                        }
                    }
                    else
                    {
                        if (palavra3.Equals("onivoro"))
                        {
                            Console.WriteLine("Homem");
                        }
                        else
                        {
                            Console.WriteLine("Vaca");
                        }
                    }
                }
                else
                {
                    /* Verificando se é Inseto ou Anelídeo */
                    if (palavra2.Equals("inseto"))
                    {
                        if (palavra3.Equals("hematofago"))
                        {
                            Console.WriteLine("Pulga");
                        }
                        else
                        {
                            Console.WriteLine("Lagarta");
                        }
                    }
                    else
                    {
                        if (palavra3.Equals("onivoro"))
                        {
                            Console.WriteLine("Minhoca");
                        }
                        else
                        {
                            Console.WriteLine("Sanguessuga");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("As palavras não podem ser nulas!");
            }

        }
    }
}