using FluentValidation;
using PadawanInfra.Interfaces;
using ProjetoDomain.Interfaces;
using ProjetoDomain.Validadores;
using ProjetoDomain.Validadores.Interfaces;
using ProjetoPadawan.Models;

namespace ProjetoModels.Validadores
{
    public class CadastrarAlunoValidador : AbstractValidator<Alunos>, IAlunoValidator
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly ICursoRepository _cursoRepository;
        public CadastrarAlunoValidador()
        {
            VerificaObrigatoriedade();
        }

        public void VerificaObrigatoriedade()
        {
            RuleFor(q => q.Nome).NotEmpty().WithMessage("O campo nome é obrigatório!").IsValidName().WithMessage("O campo nome só pode conter letras!");
            RuleFor(q => q.Sobrenome).NotEmpty().WithMessage("O campo sobrenome é obrigatório!");
            RuleFor(q => q.Cpf).NotEmpty().WithMessage("O campo CPF é obrigatório!").IsValidCpf().WithMessage("O campo cpf deve conter apenas números!");
            RuleFor(q => q.DataNascimento.ToString("dd/MM/YYYY")).NotEmpty().WithMessage("O campo data de nascimento é obrigatório!").IsValidDateBirth().WithMessage("Não pode ser após 01/01/2002");
            RuleFor(q => q.IdCurso).NotEmpty().WithMessage("O campo curso é obrigatório!");
        }
        
        public void VerificaSeCpfJaExiste()
        {
            RuleFor(q => q.Cpf).Must((cpf) =>
            {
                return !_alunoRepository.VerificaCpfExiste(cpf);
            }).WithMessage("O aluno já foi cadastrado!").WithSeverity(Severity.Error);
        }
        public void VerificaIdCursoExiste()
        {
            RuleFor(q => q.IdCurso).MustAsync(async (id, _) =>
            {
                return _cursoRepository.GetByIdAsync(id) != null;
            }).WithMessage("O curso não existe!").WithSeverity(Severity.Error);
        }
    }
}
