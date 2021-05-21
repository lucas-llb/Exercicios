using ProjetoDeVendasComCQRS.Application.Interfaces.Mappers;
using ProjetoDeVendasComCQRS.Domain.Commands.Cliente;
using ProjetoDeVendasComCQRS.Domain.Entidades;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Application.Mappers
{
    public class ClienteMapper : IClienteMapper
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteMapper(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente ConverterAdicionar(AdicionarClienteCommand command)
        {
            return new Cliente()
            {
                Nome = command.Nome,
                Cpf = command.Cpf,
                Email = command.Email
            };
        }

        public async Task<Cliente> ConverterEditar(EditarClienteCommand command)
        {
            var entidade = await _clienteRepository.GetByIdAsync(command.Id);
            entidade.Nome = command.Nome;
            entidade.Cpf = command.Cpf;
            entidade.Email = command.Email;
            return entidade;
        }
    }
}
