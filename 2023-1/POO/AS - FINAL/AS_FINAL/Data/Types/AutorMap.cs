using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_FINAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AS_FINAL.Data.Types
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
            public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("autores");

            builder.Property(i => i.Id).HasColumnName("id");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Nome)
                .HasColumnName("nome")
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(i => i.Telefone)
                .HasColumnName("telefone")
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.HasOne(a => a.Livro)
               .WithMany(l => l.Autores)
               .HasForeignKey(a => a.LivroId);
        }
    }
}