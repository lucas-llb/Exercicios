using PadawanApplication.Interfaces;
using PadawanInfra.Interfaces;
using ProjetoDomain.Validadores;
using ProjetoDomain.Validadores.Interfaces;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadawanApplication.Services
{
    public class MateriaService : BaseServices, IMateriaService
    {
        private readonly IMateriasRepository _materiasRepository;
        private readonly ICadastrarMateriaValidator _cadastrarMateriaValidator;
        private readonly IDeletarMateriaValidator _deletarMateriaValidator;

        public MateriaService(IMateriasRepository materiasRepository, ICadastrarMateriaValidator cadastrarMateriaValidator, IDeletarMateriaValidator deletarMateriaValidator)
        {
            _materiasRepository = materiasRepository;
            _cadastrarMateriaValidator = cadastrarMateriaValidator;
            _deletarMateriaValidator = deletarMateriaValidator;
        }

        public async Task<ResponseToUser> CreateAsync(Materias materia)
        {
            var result = _cadastrarMateriaValidator.Validate(materia);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            else
            {
                await _materiasRepository.CreateAsync(materia);
                return SuccesResult();
            }
        }
        public async Task<IEnumerable<Materias>> GetAllAsync()
        {
            return await _materiasRepository.GetAllAsync();
        }
        public async Task<ResponseToUser> DeleteAsync(Guid id)
        {
            var result = _deletarMateriaValidator.Validate(id);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            else
            {
                await _materiasRepository.DeleteAsync(id);
                return SuccesResult();
            }
        }
    }
}
