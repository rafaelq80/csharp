using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_02.Namespace01
{
    public class Classe02
    {
        public static void MetodoPublico()
        {
            Console.WriteLine("Método Público - Classe 02");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe 02");
        }

        protected static void MetodoProtegido()
        {
            Console.WriteLine("Método Protegido - Classe 02");
        }

        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado - Classe 02");
        }
    }
}
