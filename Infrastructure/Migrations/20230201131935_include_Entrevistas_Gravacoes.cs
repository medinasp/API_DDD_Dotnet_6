using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class include_Entrevistas_Gravacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdEntrevistum",
                table: "Gravacao",
                newName: "IdEntrevista");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdEntrevista",
                table: "Gravacao",
                newName: "IdEntrevistum");
        }
    }
}
