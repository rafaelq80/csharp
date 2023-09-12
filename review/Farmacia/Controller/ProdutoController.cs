using Farmacia.Model;
using Farmacia.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Farmacia.Controller
{
    public class ProdutoController : IProdutoRepository
    {
        
        private readonly List<Produto> listaProdutos = new();
        int id = 0;

        public void Atualizar(Produto produto)
        {
            var buscaProduto = BuscarNaCollection(produto.Id);

            if (buscaProduto != null)
            {
                var indexOf = listaProdutos.IndexOf(buscaProduto);

                listaProdutos[indexOf] = produto;

                Console.WriteLine("\nO Produto foi atualizado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nO Produto não foi encontrada!");
                Console.ResetColor();

            }
        }

        public void Cadastrar(Produto produto)
        {
            listaProdutos.Add(produto);
            Console.WriteLine("Produto Criado com sucesso!");
        }

        public void Deletar(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto != null)
            {
                if (listaProdutos.Remove(produto) == true)
                    Console.WriteLine("\nO Produto foi deletado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nO Produto não foi encontrado!");
                Console.ResetColor();
            }
        }

        public void ListarTodas()
        {
            foreach (var produto in listaProdutos)
            {
                produto.Visualizar();
            }
        }

        public void ProcurarPorId(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto != null)
                produto.Visualizar();
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nO Produto não foi encontrado!");
                Console.ResetColor();
            }
        }

        /* Métodos Auxiliares */

        public int GerarId()
        {
            return ++id;
        }


        public Produto? BuscarNaCollection(int id)
        {
            foreach (var produto in listaProdutos)
            {
                if (produto.Id == id)
                {
                    return produto;
                }
            }

            return null;
        }
    }
}
