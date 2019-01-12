using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace One.Infra.Data.Migrations
{
    public partial class tabelasmodulogeral : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GETipoTelefone",
                columns: table => new
                {
                    CodigoTipoTelefone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 30, nullable: true),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: true)
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
                    Descricao = table.Column<string>(nullable: true),
                    Sigla = table.Column<string>(nullable: true),
                    flAtivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEUF", x => x.CodigoUF);
                });

            migrationBuilder.CreateTable(
                name: "GETelefone",
                columns: table => new
                {
                    CodigoTelefone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeroTelefone = table.Column<string>(maxLength: 20, nullable: true),
                    CodigoTipoTelefone = table.Column<int>(nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "GECidade",
                columns: table => new
                {
                    CodigoCidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 100, nullable: true),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: true),
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
                    descricao = table.Column<string>(maxLength: 100, nullable: true),
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
                    Logradouro = table.Column<string>(maxLength: 300, nullable: true),
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
                name: "GEResponsavel",
                columns: table => new
                {
                    CodigoResponsavel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPF = table.Column<string>(maxLength: 11, nullable: true),
                    NomeCompleto = table.Column<string>(maxLength: 300, nullable: true),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: true),
                    CodigoEndereco = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEResponsavel", x => x.CodigoResponsavel);
                    table.ForeignKey(
                        name: "FK_GEResponsavel_GEEndereco_CodigoEndereco",
                        column: x => x.CodigoEndereco,
                        principalTable: "GEEndereco",
                        principalColumn: "CodigoEndereco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GEAluno",
                columns: table => new
                {
                    CodigoALuno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeCompleto = table.Column<string>(maxLength: 200, nullable: true),
                    Sexo = table.Column<string>(maxLength: 1, nullable: true),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    CodigoEndereco = table.Column<int>(nullable: false),
                    CodigoResponsavel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEAluno", x => x.CodigoALuno);
                    table.ForeignKey(
                        name: "FK_GEAluno_GEEndereco_CodigoEndereco",
                        column: x => x.CodigoEndereco,
                        principalTable: "GEEndereco",
                        principalColumn: "CodigoEndereco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GEAluno_GEResponsavel_CodigoResponsavel",
                        column: x => x.CodigoResponsavel,
                        principalTable: "GEResponsavel",
                        principalColumn: "CodigoResponsavel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GEAluno_CodigoEndereco",
                table: "GEAluno",
                column: "CodigoEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_GEAluno_CodigoResponsavel",
                table: "GEAluno",
                column: "CodigoResponsavel");

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
                name: "IX_GEResponsavel_CodigoEndereco",
                table: "GEResponsavel",
                column: "CodigoEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_GETelefone_CodigoTipoTelefone",
                table: "GETelefone",
                column: "CodigoTipoTelefone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GEAluno");

            migrationBuilder.DropTable(
                name: "GETelefone");

            migrationBuilder.DropTable(
                name: "GEResponsavel");

            migrationBuilder.DropTable(
                name: "GETipoTelefone");

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
