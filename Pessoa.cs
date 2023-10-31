using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Pessoa
    {
        public Pessoa(string nome, int massa, double altura)
        {
            Nome = nome;
            Massa = massa;
            Altura = altura;
            CalcularIMC();

        }

        public string  Nome{get; private set;}
        public int Massa {get; private set;}
        public double Altura {get; private set;}
        public double IMC {get; private set;}

        public void CalcularIMC()
        {
           this.IMC = this.Massa /(Math.Pow(this.Altura,2));
        }

        public override string ToString()
        {
            return $"{this.Nome} - {this.Massa} - {this.Altura} - {this.IMC}";
        }
    }
}