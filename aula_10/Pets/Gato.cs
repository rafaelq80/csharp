using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Gato : Pet
    {
        public Gato(string nome) : base(nome)
        {
        }

        public override void Som()
        {
            Console.WriteLine("Miau!");
        }
    }
}
