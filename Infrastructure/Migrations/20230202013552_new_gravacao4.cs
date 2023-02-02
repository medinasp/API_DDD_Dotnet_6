using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class new_gravacao4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gravacao_Entrevista_EntrevistaIdEntrevista",
                table: "Gravacao");

            migrationBuilder.RenameColumn(
                name: "IdEntrevista",
                table: "Gravacao",
                newName: "novotest");

            migrationBuilder.AlterColumn<int>(
                name: "EntrevistaIdEntrevista",
                table: "Gravacao",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Gravacao_Entrevista_EntrevistaIdEntrevista",
                table: "Gravacao",
                column: "EntrevistaIdEntrevista",
                principalTable: "Entrevista",
                principalColumn: "IdEntrevista");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gravacao_Entrevista_EntrevistaIdEntrevista",
                table: "Gravacao");

            migrationBuilder.RenameColumn(
                name: "novotest",
                table: "Gravacao",
                newName: "IdEntrevista");

            migrationBuilder.AlterColumn<int>(
                name: "EntrevistaIdEntrevista",
                table: "Gravacao",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Gravacao_Entrevista_EntrevistaIdEntrevista",
                table: "Gravacao",
                column: "EntrevistaIdEntrevista",
                principalTable: "Entrevista",
                principalColumn: "IdEntrevista",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
