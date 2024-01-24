using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_FINAL.Domain.Entities
{
    public class Usuario : Entity
    {

        public String Nome { get; set; }

        public String Telefone { get; set; }

        public String Documento { get; set; }

        public List<Emprestimo> Emprestimos { get; set; }


    }
}