﻿using Microsoft.EntityFrameworkCore;
using ProjetoModels.Models;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadawanInfra.Context
{
    public class AlunoContext : DbContext
    {
        public DbSet<Alunos> Aluno { get; set; }
        public DbSet<Cursos> Curso { get; set; }
        public DbSet<Materias> Materia { get; set; }
        public DbSet<Notas> Notas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        public AlunoContext()
        {

        }
        public AlunoContext(DbContextOptions<AlunoContext> context):base(context)
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source = NT-04780\\SQLEXPRESS; database = BancoBoletimNovissimo; Trusted_Connection=True;MultipleActiveResultSets=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelBuilderAluno(modelBuilder);
            ModelBuilderCurso(modelBuilder);
            ModelBuilderMaterias(modelBuilder);
            ModelBuilderNotas(modelBuilder);
            ModelBuilderCursoMateria(modelBuilder);
            ModelBuilderUsuario(modelBuilder);
        }

        public void ModelBuilderAluno(ModelBuilder builder)
        {
            builder.Entity<Alunos>().HasKey(q => q.Id);
            builder.Entity<Alunos>().Property(q => q.Nome).IsRequired();
            builder.Entity<Alunos>().Property(q => q.Sobrenome).IsRequired();
            builder.Entity<Alunos>().Property(q => q.Cpf).IsRequired();
            builder.Entity<Alunos>().Property(q => q.DataNascimento).IsRequired();
            builder.Entity<Alunos>().HasOne(q => q.Curso).WithMany().HasForeignKey(q => q.IdCurso);
            builder.Entity<Alunos>().HasMany(q => q.Notas).WithOne(q => q.Aluno);
        }
        public void ModelBuilderCurso(ModelBuilder builder)
        {
            builder.Entity<Cursos>().HasKey(q => q.Id);
            builder.Entity<Cursos>().Property(q => q.Nome).IsRequired();
            builder.Entity<Cursos>().Property(q => q.Situacao).IsRequired();
            builder.Entity<Cursos>().HasMany(q => q.Alunos).WithOne(q=>q.Curso);
            builder.Entity<Cursos>().HasMany(q => q.CursoMateria).WithOne(q => q.Curso);
        }
        public void ModelBuilderMaterias(ModelBuilder builder)
        {
            builder.Entity<Materias>().HasKey(q => q.Id);
            builder.Entity<Materias>().Property(q=>q.Nome).IsRequired();
            builder.Entity<Materias>().Property(q => q.Situacao).IsRequired();
            builder.Entity<Materias>().Property(q => q.Descricao).IsRequired();
            builder.Entity<Materias>().Property(q => q.DataCadastro).IsRequired();
            builder.Entity<Materias>().HasMany(q => q.Nota).WithOne(q => q.Materia);
            builder.Entity<Materias>().HasMany(q => q.CursosMaterias).WithOne(q => q.Materia);
        }
        public void ModelBuilderNotas(ModelBuilder builder)
        {
            builder.Entity<Notas>().HasKey(q => q.Id);
            builder.Entity<Notas>().Property(q => q.Nota).IsRequired();
            //builder.Entity<Notas>().HasOne(q => q.Aluno).WithMany().HasForeignKey(q => q.AlunoId);
            //builder.Entity<Notas>().HasOne(q => q.Materia).WithMany().HasForeignKey(q => q.MateriaId);
            //builder.Entity<Notas>().ToTable("Notas123");
        }
        public void ModelBuilderCursoMateria(ModelBuilder builder)
        {
            builder.Entity<CursosMaterias>().HasKey(e => new { e.CursoId, e.MateriaId });
        }
        public void ModelBuilderUsuario(ModelBuilder builder)
        {
            builder.Entity<Usuarios>().HasKey(q => q.Id);
            builder.Entity<Usuarios>().Property(q => q.Username).IsRequired();
            builder.Entity<Usuarios>().Property(q => q.Password).IsRequired();
            builder.Entity<Usuarios>().Property(q => q.Acesso).IsRequired();
        }
    }
}
