using FluentValidation;
using PadawanInfra.Interfaces;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDomain.Validadores
{
    public class CadastrarMateriaValidator : AbstractValidator<Materias>, ICadastrarMateriaValidator
    {
        private readonly IMateriasRepository _materiasRepository;

        public CadastrarMateriaValidator(IMateriasRepository materiasRepository)
        {
            _materiasRepository = materiasRepository;
            VerificaObrigatoriedade();
            VerificaSeMateriaJaExiste();
        }

        public void VerificaObrigatoriedade()
        {
            RuleFor(q => q.Nome).NotEmpty().WithMessage("O campo nome é obrigatório!").IsValidName().WithMessage("O campo nome deve conter apenas letras!;");
            RuleFor(q => q.Descricao).NotEmpty().WithMessage("O campo descrição é obrigatório!").IsValidName().WithMessage("O campo descrição deve conter apenas letras");
            RuleFor(q => q.Situacao).NotEmpty().WithMessage("O campo descrição é obrigatório!");
            RuleFor(q => q.DataCadastro).NotEmpty().WithMessage("O campo data de cadastro é obrigatório!").IsValidDate().WithMessage("A data de cadastro");
        }

        public void VerificaSeMateriaJaExiste()
        {
            RuleFor(q => q.Nome).Must((nome) =>
            {
                return !_materiasRepository.VerificaMateriaExiste(nome);
            }).WithMessage("Essa matéria já existe!").WithSeverity(Severity.Error);
        }
    }
}
