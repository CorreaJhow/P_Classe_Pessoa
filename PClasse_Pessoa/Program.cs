using System;

namespace PClasse_Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeiraPessoa = new Pessoa();   //Primeiro objeto 
            Pessoa segundaPessoa = new Pessoa();    //segundo objeto
            Pessoa terceiraPessoa = new Pessoa();   //terceiro objeto

            Console.WriteLine("1° objeto:");
            IdentificacaoPessoa(primeiraPessoa);
            Console.WriteLine("");

            Console.WriteLine("2° objeto:");
            IdentificacaoPessoa(segundaPessoa);
            Console.WriteLine("");

            Console.WriteLine("3° objeto:");
            IdentificacaoPessoa(terceiraPessoa);
            Console.WriteLine("");
        }
        static void IdentificacaoPessoa(Pessoa pessoa)
        {
            pessoa.RealizarCadastro();
            Console.WriteLine("---");
            pessoa.ImprimirCadastro();
        }
    }    
}
