using Microsoft.EntityFrameworkCore;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPadawan.Data
{
    public class AlunoContext : DbContext 
    {
        public DbSet<Alunos> Aluno { get; set; }
        public DbSet<Cursos> Curso { get; set; }
        public DbSet<Materias> Materias { get; set; }
        public DbSet<Notas> Notas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;User ID=HBSISNET\lucas.barbosa;Initial Catalog=BoletimAPI;Data Source=NT-04780\SQLEXPRESS");
        }
    }
}
