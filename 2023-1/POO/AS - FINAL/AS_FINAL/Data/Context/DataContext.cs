using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_FINAL.Data.Types;
using AS_FINAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AS_FINAL.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Autor> DbSetAutor { get; set; }
        public DbSet<Livro> DbSetLivro { get; set; }
        public DbSet<Usuario> DbSetUsuario { get; set; }
        public DbSet<Emprestimo> DbSetEmprestimo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new EmprestimoMap());
        }
    }
}