namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria o Hshset e inicializa com dados
            HashSet<string> setNomes = new HashSet<string>()
            {
                "Allan",
                "Robson",
                "João",
                "Ingrid",
                "Allan",
                "Robson",
            };

            // Lista os Elementos do HashSet
            foreach(var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            // Adiciona Elementos no HashSet
            setNomes.Add("Samantha");
            setNomes.Add(null);
            setNomes.Add("Julia");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            // Checa se existe um elemento no HashSet
            Console.WriteLine("O Nome Julia existe? " +  setNomes.Contains("Julia"));

            // Remove um elemento da HashSet
            setNomes.Remove("João");

            setNomes.Add("Julia");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            // Converter HashSet em uma List
            List<string> hashList = setNomes.ToList();

            hashList.Sort();

            foreach (var hash in hashList)
            {
                Console.WriteLine(hash);
            }

        }
    }
}