using Microsoft.EntityFrameworkCore.Migrations;

namespace PaginaDeCadastro.Migrations
{
    public partial class Corrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CidadeNac",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "EstadoNac",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Naturalidade",
                table: "Pessoa");

            migrationBuilder.AlterColumn<string>(
                name: "Sobrenome",
                table: "Pessoa",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomePai",
                table: "Pessoa",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeMae",
                table: "Pessoa",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoa",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CidadeNat",
                table: "Pessoa",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EstadoNat",
                table: "Pessoa",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nacionalidade",
                table: "Pessoa",
                maxLength: 60,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CidadeNat",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "EstadoNat",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "Nacionalidade",
                table: "Pessoa");

            migrationBuilder.AlterColumn<string>(
                name: "Sobrenome",
                table: "Pessoa",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "NomePai",
                table: "Pessoa",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "NomeMae",
                table: "Pessoa",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoa",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AddColumn<string>(
                name: "CidadeNac",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoNac",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Naturalidade",
                table: "Pessoa",
                nullable: true);
        }
    }
}
