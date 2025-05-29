using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_5
{
    public class Carrinho
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();


        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void ExibirCarrinho()
        {
            
            Console.WriteLine("Produtos no carrinho:");

            decimal total = 0;

            foreach (var produto in Produtos)
            {
                Console.WriteLine($"Codigo: {produto.Codigo}, Nome: {produto.Nome}, Preço: {produto.Preco:C}." );
                total += produto.Preco;   
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Total: {total:C}");
        }
    }
}