using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Vendedor : Funcionario, IComissao
    {
        private float totalVendas;

        public Vendedor(float salario, string cargo, string nome, float totalVendas)
            : base(salario, cargo, nome)
        {
            this.totalVendas = totalVendas;
        }

        public float GetTotalVendas()
        {
            return totalVendas;
        }

        public void SetTotalVendas(float totalVendas)
        {
            this.totalVendas = totalVendas;
        }

        public override float CalcularSalario()
        {
            return this.GetSalario() + this.CalcularComissao();
        }

        public float CalcularComissao()
        {
            return this.totalVendas * 0.1f;
        }
    }
}
