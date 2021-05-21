namespace ProjetoDeVendasComCQRS.Domain.Entidades
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        public Cliente()
        {
        }
    }
}
