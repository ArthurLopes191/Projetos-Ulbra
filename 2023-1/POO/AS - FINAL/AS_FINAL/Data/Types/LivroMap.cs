using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_FINAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AS_FINAL.Data.Types
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
          builder.ToTable("livros");

            builder.Property(i => i.Id).HasColumnName("id");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Titulo)
                .HasColumnName("titulo")
                .IsRequired()
                .HasColumnType("varchar(200)");


          // Configuração do relacionamento com Autor
           builder.HasMany(l => l.Autores)
                .WithOne(a => a.Livro)
                .HasForeignKey(a => a.LivroId)
                .HasConstraintName("FK_Livro_Autores")
                .OnDelete(DeleteBehavior.Restrict);

           // Configuração do relacionamento com Emprestimo
           builder.HasOne(l => l.Emprestimo)
                  .WithOne(e => e.Livro)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}