using ProjetoDeVendasComCQRS.Domain.Entidades;

namespace ProjetoDeVendasComCQRS.Domain
{
    public class Produto : BaseEntity
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }
    }
}
