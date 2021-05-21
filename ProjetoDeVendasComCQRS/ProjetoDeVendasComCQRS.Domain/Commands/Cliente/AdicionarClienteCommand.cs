namespace ProjetoDeVendasComCQRS.Domain.Commands.Cliente
{
    public class AdicionarClienteCommand : ClienteCommand
    {
        public AdicionarClienteCommand(string nome, string cpf, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }
    }
}
