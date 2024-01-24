using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace AS_FINAL.Domain.Entities.Validations
{
    public class EmprestimoValidation : AbstractValidator<Emprestimo>
    {
        public EmprestimoValidation()
        {
            RuleFor(e => e.LivroId)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
            
            RuleFor(e => e.UsuarioId)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}