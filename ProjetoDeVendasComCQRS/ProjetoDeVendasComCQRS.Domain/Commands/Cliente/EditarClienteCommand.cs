using System;

namespace ProjetoDeVendasComCQRS.Domain.Commands.Cliente
{
    public class EditarClienteCommand : ClienteCommand
    {
        public EditarClienteCommand(Guid id, string nome, string cpf, string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }
    }
}
