using ProjetoDeVendasComCQRS.Domain.Entidades;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;
using ProjetoDeVendasComCQRS.Infra.Context;
using System;
using System.Linq;

namespace ProjetoDeVendasComCQRS.Infra.Repository
{
    public class PedidoRepository : GenericRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(MainContext dbContext) : base(dbContext)
        {
        }

        public bool VerificarSePedidoExiste(Guid id)
        {
            return _dbSet.Where(q => q.Id == id).Any();
        }
    }
}
