namespace Atribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x, y, z;

            Console.WriteLine("Digite um numero inteiro para a variável x:");
            x = Convert.ToInt32(Console.ReadLine());
                        
            Console.WriteLine("Digite um numero inteiro para a variável y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um numero inteiro para a variável z:");
            z = Convert.ToInt32(Console.ReadLine());
            
            z = y;
            Console.WriteLine("Atribuição simples (z = y): " + z);

            x += y; // x = x  + y
            Console.WriteLine("\nAtribuição com soma (x = x + y): " + x);

            x -= z;
            Console.WriteLine("\nAtribuição com subtração (x = x - z): " + x);
            
            x *= y;
            Console.WriteLine("\nAtribuição com multiplicação (x = x * y): " + x);

            z /= y;
            Console.WriteLine("\nAtribuição com divisão (z = z / y): " + z);

            x %= y;
            Console.WriteLine("\nAtribuição com o Módulo (x = x % y): " + x);
        }
    }
}