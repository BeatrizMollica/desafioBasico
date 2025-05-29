using System;

namespace Desafio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos funcionarios deseja cadastrar: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Quantos gerentes deseja cadastrar: ");
            int g = int.Parse(Console.ReadLine());

            Console.Clear();
            
            Funcionario[] vetor = new Funcionario[f];
            Gerente[] vet = new Gerente[g];

            for (int i = 0; i < f; i++)
            {
                Console.Write("Coloque o nome do funcionario: ");
                string nome = Console.ReadLine();
                Console.Write("Coloque o salario dele: ");
                decimal salario = decimal.Parse(Console.ReadLine());
                vetor[i] = new Funcionario {Nome = nome, Salario = salario};    
            }   
           
            Console.Clear();

            for(int ii = 0; ii < g; ii++)
            {
                Console.Write("Coloque o nome do gerente: ");
                string nome2 = Console.ReadLine();
                Console.Write("Coloque o bonus dele: ");
                decimal bonus = decimal.Parse(Console.ReadLine());
                var funcionario1 = vetor[ii];
                vet[ii] = new Gerente {Nome = nome2, Bonus = bonus, Salario = funcionario1.Salario};
            }

            Console.Clear();

            foreach (var funcionario in vetor)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Tabela de Funcionarios:");
                Console.WriteLine($"Funcionario: {funcionario.Nome}, Salario: {funcionario.Salario:C}.");
            }

            for (int ii = 0; ii< g; ii++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Tabela de Gerentes: ");
                decimal salarioTotal = vet[ii].CalcularSalarioTotal();
                Console.WriteLine($"Gerente: {vet[ii].Nome}, Salario: {vet[ii].Salario:C} + Bonus: {vet[ii].Bonus:C}, Total: {salarioTotal:C}.");
            }
                Console.WriteLine("----------------------------");

        }
    }
}