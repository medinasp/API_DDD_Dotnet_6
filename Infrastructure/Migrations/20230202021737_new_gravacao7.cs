using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class new_gravacao7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gravacao_Entrevista_EntrevistaIdEntrevista",
                table: "Gravacao");

            migrationBuilder.DropIndex(
                name: "IX_Gravacao_EntrevistaIdEntrevista",
                table: "Gravacao");

            migrationBuilder.DropColumn(
                name: "EntrevistaIdEntrevista",
                table: "Gravacao");

            migrationBuilder.RenameColumn(
                name: "Gravacao",
                table: "Entrevista",
                newName: "Gravacao1");

            migrationBuilder.CreateIndex(
                name: "IX_Gravacao_IdEntrevista",
                table: "Gravacao",
                column: "IdEntrevista",
                unique: true,
                filter: "[IdEntrevista] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Gravacao_Entrevista_IdEntrevista",
                table: "Gravacao",
                column: "IdEntrevista",
                principalTable: "Entrevista",
                principalColumn: "IdEntrevista");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gravacao_Entrevista_IdEntrevista",
                table: "Gravacao");

            migrationBuilder.DropIndex(
                name: "IX_Gravacao_IdEntrevista",
                table: "Gravacao");

            migrationBuilder.RenameColumn(
                name: "Gravacao1",
                table: "Entrevista",
                newName: "Gravacao");

            migrationBuilder.AddColumn<int>(
                name: "EntrevistaIdEntrevista",
                table: "Gravacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Gravacao_EntrevistaIdEntrevista",
                table: "Gravacao",
                column: "EntrevistaIdEntrevista");

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
