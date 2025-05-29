using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Desafio_4
{
    class Program
    {
        static void Main(string[]args)
        {
        
        List<Conta> list = new List<Conta>();
        
       
        Console.Write("Titular: ");
        string titular = Console.ReadLine();
        Console.Write("Saldo: ");
        decimal saldo = decimal.Parse(Console.ReadLine());
        ContaCorrente continha = new ContaCorrente(saldo);
        list.Add(continha);

        Console.Clear();

        bool perguntaDeposito = false;
        bool perguntaSaque = false;

            while(!perguntaDeposito)
            {
                Console.Write("Gostaria de fazer um depósito(sim/nao): ");
                string resposta = Console.ReadLine();

                    if(resposta.ToLower() == "sim"){
                    Console.Write("Quanto gostaria de depositar: ");
                    decimal deposito = decimal.Parse(Console.ReadLine());
                    continha.Depositar(deposito);
                    perguntaDeposito = true;
            
                    }else if (resposta.ToLower() == "nao"){
                
                        while(!perguntaSaque){
                            Console.Write("Gostaria de fazer um saque(sim/nao): ");
                            string resposta1 = Console.ReadLine();
                
                                if(resposta1.ToLower() == "sim")
                                {
                                Console.Write("Quanto gostaria de sacar: ");
                                decimal saque = decimal.Parse(Console.ReadLine());
                            continha.Sacar(saque); 
                            }else if(resposta1.ToLower() == "nao"){                    
                            perguntaSaque = true;
                            }else{
                            Console.WriteLine("Resposta Incorreta,digite sim ou nao.");
                            }
                        }
                
                perguntaDeposito = true;
                }else{
                Console.WriteLine("Resposta Incorreta, digite sim ou nao.");
                }
                
                
                Console.WriteLine($"Valor total em conta atualizado: {continha.Saldo:C}.");
                
                Console.WriteLine("Gostaria de aplicar uma parte do saldo na poupança por um período (sim/nao)? ");
string rendimento = Console.ReadLine().ToLower();

if (rendimento == "sim")
{
    Console.Write("Quanto deseja aplicar na poupança: ");
    decimal valorPoupanca = decimal.Parse(Console.ReadLine());

    if (valorPoupanca > continha.Saldo)
    {
        Console.WriteLine("Saldo insuficiente para aplicar na poupança.");
    }
    else
    {
        Console.Write("Quantos meses: ");
        int meses = int.Parse(Console.ReadLine());
        
        ContaPoupanca poupanca = new ContaPoupanca(valorPoupanca);
        poupanca.Rendimento(meses);
        
        continha.Saldo -= valorPoupanca;

        Console.WriteLine($"Valor atual da conta: {continha.Saldo:C}");
        Console.WriteLine($"Saldo após rendimento na poupança: {poupanca.Saldo:C}");
    }
}

         
            }
        }
}
}
