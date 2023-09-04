namespace Funcionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente g1 = new Gerente(6000.00F, "Gerente", "Pedro", 0.10F);
            Console.WriteLine($"Calcular Salário do Gerente: {g1.CalcularSalario()}");

            Vendedor v1 = new Vendedor(2500, "Vendedor", "Pedro", 10000.00F);
            Console.WriteLine($"Calcular Salário do Vendedor: {v1.CalcularSalario()}");

            OperadorCaixa op1 = new OperadorCaixa(2500.00F, "Operador de Caixa", "Pedro");
            Console.WriteLine($"Calcular Salário do Operador de Caixa: {op1.CalcularSalario()}");
        }
    }
}