using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class new_gravacao5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "novotest",
                table: "Gravacao",
                newName: "IdEntrevista");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Gravacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FileSize",
                table: "Gravacao",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeDoArquivo",
                table: "Gravacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Gravacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ramal",
                table: "Gravacao",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Gravacao");

            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "Gravacao");

            migrationBuilder.DropColumn(
                name: "NomeDoArquivo",
                table: "Gravacao");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Gravacao");

            migrationBuilder.DropColumn(
                name: "Ramal",
                table: "Gravacao");

            migrationBuilder.RenameColumn(
                name: "IdEntrevista",
                table: "Gravacao",
                newName: "novotest");
        }
    }
}
