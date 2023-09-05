using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public abstract class Pet
    {
        private string nome;

        public Pet (string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public abstract void Som();
    }
}
