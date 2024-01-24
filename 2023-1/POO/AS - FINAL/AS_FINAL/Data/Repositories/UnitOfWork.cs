using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_FINAL.Data.Context;
using AS_FINAL.Domain.Interfaces;

namespace AS_FINAL.Data.Repositories
{
     public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
        private IAutorRepository _AutorRepository;
        private ILivroRepository _LivroRepository;
        private IUsuarioRepository _UsuarioRepository;
        private IEmprestimoRepository _EmprestimoRepository;


        public IAutorRepository AutorRepository
        {
            get { return _AutorRepository ??= new AutorRepository(_context); }
        }
        public ILivroRepository LivroRepository
        {
            get { return _LivroRepository ??= new LivroRepository(_context); }
        }
        public IUsuarioRepository UsuarioRepository
        {
            get { return _UsuarioRepository ??= new UsuarioRepository(_context); }
        }
        public IEmprestimoRepository EmprestimoRepository
        {
            get { return _EmprestimoRepository ??= new EmprestimoRepository(_context); }
        }

    }
}