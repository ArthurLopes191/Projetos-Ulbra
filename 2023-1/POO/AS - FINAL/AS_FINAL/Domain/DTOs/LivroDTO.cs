using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_FINAL.Domain.Entities
{
    public class LivroDTO
    {
        public int Id { get; set; }

        public String Titulo { get; set; }

        public List<Autor> Autores { get; set; }

        public Emprestimo Emprestimo { get; set; }
    }
}