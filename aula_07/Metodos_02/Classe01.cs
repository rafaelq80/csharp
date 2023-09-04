using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_02
{
    public class Classe01
    {

        public static void MetodoPublico()
        {
            Console.WriteLine("Método Público - Classe 01");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe 01");
        }

        protected static void MetodoProtegido()
        {
            Console.WriteLine("Método Protegido - Classe 01");
        }

        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado - Classe 01");
        }
    }
}
