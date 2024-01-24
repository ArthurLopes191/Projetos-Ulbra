using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1
{
    public abstract class Pessoa
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public Endereco Endereco { get; set; }

         public Pessoa(int id, string nome, string cpf, string telefone, string sexo, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Sexo = sexo;
            Endereco = endereco;
        }
    }
}