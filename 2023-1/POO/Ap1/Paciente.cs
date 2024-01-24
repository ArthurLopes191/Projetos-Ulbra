using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ap1
{
    public class Paciente : Pessoa
    {
        public Paciente(int id, string nome, string cpf, string telefone, string sexo, Endereco endereco) : base(id, nome, cpf, telefone, sexo, endereco)
        {
            
        }
    }
}