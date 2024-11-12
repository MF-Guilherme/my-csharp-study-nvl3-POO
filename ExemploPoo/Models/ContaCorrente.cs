using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;         
        }

        public int NumeroConta { get; set; }
        private decimal Saldo;

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                System.Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                System.Console.WriteLine("Valor desejado é maior que o saldo disponível");
            }
        }

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo disponível é: {Saldo:C2}");
        }
    }
}