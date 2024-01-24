using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_FINAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AS_FINAL.Data.Types
{
    public class EmprestimoMap : IEntityTypeConfiguration<Emprestimo>
    {
         public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("emprestimos");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.DataEmprestimo)
                .HasColumnName("data_emprestimo")
                .IsRequired();

            builder.Property(e => e.DataDevolucao)
                .HasColumnName("data_devolucao");

            // Configuração do relacionamento com Livro
            builder.HasOne(e => e.Livro)
                .WithOne(l => l.Emprestimo)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuração do relacionamento com Usuario
            builder.HasOne(e => e.Usuario)
                .WithMany(u => u.Emprestimos)
                .HasForeignKey(e => e.UsuarioId);
        }
    }
}