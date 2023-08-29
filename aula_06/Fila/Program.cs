namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            // Insere dados na fila
            fila.Enqueue("Breno");
            fila.Enqueue("Eduardo");
            fila.Enqueue("Julia");
            fila.Enqueue("Leonardo");
            fila.Enqueue("Gaspar");

            // Retira o primeiro dado inserido na fila 
            fila.Dequeue();

            // Lista os elementos da fila
            foreach (var nome in fila)
            {
                Console.WriteLine(nome);
            }

            // Exibe o primeiro elemento da fila
            Console.WriteLine("Quem é o primeiro da fila? " + fila.Peek());

            // Checa se um elemento existe na fila
            Console.WriteLine("O Gaspar entrou na fila? " + fila.Contains("Gaspar"));

            // Mostra o numero de elementos na fila
            Console.WriteLine("Numero de pessoas na fila: " + fila.Count);
        }
    }
}