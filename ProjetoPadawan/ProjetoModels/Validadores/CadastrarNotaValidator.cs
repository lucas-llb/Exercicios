using FluentValidation;
using PadawanInfra.Interfaces;
using ProjetoDomain.Validadores.Interfaces;
using ProjetoPadawan.Models;

namespace ProjetoDomain.Validadores
{
    public class CadastrarNotaValidator : AbstractValidator<Notas>, ICadastrarNotaValidator
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMateriasRepository _materiasRepository;

        public CadastrarNotaValidator(IAlunoRepository alunoRepository, IMateriasRepository materiasRepository)
        {
            _alunoRepository = alunoRepository;
            _materiasRepository = materiasRepository;
        }

        public void VerificaObrigatoriedade()
        {
            RuleFor(q => q.Nota).NotEmpty().WithMessage("O campo nota é obrigatório!").IsValidNote().WithMessage("A nota deve estar entre 0 e 100!");
        }

        public void VerificaAlunoExiste()
        {
            RuleFor(q => q.AlunoId).MustAsync(async (id, _) =>
              {
                  return _alunoRepository.GetByIdAsync(id) != null;
              }).WithMessage("Esse aluno não existe!").WithSeverity(Severity.Error);
        }
        public void VerificaMateriaExiste()
        {
            RuleFor(q => q.MateriaId).MustAsync(async (id, _) =>
              {
                  return _materiasRepository.GetByIdAsync(id) != null;
              }).WithMessage("Essa matéria não existe!").WithSeverity(Severity.Error);
        }
    }
}
