using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace One.Infra.Data.Migrations
{
    public partial class iniciocorreção : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SEGUsuario_GEEndereco_GEEnderecoCodigoEndereco",
                table: "SEGUsuario");

            migrationBuilder.DropIndex(
                name: "IX_SEGUsuario_GEEnderecoCodigoEndereco",
                table: "SEGUsuario");

            migrationBuilder.DropColumn(
                name: "GEEnderecoCodigoEndereco",
                table: "SEGUsuario");

            migrationBuilder.CreateTable(
                name: "GEUsuarioEndereco",
                columns: table => new
                {
                    CodigoUsuarioEndereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoUsuario = table.Column<int>(nullable: false),
                    CodigoEndereco = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GEUsuarioEndereco", x => x.CodigoUsuarioEndereco);
                    table.ForeignKey(
                        name: "FK_GEUsuarioEndereco_GEEndereco_CodigoEndereco",
                        column: x => x.CodigoEndereco,
                        principalTable: "GEEndereco",
                        principalColumn: "CodigoEndereco",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GEUsuarioEndereco_SEGUsuario_CodigoUsuario",
                        column: x => x.CodigoUsuario,
                        principalTable: "SEGUsuario",
                        principalColumn: "CodigoUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GEUsuarioEndereco_CodigoEndereco",
                table: "GEUsuarioEndereco",
                column: "CodigoEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_GEUsuarioEndereco_CodigoUsuario",
                table: "GEUsuarioEndereco",
                column: "CodigoUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GEUsuarioEndereco");

            migrationBuilder.AddColumn<int>(
                name: "GEEnderecoCodigoEndereco",
                table: "SEGUsuario",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SEGUsuario_GEEnderecoCodigoEndereco",
                table: "SEGUsuario",
                column: "GEEnderecoCodigoEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_SEGUsuario_GEEndereco_GEEnderecoCodigoEndereco",
                table: "SEGUsuario",
                column: "GEEnderecoCodigoEndereco",
                principalTable: "GEEndereco",
                principalColumn: "CodigoEndereco",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
