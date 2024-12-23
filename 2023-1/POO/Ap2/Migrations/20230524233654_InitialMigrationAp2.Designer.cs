﻿// <auto-generated />
using System;
using Ap2.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ap2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230524233654_InitialMigrationAp2")]
    partial class InitialMigrationAp2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Ap2.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MedicoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("Ap2.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cep")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Logradouro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Ap2.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Pessoa");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pessoa");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Ap2.Medico", b =>
                {
                    b.HasBaseType("Ap2.Pessoa");

                    b.Property<int>("Crm")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Especialidade")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("Ap2.Paciente", b =>
                {
                    b.HasBaseType("Ap2.Pessoa");

                    b.Property<int>("ConsultaId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("ConsultaId")
                        .IsUnique();

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("Ap2.Consulta", b =>
                {
                    b.HasOne("Ap2.Medico", "Medico")
                        .WithMany("Consultas")
                        .HasForeignKey("MedicoId");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("Ap2.Pessoa", b =>
                {
                    b.HasOne("Ap2.Endereco", "Endereco")
                        .WithMany("Pessoas")
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Ap2.Paciente", b =>
                {
                    b.HasOne("Ap2.Consulta", "consulta")
                        .WithOne("Paciente")
                        .HasForeignKey("Ap2.Paciente", "ConsultaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("consulta");
                });

            modelBuilder.Entity("Ap2.Consulta", b =>
                {
                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Ap2.Endereco", b =>
                {
                    b.Navigation("Pessoas");
                });

            modelBuilder.Entity("Ap2.Medico", b =>
                {
                    b.Navigation("Consultas");
                });
#pragma warning restore 612, 618
        }
    }
}
