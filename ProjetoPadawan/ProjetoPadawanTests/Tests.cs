using ProjetoModels.Validadores;
using ProjetoPadawan.Models;
using System;
using Xunit;
namespace ProjetoPadawanTests
{
    public class Tests
    {
        [Fact]
        public void TestaNomeAluno_true()
        {
            var aluno = new Alunos()
            {
                Nome = "Teste",
                Sobrenome = "Da Silva",
                Cpf = "18549528630",
                DataNascimento = Convert.ToDateTime("20/5/1998")
            };
            var result = new CadastrarAlunoValidador().Validar(aluno);
            Assert.True(result.IsValid);
        }
        [Fact]
        public void TestaNomeNullAluno_false()
        {
            var aluno = new Alunos()
            {
                Nome = "",
                Sobrenome = "Da Silva",
                Cpf = "18549528630",
                DataNascimento = Convert.ToDateTime("20/5/1998")
            };
            var result = new CadastrarAlunoValidador().Validar(aluno);
            Assert.False(result.IsValid);
        }
        [Fact]
        public void TestaNomeNumeroAluno_false()
        {
            var aluno = new Alunos()
            {
                Nome = "Teste5",
                Sobrenome = "Da Silva",
                Cpf = "18549528630",
                DataNascimento = Convert.ToDateTime("20/5/1998")
            };
            var result = new CadastrarAlunoValidador().Validar(aluno);
            Assert.False(result.IsValid);
        }
        [Fact]
        public void TestaSobrenomeNullAluno_false()
        {
            var aluno = new Alunos()
            {
                Nome = "Teste",
                Sobrenome = "",
                Cpf = "18549528630",
                DataNascimento = Convert.ToDateTime("20/5/1998")
            };
            var result = new CadastrarAlunoValidador().Validar(aluno);
            Assert.False(result.IsValid);
        }
        [Fact]
        public void TestaCpfMaisNumerosAluno_false()
        {
            var aluno = new Alunos()
            {
                Nome = "Teste",
                Sobrenome = "Da Silva",
                Cpf = "185495286305",
                DataNascimento = Convert.ToDateTime("20/5/1998")
            };
            var result = new CadastrarAlunoValidador().Validar(aluno);
            Assert.False(result.IsValid);
        }
        [Fact]
        public void TestaCpfLetrasAluno_false()
        {
            var aluno = new Alunos()
            {
                Nome = "Teste",
                Sobrenome = "Da Silva",
                Cpf = "18549a528630",
                DataNascimento = Convert.ToDateTime("20/5/1998")
            };
            var result = new CadastrarAlunoValidador().Validar(aluno);
            Assert.False(result.IsValid);
        }
        [Fact]
        public void TestaCpfFaltaNumeroAluno_cpf()
        {
            var aluno = new Alunos()
            {
                Nome = "Teste",
                Sobrenome = "Da Silva",
                Cpf = "185452630",
                DataNascimento = Convert.ToDateTime("20/5/1998")
            };
            var result = new CadastrarAlunoValidador().Validar(aluno);
            Assert.False(result.IsValid);
        }
        [Fact]
        public void TestaCpfCaracEspeciaisAluno_false()
        {
            var aluno = new Alunos()
            {
                Nome = "Teste",
                Sobrenome = "Da Silva",
                Cpf = "185495*28630",
                DataNascimento = Convert.ToDateTime("20/5/1998")
            };
            var result = new CadastrarAlunoValidador().Validar(aluno);
            Assert.False(result.IsValid);
        }
        [Fact]
        public void TestaDataMaiorQueLimiteAluno_false()
        {
            var aluno = new Alunos()
            {
                Nome = "Teste",
                Sobrenome = "Da Silva",
                Cpf = "18549528630",
                DataNascimento = Convert.ToDateTime("02/01/2002")
            };
            var result = new CadastrarAlunoValidador().Validar(aluno);
            Assert.False(result.IsValid);
        }
        [Fact]
        public void TestaDataImpossivelAluno_false()
        {
            var aluno = new Alunos()
            {
                Nome = "Teste",
                Sobrenome = "Da Silva",
                Cpf = "18549528630",
                DataNascimento = Convert.ToDateTime("30/02/1998")
            };
            var result = new CadastrarAlunoValidador().Validar(aluno);
            Assert.True(result.IsValid);
        }
    }
}
