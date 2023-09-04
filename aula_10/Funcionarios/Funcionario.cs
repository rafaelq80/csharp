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
        private string cargo;
        private string nome;

        public Funcionario(float salario, string cargo, string nome)
        {
            this.salario = salario;
            this.cargo = cargo;
            this.nome = nome;
        }

        //Métodos abstratos
        public abstract float CalcularSalario();

        public float GetSalario()
        {
            return salario;
        }

        public void SetSalario(float salario)
        {
            this.salario = salario;
        }

        public string GetCargo()
        {
            return cargo;
        }

        public void SetCargo(string cargo)
        {
            this.cargo = cargo;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
    }
}
