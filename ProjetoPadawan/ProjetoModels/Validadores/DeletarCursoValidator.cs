using FluentValidation;
using PadawanInfra.Interfaces;
using ProjetoDomain.Validadores.Interfaces;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDomain.Validadores
{
    public class DeletarCursoValidator : AbstractValidator<Guid>, IDeletarCursoValidator
    {
        private readonly ICursoRepository _cursoRepository;

        public DeletarCursoValidator(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
            VerificaIdCursoExiste();
        }

        public void VerificaIdCursoExiste()
        {
            RuleFor(q => q).MustAsync(async (id, _) =>
            {
                return await _cursoRepository.GetByIdAsync(id) != null;
            }).WithMessage("Esse curso não existe!").WithSeverity(Severity.Error);
        }
    }
}
