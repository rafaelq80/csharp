using Microsoft.VisualBasic;

namespace Matematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABS 9 = " + Math.Abs(9));
            Console.WriteLine("ABS 0 = " + Math.Abs(0));
            Console.WriteLine("ABS -9 = " + Math.Abs(-9));
            
            Console.WriteLine("Ceiling 9.2 = " + Math.Ceiling(9.2));
            Console.WriteLine("Ceiling -9.8 = " + Math.Ceiling(-9.8));
            
            Console.WriteLine("Floor 9.2 = " + Math.Floor(9.2));
            Console.WriteLine("Floor -9.8 = " + Math.Floor(-9.8));
            
            Console.WriteLine("Seno 15 = " + Math.Sin(15));
            Console.WriteLine("Seno 30 = " + Math.Sin(30));
            Console.WriteLine("Seno 45 = " + Math.Sin(45));

            Console.WriteLine("Cosseno 15 = " + Math.Cos(15));
            Console.WriteLine("Cosseno 30 = " + Math.Cos(30));
            Console.WriteLine("Cosseno 45 = " + Math.Cos(45));

            Console.WriteLine("Tangente 15 = " + Math.Tan(15));
            Console.WriteLine("Tangente 30 = " + Math.Tan(30));
            Console.WriteLine("Tangente 45 = " + Math.Tan(45));
            
            Console.WriteLine("Logaritmo 2.718282 = " + Math.Log(2.718282));
            Console.WriteLine("Logaritmo 2.718282 base 10 = " + Math.Log(2.718282, 10));

            Console.WriteLine("Raíz Quadrada 900 = " + Math.Sqrt(900));
            Console.WriteLine("Raíz Cúbica 8 = " + Math.Cbrt(8));

            Console.WriteLine("Potência 3 ao quadrado = " + Math.Pow(3, 2));
            Console.WriteLine("Raíz quarta = " + Math.Pow(16, 0.25));

            Console.WriteLine("Constante PI = " + Math.PI);

            Console.WriteLine("Round 9.1560 = " + Math.Round(9.1560F));
            Console.WriteLine("Round -9.1560 com 2 Cassas Decimais = " + Math.Round(-9.1560, 2));
        }
    }
}