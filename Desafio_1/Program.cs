using System;
using System.Xml.Serialization;


namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite a quantidade de produtos a adicionar: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            Produtos[] vetor = new Produtos[n];

            for(int i = 0 ; i < n; i++ )
            {
                Console.Write("Digite o codigo do produto:" );
                int codigo = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome do produto:" );
                string nome = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                decimal preco = decimal.Parse(Console.ReadLine());
                vetor[i] = new Produtos {Codigo = codigo, Nome = nome, Preco = preco};

                Console.Clear();
            }

            int contador = 1;
            Console.Clear();
            
            foreach(var produtos in vetor)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"Produto {contador}: ");
                produtos.ExibirInformacoes();
                contador++; 
            }  
            Console.WriteLine("----------------------");  
        }
    }
}