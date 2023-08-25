namespace Pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, continua = "S";
            int idade, esporte, futebol = 0, voleibolMai18 = 0, basquetebolMen18 = 0;

            do
            {

                Console.WriteLine("Digite o seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite o seu esporte favorito (1-Fut/2-Vol/3-Basq/4-Outros): ");
                    esporte = Convert.ToInt32(Console.ReadLine());
                } while (esporte < 1 || esporte > 4);

                if (esporte == 1)
                    futebol++;

                if (esporte == 2 && idade > 18)
                    voleibolMai18++;

                if (esporte == 3 && idade < 18)
                    basquetebolMen18++;

                Console.WriteLine("Deseja Continuar (S/N): ");
                continua = Console.ReadLine().ToUpper();

            } while (continua.Equals("S"));

            Console.WriteLine($"Total de pessoas que gostam de futebol: {futebol}");
            Console.WriteLine($"Total de pessoas que gostam de voleibol maiores de 18 anos: {voleibolMai18}");
            Console.WriteLine($"Total de pessoas que gostam de basquetebol menores de 18 anos: {basquetebolMen18}");
        }
    }
}