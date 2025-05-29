using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_4
{
    public class Conta
    {
        public string Titular;
        public decimal Saldo;

        public Conta(decimal valor){
            Saldo = valor;
         }
        
        public void Depositar(decimal valor)
        {
           Saldo += valor;
        }

        public virtual void Sacar(decimal valor)
        {
           Saldo -= valor;
        }
    }

    public class ContaCorrente : Conta
    {
        public ContaCorrente(decimal valor) : base(valor){}

        public override void Sacar(decimal valor)
        {
    decimal limite == 1000;//

    if (valor > limite)
    {
        Console.WriteLine("Seu limite diário de saque é R$1000,00. Tente novamente.");
    }

    else if (valor <= Saldo)
    {
        Saldo -= valor;
        Console.WriteLine($"Saque de {valor:C} realizado com sucesso.");
    }
    else
    {
        Console.WriteLine("Saldo insuficiente.");
    }
    }

        
    }

    public class ContaPoupanca : Conta
    {
        public ContaPoupanca (decimal valor) : base(valor){}

        public void Rendimento( int meses)
        {
            decimal taxa = 0.01M;//
            Saldo = Saldo + (Saldo * taxa * meses);
            Console.WriteLine($"Depois de {meses} meses, seu saldo é de {Saldo:C}");

        }

    }
}