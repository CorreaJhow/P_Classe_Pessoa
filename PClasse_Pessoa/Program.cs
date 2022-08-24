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

            Console.WriteLine("1° objeto:");//primeira pessoa
            NomeDaPessoa(primeiraPessoa);
            DataDeNascimento(primeiraPessoa);
            CpfDaPessoa(primeiraPessoa);
            TelefoneDaPessoa(primeiraPessoa);
            Console.WriteLine("");

            Console.WriteLine("2° objeto:");//segunda pessoa
            NomeDaPessoa(segundaPessoa);
            DataDeNascimento(segundaPessoa);
            CpfDaPessoa(segundaPessoa);
            TelefoneDaPessoa(segundaPessoa);
            Console.WriteLine("");

            Console.WriteLine("3° objeto:");//terceira pessoa
            NomeDaPessoa(terceiraPessoa);
            DataDeNascimento(terceiraPessoa);
            CpfDaPessoa(terceiraPessoa);
            TelefoneDaPessoa(terceiraPessoa);
            Console.WriteLine("");
        }
        private static void DataDeNascimento(Pessoa pessoa)
        {
            Console.Write("Digite sua data de nascimento (no modelo dia/mes/ano): ");
            pessoa.setData(Console.ReadLine());
            Console.WriteLine("A data de nascimento da " + pessoa.getNome() + " é correspondente à " + pessoa.getData());
        }
        private static void TelefoneDaPessoa(Pessoa pessoa)
        {
            Console.WriteLine(pessoa.getNome() + ", por favor informe o seu telefone: ");
            pessoa.setTelefone(Console.ReadLine());
            Console.WriteLine("O telefone do " + pessoa.getNome() + " é equivalente a " + pessoa.getTelefone());
        }
        private static void CpfDaPessoa(Pessoa pessoa)
        {
            Console.Write("Informe a o cpf da primeira pessoa (seguindo o modelo 'XXX.XXX.XXX-XX'): ");
            pessoa.setDocumento(Console.ReadLine());
            Console.WriteLine("o cpf da primeira pessoa é correspondete a " + pessoa.getDocumento());
        }
        private static void NomeDaPessoa(Pessoa pessoa)
        {
            Console.WriteLine("Digite o nome da pessoa: ");
            pessoa.setNome(Console.ReadLine());
            Console.WriteLine("o nome designado foi: " + pessoa.getNome());
        }
    }
}
