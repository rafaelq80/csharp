using debug.Namespace01;

namespace debug
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int indice = 0; indice < 10; indice++)
            {
                Console.WriteLine($"vetor01[{indice}] = {vetor01[indice]}");
            }

            Classe01.Teste01();
            Classe02.Teste02();
          
        }
    }
}
