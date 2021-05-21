using FluentValidation;
using ProjetoDeVendasComCQRS.Domain.Commands.Cliente;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;

namespace ProjetoDeVendasComCQRS.Domain.Validation.Cliente
{
    public abstract class ClienteCommandValidator<T> : AbstractValidator<T> where T : ClienteCommand
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteCommandValidator(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        protected void ValidarNome()
        {
            RuleFor(q => q.Nome)
                .NotEmpty().WithMessage("Nome de usuário é obrigatório!")
                .Length(2, 50).WithMessage("Nome de usuário deve conter entre 2 e 50 caracteres!");
        }

        protected void ValidarCpf()
        {
            RuleFor(q => q.Cpf)
                .NotEmpty().WithMessage("Campo Cpf é obrigatório!")
                .IsValidCPF().WithMessage("Campo Cpf esta incorreto!")
                .Length(11).WithMessage("Campo cpf deve conter 11 caracteres!");
        }
        protected void ValidarEmail()
        {
            RuleFor(q => q.Email)
                .NotEmpty().WithMessage("Campo E-mail é obrigatório!")
                .EmailAddress().WithMessage("Campo email está incorreto!")
                .Length(5, 50).WithMessage("Campo email deve conter entre 5 e 50 caracteres!");
        }
        protected void ValidarSeCpfExiste()
        {
            RuleFor(q => q.Cpf)
                .Must((cpf) =>
            {
                return !_clienteRepository.VerificaSeJaExisteCpf(cpf);
            }).WithMessage("Esse cliente já existe!")
            .WithSeverity(Severity.Error);
        }
        protected void ValidarSeIdExiste()
        {
            RuleFor(q => q.Id)
                .Must((id) =>
                {
                    return _clienteRepository.VerificaSeIdExiste(id);
                }).WithMessage("Cliente não encontrado!")
                .WithSeverity(Severity.Error);
        }
    }
}
