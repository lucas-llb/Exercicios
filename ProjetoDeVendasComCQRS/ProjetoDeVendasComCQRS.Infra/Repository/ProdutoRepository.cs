using ProjetoDeVendasComCQRS.Domain;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;
using ProjetoDeVendasComCQRS.Infra.Context;
using System;
using System.Linq;

namespace ProjetoDeVendasComCQRS.Infra.Repository
{
    public class ProdutoRepository : GenericRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MainContext dbContext) : base(dbContext)
        {
        }

        public bool VarificarSeProdutoExiste(string nome)
        {
            return _dbSet.Where(q => q.Nome == nome).Any();
        }
        public bool VerificarSeIdExiste(Guid id)
        {
            return _dbSet.Where(q => q.Id == id).Any();
        }
    }
}
