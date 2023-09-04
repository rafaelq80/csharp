using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    public class Automovel : Terrestre
    {

        private string cor;
        private int portas;
        private string placa;
        private int marcha;

        public Automovel(int capacidade, int rodas, int velocidade, 
            string cor, int portas, string placa, int marcha) 
            : base(capacidade, rodas, velocidade)
        {
            this.cor = cor;
            this.portas = portas;
            this.placa = placa;
            this.marcha = marcha;
        }

        public string GetCor()
        {
            return cor;
        }

        public void SetCor(string cor)
        {
            this.cor = cor;
        }

        public int GetPortas()
        {
            return portas;
        }

        public void SetPortas(int portas)
        {
            this.portas = portas;
        }

        public string GetPlaca()
        {
            return placa;
        }

        public void SetPlaca(string placa)
        {
            this.placa = placa;
        }

        public int GetMarcha()
        {
            return marcha;
        }

        public void SetMarcha(int marcha)
        {
            this.marcha = marcha;
        }

        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine("cor: " + this.cor);
            Console.WriteLine("Número de portas: " + this.portas);
            Console.WriteLine("Placa: " + this.placa);
            Console.WriteLine("Marcha: " + this.marcha);

        }
    }
}
