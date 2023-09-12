using Farmacia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Repository
{
    public interface IProdutoRepository
    {
        public void ProcurarPorNumero(int id);
        public void ListarTodas();
        public void Cadastrar(Produto produto);
        public void Atualizar(Produto produto);
        public void Deletar(int id);
    }
}
