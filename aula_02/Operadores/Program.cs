namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 8;
            int z = 6;
            int w = 4;
            int i = 40;
            int j = 30;
            int k = 20;
            int l = 10;
            int m = 5;

            Console.WriteLine("\nTransformar em Número negativo: " + (-m));

            Console.WriteLine("\nPré Incrementar: x = ++ y");

            x = ++y;

            Console.WriteLine("\nValor de X: " + x);
            Console.WriteLine("\nValor de Y: " + y);

            Console.WriteLine("\nPré Decrementar: z = -- w");

            z = --w;

            Console.WriteLine("\nValor de Z: " + z);
            Console.WriteLine("\nValor de W: " + w);

            Console.WriteLine("\nPós Incrementar: i = j ++");

            i = j++;

            Console.WriteLine("\nValor de I: " + i);
            Console.WriteLine("\nValor de J: " + j);

            Console.WriteLine("\nPós Decrementar: k = l --");

            k = l--;

            Console.WriteLine("\nValor de K: " + k);
            Console.WriteLine("\nValor de L: " + l);
        }
    }
}