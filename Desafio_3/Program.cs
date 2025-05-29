using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_3
{
     class Program
    {
        static void Main(string[] args)
        {
             List<Livro> livro = new List<Livro>();

            string resp;

            do{
              Console.WriteLine("Deseja cadastrar livros (s/n)?");
              resp = Console.ReadLine().ToLower();

              if(resp != "s" && resp != "sim" && resp != "n" && resp != "nao"){
                Console.WriteLine("Entrada inválida! Digite 's' para sim ou 'n' para não");
              } else{
                Console.Clear();
                break;
              } 
            }while(true);

            while(resp == "s" || resp == "sim"){

            Livro liv = new Livro();

            Console.Write("Titulo: ");
            liv.Titulo = Console.ReadLine();
            Console.Write("Autor: ");
            liv.Autor = Console.ReadLine();
            Console.Write("Preço: ");
            liv.Preco = decimal.Parse(Console.ReadLine());

            while(liv.Preco == 0)
            {
                Console.Write("Digite Novamente: ");
                liv.Preco = decimal.Parse(Console.ReadLine());
            }

            livro.Add(liv);
            
            Console.Clear();
            Console.Write("Deseja cadastrar livros(s/n)? ");
            resp = Console.ReadLine().ToLower();
            Console.Clear();

            while (resp != "s" && resp != "sim" && resp != "n" && resp != "nao")
            {
            Console.WriteLine("Entrada inválida! Digite 's' para sim ou 'n' para não.");
            Console.Write("Deseja cadastrar mais livros (s/n)? ");
             resp = Console.ReadLine().ToLower();
            }

            Console.Clear();
            }
            

            Console.Clear();

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Livros Cadastrados:");

            foreach (var livrinhos in livro)
            {
                Console.WriteLine($"Titulo: {livrinhos.Titulo}, Autor: {livrinhos.Autor}, Preço: {livrinhos.Preco:C}.");
            }
            Console.WriteLine("-------------------------------------------------");

        }
    }
}
