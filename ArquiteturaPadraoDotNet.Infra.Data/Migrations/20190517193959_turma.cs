using Microsoft.EntityFrameworkCore.Migrations;

namespace One.Infra.Data.Migrations
{
    public partial class turma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "ACTurma",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "HoraFim",
                table: "ACTurma",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HoraInicio",
                table: "ACTurma",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoraFim",
                table: "ACTurma");

            migrationBuilder.DropColumn(
                name: "HoraInicio",
                table: "ACTurma");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "ACTurma",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 400);
        }
    }
}
