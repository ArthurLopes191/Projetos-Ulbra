using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_FINAL.Domain.Entities
{
    public class Autor : Entity
    {
        public String Nome { get; set; }

        public String Telefone { get; set; }
        public int LivroId { get; set; }
        public Livro Livro { get; set; }
    }
}