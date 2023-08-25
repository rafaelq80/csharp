namespace Texto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Teste";
            string frase = " Generation Brasil ";
            string palavra1 = "generation";
            string palavra2 = "generation";
            string palavra3 = "GENERATION";

            Console.WriteLine("Tamano da Variável texto: " + texto.Length);
            Console.WriteLine("Substring(2): " + texto.Substring(2));
            Console.WriteLine("Substring(0,2): " + texto.Substring(0,2));
            Console.WriteLine("Trim(): " + frase.Trim());
            Console.WriteLine("TrimEnd(): " + frase.TrimEnd());
            Console.WriteLine("TrimStart(): " + frase.TrimStart());
            Console.WriteLine("Replace(): " + frase.Replace(" ", ""));
            
            Console.WriteLine("CompareTo(): " + palavra1.CompareTo(palavra2));
            Console.WriteLine("CompareTo(): " + palavra1.CompareTo(palavra3));
                        
            Console.WriteLine("Equals(): " + palavra1.Equals(palavra2));
            Console.WriteLine("Equals(): " + palavra1.Equals(palavra3));
            
            Console.WriteLine("Contains(): " + palavra1.Contains("gen"));
            
        }
    }
}