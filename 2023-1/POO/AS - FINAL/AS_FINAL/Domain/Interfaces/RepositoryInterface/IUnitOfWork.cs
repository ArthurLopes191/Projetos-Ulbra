using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS_FINAL.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();

        IAutorRepository AutorRepository {get;}
        ILivroRepository LivroRepository {get;}
        IUsuarioRepository UsuarioRepository {get;}
    }
}