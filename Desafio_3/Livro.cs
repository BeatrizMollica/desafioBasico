using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_3
{
    public class Livro
    {
        public string Titulo {get ; set;}
        public string Autor {get; set;}
        private decimal preco;

        //Construtor

        public Livro(){}
        public Livro(string titulo, string autor, decimal preco)
        {
            Titulo = titulo;
            Autor = autor;
            Preco = preco;
        }

        //Método GET
        public string Gettitulo()
        {
            return Titulo;
        }

        public string GetAutor()
        {
            return Autor;
        }

        //Metodo SET
        public decimal Preco
        {
            get { return preco; }
            set{
            if (value < 0)
            {
                Console.WriteLine("ERRO! Digite um preço que não seja negativo.");
                preco = 0;
            }else
            {
                preco = value;
            }
            }

        }
    }
}