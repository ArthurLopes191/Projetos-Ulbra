using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AS_FINAL.Domain.Entities;

namespace AS_FINAL.Domain.ViewModels
{
    public class LivroViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 13)]


         public string LivroId { get; set; }

        public List<AutorViewModel> Autores { get; set; }


        public Emprestimo Emprestimo { get; set; }
        
    }
}