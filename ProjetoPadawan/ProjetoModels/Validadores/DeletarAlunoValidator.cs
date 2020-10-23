using FluentValidation;
using PadawanInfra.Interfaces;
using ProjetoDomain.Validadores.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDomain.Validadores
{
    public class DeletarAlunoValidator : AbstractValidator<Guid>, IDeletarAlunoValidator
    {
        private readonly IAlunoRepository _alunoRepository;

        public DeletarAlunoValidator(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public void VerificaIdAlunoExiste()
        {
            RuleFor(q => q).MustAsync(async (id, _) =>
              {
                  return await _alunoRepository.GetByIdAsync(id) != null;
              }).WithMessage("Esse aluno não existe!").WithSeverity(Severity.Error);
        }
    }
}
