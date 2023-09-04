using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class OperadorCaixa : Funcionario
    {

        public OperadorCaixa(float salario, string cargo, string nome) 
            : base(salario, cargo, nome)
        {
        }

        public override float CalcularBonus()
        {
            throw new NotImplementedException();
        }

        public override float CalcularComissao()
        {
            throw new NotImplementedException();
        }

        public override float CalcularSalario()
        {
            return this.GetSalario();
        }
    }
}
