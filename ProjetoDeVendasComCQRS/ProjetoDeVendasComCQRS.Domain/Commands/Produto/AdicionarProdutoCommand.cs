namespace ProjetoDeVendasComCQRS.Domain.Commands.Produto
{
    public class AdicionarProdutoCommand : ProdutoCommand
    {
        public AdicionarProdutoCommand(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
