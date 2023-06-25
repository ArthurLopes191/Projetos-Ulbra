using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_FINAL.Domain.Entities
{
    public class UsuarioDTO
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Telefone { get; set; }

        public String Documento { get; set; }

        public List<Livro> LivrosEmprestados { get; set; }

    }
}