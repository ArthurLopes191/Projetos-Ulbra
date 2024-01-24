using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1
{
    public class Medico : Pessoa
    {
        public int Crm { get; private set; }
        public string Especialidade { get; set; }
        public Medico(int id, string nome, string cpf, string telefone, string sexo, int crm, string especialidade, Endereco endereco) : base(id, nome, cpf, telefone, sexo, endereco)
        {
            Crm = crm;
            Especialidade = especialidade;
        }
        
    }
}