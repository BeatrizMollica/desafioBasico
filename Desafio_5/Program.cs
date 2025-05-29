using System;

namespace Desafio_5
{
    class Program
    {
        static void Main(string[] args)
        {

            var carrinho = new Carrinho();

            Console.Write("Quantos produtos deseja colocar no carrinho: ");
            int p = int.Parse(Console.ReadLine());
            Console.Clear();

            for(int i = 0; i < p; i ++)
            {
            Produto produto = new Produto();
            Console.Write("Codigo: ");
            produto.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            produto.Preco = decimal.Parse(Console.ReadLine());
            Console.Clear();
            carrinho.AdicionarProduto(produto);
            }

            carrinho.ExibirCarrinho();

        }
    }
}