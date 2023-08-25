namespace Tabuada_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 1;

            Console.WriteLine("Digite a Tabuada:");
            numero = Convert.ToInt32(Console.ReadLine());

            while(contador <= 10)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                contador ++;
            }
        }
    }
}