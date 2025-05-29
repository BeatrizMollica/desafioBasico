using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_1
{
    public class Produtos
    {
         public int Codigo;
        public string Nome;
        public decimal Preco;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco:C}");
        }

    }
}