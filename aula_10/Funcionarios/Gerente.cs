using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Gerente : Funcionario, IBonus
    {
        private float bonus;

        public Gerente(float salario, string cargo, string nome, float bonus) 
            : base(salario, cargo, nome)
        {
            this.bonus = bonus;
        }

        public float GetBonus()
        {
            return bonus;
        }

        public void SetBonus(float bonus)
        {
            this.bonus = bonus;
        }

        public float CalcularBonus()
        {
            return this.GetSalario() * this.GetBonus();
        }

        public override float CalcularSalario()
        {
            return this.GetSalario() + this.CalcularBonus();
        }
    }
}
