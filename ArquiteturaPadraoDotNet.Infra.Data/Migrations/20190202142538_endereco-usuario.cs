using Microsoft.EntityFrameworkCore.Migrations;

namespace One.Infra.Data.Migrations
{
    public partial class enderecousuario : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "CodigoUsuario",
                table: "GEEndereco",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GEEndereco_CodigoUsuario",
                table: "GEEndereco",
                column: "CodigoUsuario",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GEEndereco_SEGUsuario_CodigoUsuario",
                table: "GEEndereco",
                column: "CodigoUsuario",
                principalTable: "SEGUsuario",
                principalColumn: "CodigoUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GEEndereco_SEGUsuario_CodigoUsuario",
                table: "GEEndereco");

            migrationBuilder.DropIndex(
                name: "IX_GEEndereco_CodigoUsuario",
                table: "GEEndereco");

            migrationBuilder.DropColumn(
                name: "CodigoUsuario",
                table: "GEEndereco");

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
