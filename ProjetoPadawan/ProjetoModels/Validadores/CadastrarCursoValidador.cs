using FluentValidation;
using PadawanInfra.Interfaces;
using ProjetoDomain.Validadores;
using ProjetoDomain.Validadores.Interfaces;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjetoModels.Validadores
{
    public class CadastrarCursoValidador : AbstractValidator<Cursos>, ICadastrarCursoValidator
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly IMateriasRepository _materiasRepository;
        public CadastrarCursoValidador(ICursoRepository cursoRepository, IMateriasRepository materiasRepository = null)
        {
            _cursoRepository = cursoRepository;
            _materiasRepository = materiasRepository;
            VerificaObrigatoriedade();
            VerificaSeCursoJaExiste();
        }
        public void VerificaObrigatoriedade()
        {
            RuleFor(q => q.Nome).NotEmpty().WithMessage("O campo nome é obrigatório!").IsValidName().WithMessage("O campo nome só pode conter letras!");
            RuleFor(q => q.Materia).NotEmpty().WithMessage("O campo matéria é obrigatório!");
            RuleFor(q => q.Situacao).NotEmpty().WithMessage("O campo situação é obrigatório!");
        }
        
        public void VerificaSeCursoJaExiste()
        {
            RuleFor(q => q.Nome).Must((nome) =>
            {
                return !_cursoRepository.VerificaSeCursoExiste(nome);
            }).WithMessage("Esse curso já existe!").WithSeverity(Severity.Error);
        }
        public void VerificaSeMateriaExiste()
        {
            RuleFor(q => q.Materia).Must((materia) =>
            {
                return _materiasRepository.VerificaMateriaExiste(materia);
            }).WithMessage("Essa matéria ainda não foi cadastrada!").WithSeverity(Severity.Error);
        }
    }
}
