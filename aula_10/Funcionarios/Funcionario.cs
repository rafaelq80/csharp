using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public abstract class Funcionario
    {
        private float salario;
        private String cargo;
        private String nome;

        public Funcionario(float salario, String cargo, String nome)
        {
            this.salario = salario;
            this.cargo = cargo;
            this.nome = nome;
        }

        //Métodos abstratos
        public abstract float CalcularSalario();
        public abstract float CalcularComissao();
        public abstract float CalcularBonus();

        public float GetSalario()
        {
            return salario;
        }

        public void SetSalario(float salario)
        {
            this.salario = salario;
        }

        public String GetCargo()
        {
            return cargo;
        }

        public void SetCargo(String cargo)
        {
            this.cargo = cargo;
        }

        public String GetNome()
        {
            return nome;
        }

        public void SetNome(String nome)
        {
            this.nome = nome;
        }
    }
}
