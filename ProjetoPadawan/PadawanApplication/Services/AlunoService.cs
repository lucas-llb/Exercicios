using FluentValidation;
using PadawanApplication.Interfaces;
using PadawanInfra.Interfaces;
using ProjetoDomain.Interfaces;
using ProjetoDomain.Validadores.Interfaces;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawanApplication.Services
{
    public class AlunoService : BaseServices, IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IAlunoValidator _alunoValidator;
        private readonly IDeletarAlunoValidator _deletarAlunoValidator;
        public AlunoService(IAlunoValidator alunoValidator, IAlunoRepository alunoRepository, IDeletarAlunoValidator deletarAlunoValidator)
        {
            _alunoValidator = alunoValidator;
            _alunoRepository = alunoRepository;
            _deletarAlunoValidator = deletarAlunoValidator;
        }
        public async Task<ResponseToUser> CreateAsync(Alunos aluno)
        {
            aluno.Cpf = Alunos.FormataCpf(aluno.Cpf);
            var result = _alunoValidator.Validate(aluno);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            else
            {
                await _alunoRepository.CreateAsync(aluno);
                return SuccesResult();
            }
        }
        public async Task<IEnumerable<Alunos>> GetAllAsync()
        {
            return await _alunoRepository.GetAllAsync();
        }
        public async Task<ResponseToUser> DeleteAsync(Guid id)
        {
            var result = _deletarAlunoValidator.Validate(id);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            else
            {
                await _alunoRepository.DeleteAsync(id);
                return SuccesResult();
            }
        }
    }
}
