namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero, numero2, divisao;

            Console.WriteLine("Digite o primeiro número:");
            numero = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = Convert.ToSingle(Console.ReadLine());

            divisao = numero / numero2;

            Console.WriteLine($"{numero} + {numero2} = " + (numero + numero2));
            Console.WriteLine($"{numero} - {numero2} = " + (numero - numero2));
            Console.WriteLine($"{numero} * {numero2} = " + (numero * numero2));

            if (numero2 > 0)
                Console.WriteLine("{0:F} / {1:F} = {2:F2}", numero, numero2, divisao);
            else
                Console.WriteLine("Não existe Divisão por zero");
            
           // Console.WriteLine(Math.Round(divisao, 2));
            Console.WriteLine($"{numero} ^ {numero2} = " + Math.Pow(numero, numero2));
            Console.WriteLine($"Raiz quadrada de {numero} = " + Math.Sqrt(numero));

        }
    }
}
