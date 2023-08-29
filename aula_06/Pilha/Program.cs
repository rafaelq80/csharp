namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            // Insere dados na pilha
            pilha.Push("Breno");
            pilha.Push("Eduardo");
            pilha.Push("Julia");
            pilha.Push("Leonardo");
            pilha.Push("Gaspar");

            // Retira o ultimo dado inserido na pilha
            pilha.Pop();

            // Lista os elementos da pilha
            foreach (var nome in pilha)
            {
                Console.WriteLine(nome);
            }

            // Exibe o último dado na pilha
            Console.WriteLine("Quem é o último elemento da pilha? " + pilha.Peek());

            // Checa se um elemento existe na pilha
            Console.WriteLine("O Gaspar faz parte da pilha? " + pilha.Contains("Gaspar"));

            // Mostra o numero de elementos na pilha
            Console.WriteLine("Numero de pessoas estão na pilha: " + pilha.Count);
        }
    }
}