using ProjetoDeVendasComCQRS.Domain.Commands.Cliente;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;

namespace ProjetoDeVendasComCQRS.Domain.Validation.Cliente
{
    public class RemoverClienteCommandValidator : ClienteCommandValidator<RemoverClienteCommand>
    {
        public RemoverClienteCommandValidator(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            ValidarSeIdExiste();
        }
    }
}
