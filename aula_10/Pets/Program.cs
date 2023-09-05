namespace Pets
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato("Melvin");

            g1.Som();

            Cachorro c1 = new Cachorro("Ruffus");

            c1.Som();
        }
    }
}