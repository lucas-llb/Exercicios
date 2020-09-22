using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPadawan.Migrations
{
    public partial class tentativa2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CursosId",
                table: "Aluno",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_CursosId",
                table: "Aluno",
                column: "CursosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Curso_CursosId",
                table: "Aluno",
                column: "CursosId",
                principalTable: "Curso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Curso_CursosId",
                table: "Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_CursosId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "CursosId",
                table: "Aluno");
        }
    }
}
