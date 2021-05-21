using System;

namespace ProjetoDeVendasComCQRS.Domain.Commands.Produto
{
    public class EditarProdutoCommand : ProdutoCommand
    {
        public EditarProdutoCommand(Guid id, string nome, double preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }
    }
}
