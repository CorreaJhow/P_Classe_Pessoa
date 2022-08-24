using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse_Pessoa
{
    internal class Pessoa
    {
        String nome, cpf, dataNascimento, telefone;


        public Pessoa()
        {

        }
        public void setNome()
        {
            Console.WriteLine("Insira um nome: ");
            this.nome = Console.ReadLine();
        }

        public void setData()
        {
            Console.WriteLine("Insira uma Data (no modelo dia/mes/ano): ");
            this.dataNascimento = Console.ReadLine();
        }

        public void setDocumento()
        {
            Console.Write("Informe a o cpf da primeira pessoa (seguindo o modelo 'XXX.XXX.XXX-XX'): ");
            this.cpf = (Console.ReadLine());
        }

        public void setTelefone()
        {
            Console.WriteLine(this.nome + ", por favor informe o seu telefone: ");
            this.telefone = (Console.ReadLine());
        }

        public void getNome()
        {
            Console.WriteLine("O nome informado foi: " + this.nome);
        }

        public void getData()
        {
            Console.WriteLine("A data de nascimento informada por " + this.nome + " informada foi: " + this.dataNascimento);
        }

        public void getDocumento()
        {
            Console.WriteLine("o cpf de" + this.nome + " é correspondete a " + this.cpf);
        }

        public void getTelefone()
        {
            Console.WriteLine("O telefone do " + this.nome + " é equivalente a " + this.telefone);
        }

        public void RealizarCadastro()
        {
            setNome();
            setData();
            setDocumento();
            setTelefone();
        }

        public void ImprimirCadastro()
        {
            getNome();
            getData();
            getDocumento();
            getTelefone();

        }
    }
}
