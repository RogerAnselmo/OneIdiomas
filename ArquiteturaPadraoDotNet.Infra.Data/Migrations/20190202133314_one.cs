using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace One.Infra.Data.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACFaixaEtaria",
                columns: table => new
                {
                    CodigoFaixaEtaria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 30, nullable: false),
                    IdadeMinima = table.Column<int>(nullable: false),
                    IdadeMaxima = table.Column<int>(nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACFaixaEtaria", x => x.CodigoFaixaEtaria);
                });

            migrationBuilder.CreateTable(
                name: "GEParentesco",
                columns: table => new
                {
                    CodigoParentesco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 60, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEParentesco", x => x.CodigoParentesco);
                });

            migrationBuilder.CreateTable(
                name: "GETipoTelefone",
                columns: table => new
                {
                    CodigoTipoTelefone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 30, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GETipoTelefone", x => x.CodigoTipoTelefone);
                });

            migrationBuilder.CreateTable(
                name: "GEUF",
                columns: table => new
                {
                    CodigoUF = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 30, nullable: false),
                    Sigla = table.Column<string>(maxLength: 2, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEUF", x => x.CodigoUF);
                });

            migrationBuilder.CreateTable(
                name: "SEGPerfil",
                columns: table => new
                {
                    CodigoPerfil = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 30, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEGPerfil", x => x.CodigoPerfil);
                });

            migrationBuilder.CreateTable(
                name: "ACEstagio",
                columns: table => new
                {
                    CodigoEstagio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 30, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    CodigoFaixaEtaria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACEstagio", x => x.CodigoEstagio);
                    table.ForeignKey(
                        name: "FK_ACEstagio_ACFaixaEtaria_CodigoFaixaEtaria",
                        column: x => x.CodigoFaixaEtaria,
                        principalTable: "ACFaixaEtaria",
                        principalColumn: "CodigoFaixaEtaria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GECidade",
                columns: table => new
                {
                    CodigoCidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 50, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    CodigoUF = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GECidade", x => x.CodigoCidade);
                    table.ForeignKey(
                        name: "FK_GECidade_GEUF_CodigoUF",
                        column: x => x.CodigoUF,
                        principalTable: "GEUF",
                        principalColumn: "CodigoUF",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GEBairro",
                columns: table => new
                {
                    CodigoBairro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(maxLength: 50, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    CodigoCidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEBairro", x => x.CodigoBairro);
                    table.ForeignKey(
                        name: "FK_GEBairro_GECidade_CodigoCidade",
                        column: x => x.CodigoCidade,
                        principalTable: "GECidade",
                        principalColumn: "CodigoCidade",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GEEndereco",
                columns: table => new
                {
                    CodigoEndereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<int>(nullable: false),
                    Logradouro = table.Column<string>(maxLength: 300, nullable: false),
                    Cep = table.Column<string>(maxLength: 10, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    CodigoBairro = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEEndereco", x => x.CodigoEndereco);
                    table.ForeignKey(
                        name: "FK_GEEndereco_GEBairro_CodigoBairro",
                        column: x => x.CodigoBairro,
                        principalTable: "GEBairro",
                        principalColumn: "CodigoBairro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SEGUsuario",
                columns: table => new
                {
                    CodigoUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCompleto = table.Column<string>(maxLength: 200, nullable: false),
                    Login = table.Column<string>(maxLength: 100, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    GEEnderecoCodigoEndereco = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEGUsuario", x => x.CodigoUsuario);
                    table.ForeignKey(
                        name: "FK_SEGUsuario_GEEndereco_GEEnderecoCodigoEndereco",
                        column: x => x.GEEnderecoCodigoEndereco,
                        principalTable: "GEEndereco",
                        principalColumn: "CodigoEndereco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACAluno",
                columns: table => new
                {
                    CodigoAluno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCompleto = table.Column<string>(maxLength: 200, nullable: false),
                    RG = table.Column<string>(maxLength: 20, nullable: true),
                    CPF = table.Column<string>(maxLength: 11, nullable: true),
                    Sexo = table.Column<string>(maxLength: 1, nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    DiaVencimento = table.Column<int>(nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    CodigoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACAluno", x => x.CodigoAluno);
                    table.ForeignKey(
                        name: "FK_ACAluno_SEGUsuario_CodigoUsuario",
                        column: x => x.CodigoUsuario,
                        principalTable: "SEGUsuario",
                        principalColumn: "CodigoUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACProfessor",
                columns: table => new
                {
                    CodigoProfessor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    CodigoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACProfessor", x => x.CodigoProfessor);
                    table.ForeignKey(
                        name: "FK_ACProfessor_SEGUsuario_CodigoUsuario",
                        column: x => x.CodigoUsuario,
                        principalTable: "SEGUsuario",
                        principalColumn: "CodigoUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACResponsavel",
                columns: table => new
                {
                    CodigoResponsavel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCompleto = table.Column<string>(maxLength: 200, nullable: false),
                    RG = table.Column<string>(maxLength: 20, nullable: true),
                    CPF = table.Column<string>(maxLength: 11, nullable: true),
                    Sexo = table.Column<string>(maxLength: 1, nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    CodigoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACResponsavel", x => x.CodigoResponsavel);
                    table.ForeignKey(
                        name: "FK_ACResponsavel_SEGUsuario_CodigoUsuario",
                        column: x => x.CodigoUsuario,
                        principalTable: "SEGUsuario",
                        principalColumn: "CodigoUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GETelefone",
                columns: table => new
                {
                    CodigoTelefone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeroTelefone = table.Column<string>(maxLength: 20, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    CodigoTipoTelefone = table.Column<int>(nullable: false),
                    CodigoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GETelefone", x => x.CodigoTelefone);
                    table.ForeignKey(
                        name: "FK_GETelefone_GETipoTelefone_CodigoTipoTelefone",
                        column: x => x.CodigoTipoTelefone,
                        principalTable: "GETipoTelefone",
                        principalColumn: "CodigoTipoTelefone",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GETelefone_SEGUsuario_CodigoUsuario",
                        column: x => x.CodigoUsuario,
                        principalTable: "SEGUsuario",
                        principalColumn: "CodigoUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SEGUsuarioPerfil",
                columns: table => new
                {
                    CodigoUsuarioPerfil = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoPerfilPadrao = table.Column<int>(nullable: false),
                    CodigoUsuario = table.Column<int>(nullable: false),
                    CodigoPerfil = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEGUsuarioPerfil", x => x.CodigoUsuarioPerfil);
                    table.ForeignKey(
                        name: "FK_SEGUsuarioPerfil_SEGPerfil_CodigoPerfil",
                        column: x => x.CodigoPerfil,
                        principalTable: "SEGPerfil",
                        principalColumn: "CodigoPerfil",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SEGUsuarioPerfil_SEGUsuario_CodigoUsuario",
                        column: x => x.CodigoUsuario,
                        principalTable: "SEGUsuario",
                        principalColumn: "CodigoUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACTurma",
                columns: table => new
                {
                    CodigoTurma = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    ValorBase = table.Column<decimal>(nullable: false),
                    CodigoIdentificador = table.Column<string>(nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    CodigoEstagio = table.Column<int>(nullable: false),
                    CodigoProfessor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACTurma", x => x.CodigoTurma);
                    table.ForeignKey(
                        name: "FK_ACTurma_ACEstagio_CodigoEstagio",
                        column: x => x.CodigoEstagio,
                        principalTable: "ACEstagio",
                        principalColumn: "CodigoEstagio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ACTurma_ACProfessor_CodigoProfessor",
                        column: x => x.CodigoProfessor,
                        principalTable: "ACProfessor",
                        principalColumn: "CodigoProfessor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACAlunoResponsavel",
                columns: table => new
                {
                    CodigoAlunoResponsavel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoAluno = table.Column<int>(nullable: false),
                    CodigoResponsavel = table.Column<int>(nullable: false),
                    CodigoParentesco = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACAlunoResponsavel", x => x.CodigoAlunoResponsavel);
                    table.ForeignKey(
                        name: "FK_ACAlunoResponsavel_ACAluno_CodigoAluno",
                        column: x => x.CodigoAluno,
                        principalTable: "ACAluno",
                        principalColumn: "CodigoAluno",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ACAlunoResponsavel_GEParentesco_CodigoParentesco",
                        column: x => x.CodigoParentesco,
                        principalTable: "GEParentesco",
                        principalColumn: "CodigoParentesco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ACAlunoResponsavel_ACResponsavel_CodigoResponsavel",
                        column: x => x.CodigoResponsavel,
                        principalTable: "ACResponsavel",
                        principalColumn: "CodigoResponsavel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACMatricula",
                columns: table => new
                {
                    CodigoMatricula = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoIdentificador = table.Column<string>(nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    CodigoAluno = table.Column<int>(nullable: false),
                    CodigoTurma = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACMatricula", x => x.CodigoMatricula);
                    table.ForeignKey(
                        name: "FK_ACMatricula_ACAluno_CodigoAluno",
                        column: x => x.CodigoAluno,
                        principalTable: "ACAluno",
                        principalColumn: "CodigoAluno",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ACMatricula_ACTurma_CodigoTurma",
                        column: x => x.CodigoTurma,
                        principalTable: "ACTurma",
                        principalColumn: "CodigoTurma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACAvaliacao",
                columns: table => new
                {
                    CodigoAvaliacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 500, nullable: false),
                    DataAvaliacao = table.Column<DateTime>(nullable: false),
                    flSituacao = table.Column<string>(maxLength: 1, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    NotaAvaliacao = table.Column<decimal>(nullable: false),
                    CodigoMatricula = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACAvaliacao", x => x.CodigoAvaliacao);
                    table.ForeignKey(
                        name: "FK_ACAvaliacao_ACMatricula_CodigoMatricula",
                        column: x => x.CodigoMatricula,
                        principalTable: "ACMatricula",
                        principalColumn: "CodigoMatricula",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ACFrequencia",
                columns: table => new
                {
                    Codigofrequencia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    flSituacao = table.Column<string>(maxLength: 1, nullable: false),
                    DataFrequencia = table.Column<DateTime>(nullable: false),
                    Observacao = table.Column<string>(maxLength: 500, nullable: true),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    CodigoMatricula = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACFrequencia", x => x.Codigofrequencia);
                    table.ForeignKey(
                        name: "FK_ACFrequencia_ACMatricula_CodigoMatricula",
                        column: x => x.CodigoMatricula,
                        principalTable: "ACMatricula",
                        principalColumn: "CodigoMatricula",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FIMensalidade",
                columns: table => new
                {
                    CodigoMensalidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeroParcela = table.Column<int>(nullable: false),
                    DataVencimento = table.Column<DateTime>(nullable: false),
                    DataPagamento = table.Column<DateTime>(nullable: false),
                    DataEmissao = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    MesCompetencia = table.Column<int>(nullable: false),
                    AnoCompetencia = table.Column<int>(nullable: false),
                    flSituacao = table.Column<string>(maxLength: 1, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false),
                    CodigoMatricula = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FIMensalidade", x => x.CodigoMensalidade);
                    table.ForeignKey(
                        name: "FK_FIMensalidade_ACMatricula_CodigoMatricula",
                        column: x => x.CodigoMatricula,
                        principalTable: "ACMatricula",
                        principalColumn: "CodigoMatricula",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ACAluno_CodigoUsuario",
                table: "ACAluno",
                column: "CodigoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ACAlunoResponsavel_CodigoAluno",
                table: "ACAlunoResponsavel",
                column: "CodigoAluno");

            migrationBuilder.CreateIndex(
                name: "IX_ACAlunoResponsavel_CodigoParentesco",
                table: "ACAlunoResponsavel",
                column: "CodigoParentesco");

            migrationBuilder.CreateIndex(
                name: "IX_ACAlunoResponsavel_CodigoResponsavel",
                table: "ACAlunoResponsavel",
                column: "CodigoResponsavel");

            migrationBuilder.CreateIndex(
                name: "IX_ACAvaliacao_CodigoMatricula",
                table: "ACAvaliacao",
                column: "CodigoMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_ACEstagio_CodigoFaixaEtaria",
                table: "ACEstagio",
                column: "CodigoFaixaEtaria");

            migrationBuilder.CreateIndex(
                name: "IX_ACFrequencia_CodigoMatricula",
                table: "ACFrequencia",
                column: "CodigoMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_ACMatricula_CodigoAluno",
                table: "ACMatricula",
                column: "CodigoAluno");

            migrationBuilder.CreateIndex(
                name: "IX_ACMatricula_CodigoTurma",
                table: "ACMatricula",
                column: "CodigoTurma");

            migrationBuilder.CreateIndex(
                name: "IX_ACProfessor_CodigoUsuario",
                table: "ACProfessor",
                column: "CodigoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ACResponsavel_CodigoUsuario",
                table: "ACResponsavel",
                column: "CodigoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ACTurma_CodigoEstagio",
                table: "ACTurma",
                column: "CodigoEstagio");

            migrationBuilder.CreateIndex(
                name: "IX_ACTurma_CodigoProfessor",
                table: "ACTurma",
                column: "CodigoProfessor");

            migrationBuilder.CreateIndex(
                name: "IX_FIMensalidade_CodigoMatricula",
                table: "FIMensalidade",
                column: "CodigoMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_GEBairro_CodigoCidade",
                table: "GEBairro",
                column: "CodigoCidade");

            migrationBuilder.CreateIndex(
                name: "IX_GECidade_CodigoUF",
                table: "GECidade",
                column: "CodigoUF");

            migrationBuilder.CreateIndex(
                name: "IX_GEEndereco_CodigoBairro",
                table: "GEEndereco",
                column: "CodigoBairro");

            migrationBuilder.CreateIndex(
                name: "IX_GETelefone_CodigoTipoTelefone",
                table: "GETelefone",
                column: "CodigoTipoTelefone");

            migrationBuilder.CreateIndex(
                name: "IX_GETelefone_CodigoUsuario",
                table: "GETelefone",
                column: "CodigoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_SEGUsuario_GEEnderecoCodigoEndereco",
                table: "SEGUsuario",
                column: "GEEnderecoCodigoEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_SEGUsuarioPerfil_CodigoPerfil",
                table: "SEGUsuarioPerfil",
                column: "CodigoPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_SEGUsuarioPerfil_CodigoUsuario",
                table: "SEGUsuarioPerfil",
                column: "CodigoUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACAlunoResponsavel");

            migrationBuilder.DropTable(
                name: "ACAvaliacao");

            migrationBuilder.DropTable(
                name: "ACFrequencia");

            migrationBuilder.DropTable(
                name: "FIMensalidade");

            migrationBuilder.DropTable(
                name: "GETelefone");

            migrationBuilder.DropTable(
                name: "SEGUsuarioPerfil");

            migrationBuilder.DropTable(
                name: "GEParentesco");

            migrationBuilder.DropTable(
                name: "ACResponsavel");

            migrationBuilder.DropTable(
                name: "ACMatricula");

            migrationBuilder.DropTable(
                name: "GETipoTelefone");

            migrationBuilder.DropTable(
                name: "SEGPerfil");

            migrationBuilder.DropTable(
                name: "ACAluno");

            migrationBuilder.DropTable(
                name: "ACTurma");

            migrationBuilder.DropTable(
                name: "ACEstagio");

            migrationBuilder.DropTable(
                name: "ACProfessor");

            migrationBuilder.DropTable(
                name: "ACFaixaEtaria");

            migrationBuilder.DropTable(
                name: "SEGUsuario");

            migrationBuilder.DropTable(
                name: "GEEndereco");

            migrationBuilder.DropTable(
                name: "GEBairro");

            migrationBuilder.DropTable(
                name: "GECidade");

            migrationBuilder.DropTable(
                name: "GEUF");
        }
    }
}
