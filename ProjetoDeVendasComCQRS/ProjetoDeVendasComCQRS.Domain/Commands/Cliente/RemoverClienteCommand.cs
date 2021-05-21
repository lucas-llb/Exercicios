using System;

namespace ProjetoDeVendasComCQRS.Domain.Commands.Cliente
{
    public class RemoverClienteCommand : ClienteCommand
    {
        public RemoverClienteCommand(Guid id)
        {
            Id = id;
        }
    }
}
