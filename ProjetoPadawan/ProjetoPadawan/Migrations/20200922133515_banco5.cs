using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPadawan.Migrations
{
    public partial class banco5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Curso_CursosId",
                table: "Aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_CursosMaterias_Materias_MateriaID",
                table: "CursosMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Aluno_IdAluno",
                table: "Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Materias_IdMateria",
                table: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Notas_IdAluno",
                table: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Notas_IdMateria",
                table: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_CursosId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "IdAluno",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "IdMateria",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "CursosId",
                table: "Aluno");

            migrationBuilder.RenameColumn(
                name: "MateriaID",
                table: "CursosMaterias",
                newName: "MateriaId");

            migrationBuilder.RenameColumn(
                name: "CursoID",
                table: "CursosMaterias",
                newName: "CursoId");

            migrationBuilder.RenameIndex(
                name: "IX_CursosMaterias_MateriaID",
                table: "CursosMaterias",
                newName: "IX_CursosMaterias_MateriaId");

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Notas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MateriaId",
                table: "Notas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notas_AlunoId",
                table: "Notas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_MateriaId",
                table: "Notas",
                column: "MateriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_CursosMaterias_Materias_MateriaId",
                table: "CursosMaterias",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Aluno_AlunoId",
                table: "Notas",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Materias_MateriaId",
                table: "Notas",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CursosMaterias_Materias_MateriaId",
                table: "CursosMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Aluno_AlunoId",
                table: "Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Materias_MateriaId",
                table: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Notas_AlunoId",
                table: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Notas_MateriaId",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "MateriaId",
                table: "Notas");

            migrationBuilder.RenameColumn(
                name: "MateriaId",
                table: "CursosMaterias",
                newName: "MateriaID");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "CursosMaterias",
                newName: "CursoID");

            migrationBuilder.RenameIndex(
                name: "IX_CursosMaterias_MateriaId",
                table: "CursosMaterias",
                newName: "IX_CursosMaterias_MateriaID");

            migrationBuilder.AddColumn<int>(
                name: "IdAluno",
                table: "Notas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMateria",
                table: "Notas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CursosId",
                table: "Aluno",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notas_IdAluno",
                table: "Notas",
                column: "IdAluno");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_IdMateria",
                table: "Notas",
                column: "IdMateria");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CursosMaterias_Materias_MateriaID",
                table: "CursosMaterias",
                column: "MateriaID",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Aluno_IdAluno",
                table: "Notas",
                column: "IdAluno",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Materias_IdMateria",
                table: "Notas",
                column: "IdMateria",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
