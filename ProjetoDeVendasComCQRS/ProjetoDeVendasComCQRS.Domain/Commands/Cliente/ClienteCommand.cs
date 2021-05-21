using System;

namespace ProjetoDeVendasComCQRS.Domain.Commands.Cliente
{
    public class ClienteCommand : CommandBase
    {
        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Cpf { get; protected set; }
        public string Email { get; protected set; }
    }
}
