using ProjetoDeVendasComCQRS.Domain.Commands.Cliente;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;

namespace ProjetoDeVendasComCQRS.Domain.Validation.Cliente
{
    public class EditarClienteCommandValidator : ClienteCommandValidator<EditarClienteCommand>
    {
        public EditarClienteCommandValidator(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            ValidarSeIdExiste();
            ValidarNome();
            ValidarCpf();
            ValidarSeCpfExiste();
            ValidarEmail();
        }
    }
}
