﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using One.Infra.Data.Context;

namespace One.Infra.Data.Migrations
{
    [DbContext(typeof(OneContext))]
    partial class OneContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("One.Domain.Entities.ACAluno", b =>
                {
                    b.Property<int>("CodigoAluno")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasMaxLength(11);

                    b.Property<int>("CodigoUsuario");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int>("DiaVencimento");

                    b.Property<string>("RG")
                        .HasMaxLength(20);

                    b.Property<string>("Sexo")
                        .HasMaxLength(1);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoAluno");

                    b.HasIndex("CodigoUsuario");

                    b.ToTable("ACAluno");
                });

            modelBuilder.Entity("One.Domain.Entities.ACAlunoResponsavel", b =>
                {
                    b.Property<int>("CodigoResponsavelResponsavel")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoAluno");

                    b.Property<int>("CodigoParentesco");

                    b.Property<int>("CodigoResponsavel");

                    b.HasKey("CodigoResponsavelResponsavel");

                    b.HasIndex("CodigoAluno");

                    b.HasIndex("CodigoParentesco");

                    b.HasIndex("CodigoResponsavel");

                    b.ToTable("ACAlunoResponsavel");
                });

            modelBuilder.Entity("One.Domain.Entities.ACAvaliacao", b =>
                {
                    b.Property<int>("CodigoAvaliacao")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoMatricula");

                    b.Property<DateTime>("DataAvaliacao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<decimal>("NotaAvaliacao");

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("flSituacao")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoAvaliacao");

                    b.HasIndex("CodigoMatricula");

                    b.ToTable("ACAvaliacao");
                });

            modelBuilder.Entity("One.Domain.Entities.ACCategoria", b =>
                {
                    b.Property<int>("CodigoCategoria")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescicaoCategoria")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoCategoria");

                    b.ToTable("ACCategoria");
                });

            modelBuilder.Entity("One.Domain.Entities.ACFaixaEtaria", b =>
                {
                    b.Property<int>("CodigoFaixaEtaria")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("IdadeMaxima");

                    b.Property<int>("IdadeMinima");

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoFaixaEtaria");

                    b.ToTable("ACFaixaEtaria");
                });

            modelBuilder.Entity("One.Domain.Entities.ACFrequencia", b =>
                {
                    b.Property<int>("Codigofrequencia")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoMatricula");

                    b.Property<DateTime>("DataFrequencia");

                    b.Property<string>("Observacao")
                        .HasMaxLength(500);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("flSituacao")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("Codigofrequencia");

                    b.HasIndex("CodigoMatricula");

                    b.ToTable("ACFrequencia");
                });

            modelBuilder.Entity("One.Domain.Entities.ACMatricula", b =>
                {
                    b.Property<int>("CodigoMatricula")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoAluno");

                    b.Property<string>("CodigoIdentificador")
                        .IsRequired();

                    b.Property<int>("CodigoTurma");

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoMatricula");

                    b.HasIndex("CodigoAluno");

                    b.HasIndex("CodigoTurma");

                    b.ToTable("ACMatricula");
                });

            modelBuilder.Entity("One.Domain.Entities.ACNivel", b =>
                {
                    b.Property<int>("CodigoNivel")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoCategoria");

                    b.Property<int>("CodigoFaixaEtaria");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoNivel");

                    b.HasIndex("CodigoCategoria");

                    b.HasIndex("CodigoFaixaEtaria");

                    b.ToTable("ACNivel");
                });

            modelBuilder.Entity("One.Domain.Entities.ACProfessor", b =>
                {
                    b.Property<int>("CodigoProfessor")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired();

                    b.Property<int>("CodigoUsuario");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("RG")
                        .IsRequired();

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoProfessor");

                    b.HasIndex("CodigoUsuario");

                    b.ToTable("ACProfessor");
                });

            modelBuilder.Entity("One.Domain.Entities.ACResponsavel", b =>
                {
                    b.Property<int>("CodigoResponsavel")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ACAlunoCodigoAluno");

                    b.Property<string>("CPF")
                        .HasMaxLength(11);

                    b.Property<int>("CodigoUsuario");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("RG")
                        .HasMaxLength(20);

                    b.Property<string>("Sexo")
                        .HasMaxLength(1);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoResponsavel");

                    b.HasIndex("ACAlunoCodigoAluno");

                    b.HasIndex("CodigoUsuario");

                    b.ToTable("ACResponsavel");
                });

            modelBuilder.Entity("One.Domain.Entities.ACTurma", b =>
                {
                    b.Property<int>("CodigoTurma")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoIdentificador")
                        .IsRequired();

                    b.Property<int>("CodigoNivel");

                    b.Property<int>("CodigoProfessor");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("ValorBase");

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoTurma");

                    b.HasIndex("CodigoNivel");

                    b.HasIndex("CodigoProfessor");

                    b.ToTable("ACTurma");
                });

            modelBuilder.Entity("One.Domain.Entities.FIMensalidade", b =>
                {
                    b.Property<int>("CodigoMensalidade")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnoCompetencia");

                    b.Property<int>("CodigoMatricula");

                    b.Property<DateTime>("DataEmissao");

                    b.Property<DateTime>("DataPagamento");

                    b.Property<DateTime>("DataVencimento");

                    b.Property<int>("MesCompetencia");

                    b.Property<int>("NumeroParcela");

                    b.Property<decimal>("Valor");

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("flSituacao")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoMensalidade");

                    b.HasIndex("CodigoMatricula");

                    b.ToTable("FIMensalidade");
                });

            modelBuilder.Entity("One.Domain.Entities.GEBairro", b =>
                {
                    b.Property<int>("CodigoBairro")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoCidade");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoBairro");

                    b.HasIndex("CodigoCidade");

                    b.ToTable("GEBairro");
                });

            modelBuilder.Entity("One.Domain.Entities.GECidade", b =>
                {
                    b.Property<int>("CodigoCidade")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoUF");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoCidade");

                    b.HasIndex("CodigoUF");

                    b.ToTable("GECidade");
                });

            modelBuilder.Entity("One.Domain.Entities.GEEndereco", b =>
                {
                    b.Property<int>("CodigoEndereco")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("CodigoBairro");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Numero")
                        .HasMaxLength(5);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoEndereco");

                    b.HasIndex("CodigoBairro");

                    b.ToTable("GEEndereco");
                });

            modelBuilder.Entity("One.Domain.Entities.GEParentesco", b =>
                {
                    b.Property<int>("CodigoParentesco")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoParentesco");

                    b.ToTable("GEParentesco");
                });

            modelBuilder.Entity("One.Domain.Entities.GETelefone", b =>
                {
                    b.Property<int>("CodigoTelefone")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoTipoTelefone");

                    b.Property<int>("CodigoUsuario");

                    b.Property<string>("NumeroTelefone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoTelefone");

                    b.HasIndex("CodigoTipoTelefone");

                    b.HasIndex("CodigoUsuario");

                    b.ToTable("GETelefone");
                });

            modelBuilder.Entity("One.Domain.Entities.GETipoTelefone", b =>
                {
                    b.Property<int>("CodigoTipoTelefone")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoTipoTelefone");

                    b.ToTable("GETipoTelefone");
                });

            modelBuilder.Entity("One.Domain.Entities.GEUF", b =>
                {
                    b.Property<int>("CodigoUF")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoUF");

                    b.ToTable("GEUF");
                });

            modelBuilder.Entity("One.Domain.Entities.GEUsuarioEndereco", b =>
                {
                    b.Property<int>("CodigoUsuarioEndereco")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoEndereco");

                    b.Property<int>("CodigoUsuario");

                    b.HasKey("CodigoUsuarioEndereco");

                    b.HasIndex("CodigoEndereco");

                    b.HasIndex("CodigoUsuario");

                    b.ToTable("GEUsuarioEndereco");
                });

            modelBuilder.Entity("One.Domain.Entities.SEGPerfil", b =>
                {
                    b.Property<int>("CodigoPerfil")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoPerfil");

                    b.ToTable("SEGPerfil");
                });

            modelBuilder.Entity("One.Domain.Entities.SEGUsuario", b =>
                {
                    b.Property<int>("CodigoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("flAtivo")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.HasKey("CodigoUsuario");

                    b.ToTable("SEGUsuario");
                });

            modelBuilder.Entity("One.Domain.Entities.SEGUsuarioPerfil", b =>
                {
                    b.Property<int>("CodigoUsuarioPerfil")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoPerfil");

                    b.Property<int>("CodigoPerfilPadrao");

                    b.Property<int>("CodigoUsuario");

                    b.HasKey("CodigoUsuarioPerfil");

                    b.HasIndex("CodigoPerfil");

                    b.HasIndex("CodigoUsuario");

                    b.ToTable("SEGUsuarioPerfil");
                });

            modelBuilder.Entity("One.Domain.Entities.ACAluno", b =>
                {
                    b.HasOne("One.Domain.Entities.SEGUsuario", "SEGUsuario")
                        .WithMany()
                        .HasForeignKey("CodigoUsuario")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.ACAlunoResponsavel", b =>
                {
                    b.HasOne("One.Domain.Entities.ACAluno", "ACAluno")
                        .WithMany()
                        .HasForeignKey("CodigoAluno")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("One.Domain.Entities.GEParentesco", "GEParentesco")
                        .WithMany()
                        .HasForeignKey("CodigoParentesco")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("One.Domain.Entities.ACResponsavel", "ACResponsavel")
                        .WithMany("ACAlunoResponsavel")
                        .HasForeignKey("CodigoResponsavel")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.ACAvaliacao", b =>
                {
                    b.HasOne("One.Domain.Entities.ACMatricula", "ACMatricula")
                        .WithMany("ACAvaliacao")
                        .HasForeignKey("CodigoMatricula")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.ACFrequencia", b =>
                {
                    b.HasOne("One.Domain.Entities.ACMatricula", "ACMatricula")
                        .WithMany("ACFrequencia")
                        .HasForeignKey("CodigoMatricula")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.ACMatricula", b =>
                {
                    b.HasOne("One.Domain.Entities.ACAluno", "ACAluno")
                        .WithMany("ACMatricula")
                        .HasForeignKey("CodigoAluno")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("One.Domain.Entities.ACTurma", "ACTurma")
                        .WithMany()
                        .HasForeignKey("CodigoTurma")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.ACNivel", b =>
                {
                    b.HasOne("One.Domain.Entities.ACCategoria", "ACCategoria")
                        .WithMany("ACNivel")
                        .HasForeignKey("CodigoCategoria")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("One.Domain.Entities.ACFaixaEtaria", "ACFaixaEtaria")
                        .WithMany()
                        .HasForeignKey("CodigoFaixaEtaria")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.ACProfessor", b =>
                {
                    b.HasOne("One.Domain.Entities.SEGUsuario", "SEGUsuario")
                        .WithMany()
                        .HasForeignKey("CodigoUsuario")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.ACResponsavel", b =>
                {
                    b.HasOne("One.Domain.Entities.ACAluno")
                        .WithMany("ACResponsavel")
                        .HasForeignKey("ACAlunoCodigoAluno")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("One.Domain.Entities.SEGUsuario", "SEGUsuario")
                        .WithMany()
                        .HasForeignKey("CodigoUsuario")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.ACTurma", b =>
                {
                    b.HasOne("One.Domain.Entities.ACNivel", "ACNivel")
                        .WithMany()
                        .HasForeignKey("CodigoNivel")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("One.Domain.Entities.ACProfessor", "ACProfessor")
                        .WithMany("ACTurma")
                        .HasForeignKey("CodigoProfessor")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.FIMensalidade", b =>
                {
                    b.HasOne("One.Domain.Entities.ACMatricula", "ACMatricula")
                        .WithMany()
                        .HasForeignKey("CodigoMatricula")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.GEBairro", b =>
                {
                    b.HasOne("One.Domain.Entities.GECidade", "GECidade")
                        .WithMany()
                        .HasForeignKey("CodigoCidade")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.GECidade", b =>
                {
                    b.HasOne("One.Domain.Entities.GEUF", "GEUF")
                        .WithMany("GECidade")
                        .HasForeignKey("CodigoUF")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.GEEndereco", b =>
                {
                    b.HasOne("One.Domain.Entities.GEBairro", "GEBairro")
                        .WithMany()
                        .HasForeignKey("CodigoBairro")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.GETelefone", b =>
                {
                    b.HasOne("One.Domain.Entities.GETipoTelefone", "GETipoTelefone")
                        .WithMany()
                        .HasForeignKey("CodigoTipoTelefone")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("One.Domain.Entities.SEGUsuario", "SEGUsuario")
                        .WithMany("GETelefone")
                        .HasForeignKey("CodigoUsuario")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.GEUsuarioEndereco", b =>
                {
                    b.HasOne("One.Domain.Entities.GEEndereco", "GEEndereco")
                        .WithMany("GEUsuarioEndereco")
                        .HasForeignKey("CodigoEndereco")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("One.Domain.Entities.SEGUsuario", "SEGUsuario")
                        .WithMany("GEUsuarioEndereco")
                        .HasForeignKey("CodigoUsuario")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("One.Domain.Entities.SEGUsuarioPerfil", b =>
                {
                    b.HasOne("One.Domain.Entities.SEGPerfil", "SEGPerfil")
                        .WithMany("SEGUsuarioPerfis")
                        .HasForeignKey("CodigoPerfil")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("One.Domain.Entities.SEGUsuario", "SEGUsuario")
                        .WithMany("SEGUsuarioPerfil")
                        .HasForeignKey("CodigoUsuario")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
