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

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setData(String dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        public void setDocumento(String cpf)
        {
            this.cpf = cpf;
        }

        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }

        public String getNome()
        {
            return nome;
        }

        public String getData()
        {
            return dataNascimento;
        }

        public String getDocumento()
        {
            return cpf;
        }

        public String getTelefone()
        {
            return telefone;
        }
    }
}
