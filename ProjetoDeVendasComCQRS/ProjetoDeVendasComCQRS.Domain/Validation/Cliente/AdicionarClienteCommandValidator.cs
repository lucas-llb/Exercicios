using ProjetoDeVendasComCQRS.Domain.Commands.Cliente;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;

namespace ProjetoDeVendasComCQRS.Domain.Validation.Cliente
{
    public class AdicionarClienteCommandValidator : ClienteCommandValidator<AdicionarClienteCommand>
    {
        public AdicionarClienteCommandValidator(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            ValidarNome();
            ValidarCpf();
            ValidarEmail();
            ValidarSeCpfExiste();
        }
    }
}
