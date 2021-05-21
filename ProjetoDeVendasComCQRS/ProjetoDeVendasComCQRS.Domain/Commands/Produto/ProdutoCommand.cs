using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDeVendasComCQRS.Domain.Commands.Produto
{
    public class ProdutoCommand : CommandBase
    {
        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
        public double Preco { get; protected set; }
    }
}
