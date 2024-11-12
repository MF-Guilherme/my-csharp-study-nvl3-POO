using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salário como professor é de {Salario:C2}");
        }
    }
}