using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace One.Infra.Data.Migrations
{
    public partial class accategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodigoCategoria",
                table: "ACNivel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ACCategoria",
                columns: table => new
                {
                    CodigoCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescicaoCategoria = table.Column<string>(maxLength: 50, nullable: false),
                    flAtivo = table.Column<string>(maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCategoria", x => x.CodigoCategoria);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ACNivel_CodigoCategoria",
                table: "ACNivel",
                column: "CodigoCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_ACNivel_ACCategoria_CodigoCategoria",
                table: "ACNivel",
                column: "CodigoCategoria",
                principalTable: "ACCategoria",
                principalColumn: "CodigoCategoria",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ACNivel_ACCategoria_CodigoCategoria",
                table: "ACNivel");

            migrationBuilder.DropTable(
                name: "ACCategoria");

            migrationBuilder.DropIndex(
                name: "IX_ACNivel_CodigoCategoria",
                table: "ACNivel");

            migrationBuilder.DropColumn(
                name: "CodigoCategoria",
                table: "ACNivel");
        }
    }
}
