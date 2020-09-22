using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPadawan.Migrations
{
    public partial class banco6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CursosMaterias_Curso_CursosId",
                table: "CursosMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_CursosMaterias_Materias_MateriaId",
                table: "CursosMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Aluno_AlunoId",
                table: "Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Aluno_AlunosId",
                table: "Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Materias_MateriaId",
                table: "Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Materias_MateriasId",
                table: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Notas_AlunosId",
                table: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Notas_MateriasId",
                table: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_CursosMaterias_CursosId",
                table: "CursosMaterias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materias",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "AlunosId",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "MateriasId",
                table: "Notas");

            migrationBuilder.DropColumn(
                name: "CursosId",
                table: "CursosMaterias");

            migrationBuilder.RenameTable(
                name: "Materias",
                newName: "Materia");

            migrationBuilder.AlterColumn<int>(
                name: "MateriaId",
                table: "Notas",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
                table: "Notas",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materia",
                table: "Materia",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CursosMaterias_Curso_CursoId",
                table: "CursosMaterias",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursosMaterias_Materia_MateriaId",
                table: "CursosMaterias",
                column: "MateriaId",
                principalTable: "Materia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Aluno_AlunoId",
                table: "Notas",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Materia_MateriaId",
                table: "Notas",
                column: "MateriaId",
                principalTable: "Materia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CursosMaterias_Curso_CursoId",
                table: "CursosMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_CursosMaterias_Materia_MateriaId",
                table: "CursosMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Aluno_AlunoId",
                table: "Notas");

            migrationBuilder.DropForeignKey(
                name: "FK_Notas_Materia_MateriaId",
                table: "Notas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materia",
                table: "Materia");

            migrationBuilder.RenameTable(
                name: "Materia",
                newName: "Materias");

            migrationBuilder.AlterColumn<int>(
                name: "MateriaId",
                table: "Notas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AlunoId",
                table: "Notas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlunosId",
                table: "Notas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MateriasId",
                table: "Notas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CursosId",
                table: "CursosMaterias",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materias",
                table: "Materias",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_AlunosId",
                table: "Notas",
                column: "AlunosId");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_MateriasId",
                table: "Notas",
                column: "MateriasId");

            migrationBuilder.CreateIndex(
                name: "IX_CursosMaterias_CursosId",
                table: "CursosMaterias",
                column: "CursosId");

            migrationBuilder.AddForeignKey(
                name: "FK_CursosMaterias_Curso_CursosId",
                table: "CursosMaterias",
                column: "CursosId",
                principalTable: "Curso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Notas_Aluno_AlunosId",
                table: "Notas",
                column: "AlunosId",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Materias_MateriaId",
                table: "Notas",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notas_Materias_MateriasId",
                table: "Notas",
                column: "MateriasId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
