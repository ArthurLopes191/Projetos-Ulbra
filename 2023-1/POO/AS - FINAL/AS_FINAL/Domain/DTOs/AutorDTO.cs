using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_FINAL.Domain.Entities
{
    public class AutorDTO
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public int LivroId { get; set; }
        public Livro Livro { get; set; }
    }
}