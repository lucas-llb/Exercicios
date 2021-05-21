using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDeVendasComCQRS.Domain.Commands.Produto
{
    public class RemoverProdutoCommand : ProdutoCommand
    {
        public RemoverProdutoCommand(Guid id)
        {
            Id = id;
        }
    }
}
