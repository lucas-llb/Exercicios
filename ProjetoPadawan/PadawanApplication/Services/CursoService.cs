using PadawanApplication.Interfaces;
using PadawanInfra.Interfaces;
using ProjetoDomain.Validadores.Interfaces;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawanApplication.Services
{
    public class CursoService : BaseServices, ICursoService
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly ICadastrarCursoValidator _cadastrarCursoValidator;
        private readonly IDeletarCursoValidator _deletarCursoValidator;

        public CursoService(ICursoRepository cursoRepository, ICadastrarCursoValidator cadastrarCursoValidator,
            IDeletarCursoValidator deletarCursoValidator)
        {
            _cursoRepository = cursoRepository;
            _cadastrarCursoValidator = cadastrarCursoValidator;
            _deletarCursoValidator = deletarCursoValidator;
        }

        public async Task<ResponseToUser> CreateAsync(Cursos curso)
        {
            var result = _cadastrarCursoValidator.Validate(curso);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            else
            {
                await _cursoRepository.CreateAsync(curso);
                return SuccesResult();
            }
        }
        public async Task<IEnumerable<Cursos>> GetAllAsync()
        {
            return await _cursoRepository.GetAllAsync();
        }
        public async Task<ResponseToUser> DeleteAsync(Guid id)
        {
            var result = _deletarCursoValidator.Validate(id);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            else
            {
                await _cursoRepository.DeleteAsync(id);
                return SuccesResult();
            }
        }
    }
}
