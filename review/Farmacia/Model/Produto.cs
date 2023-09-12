using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public  class Produto
    {

        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Tipo { get; set; }
        public decimal Preco { get; set; }

        public Produto(int id, string nome, int tipo, decimal preco)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
            Preco = preco;
        }

        public Produto() { }

        public Produto(string nome, int tipo, decimal preco)
        {
            Nome = nome;
            Tipo = tipo;
            Preco = preco;
        }

        public virtual void Visualizar()
        {

            string tipo = "";

            switch (Tipo)
            {
                case 1:
                    tipo = "Medicamento";
                    break;
                case 2:
                    tipo = "Cosmético";
                    break;
            }

            Console.WriteLine("\n\n*********************************************************************");
            Console.WriteLine("Dados do Produto:");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Id do Produto: " + Id);
            Console.WriteLine("Nome do Produto: " + Nome);
            Console.WriteLine("Tipo do Produto: " + tipo);
            Console.WriteLine("Preço do Produto: " + Preco);

        }
    }
}
