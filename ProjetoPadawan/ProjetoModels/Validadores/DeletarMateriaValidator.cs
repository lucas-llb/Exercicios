using FluentValidation;
using PadawanInfra.Interfaces;
using ProjetoDomain.Validadores.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDomain.Validadores
{
    public class DeletarMateriaValidator : AbstractValidator<Guid>, IDeletarMateriaValidator
    {
        private readonly IMateriasRepository _materiasRepository;

        public DeletarMateriaValidator(IMateriasRepository materiasRepository)
        {
            _materiasRepository = materiasRepository;
        }

        public void VerificaMateriaExiste()
        {
            RuleFor(q => q).MustAsync(async (id, _) =>
            {
                return _materiasRepository.GetByIdAsync(id) != null;
            }).WithMessage("Essa matéria não existe!");
        }
    }
}
