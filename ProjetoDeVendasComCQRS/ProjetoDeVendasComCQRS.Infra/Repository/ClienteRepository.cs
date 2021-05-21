using ProjetoDeVendasComCQRS.Domain.Entidades;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;
using ProjetoDeVendasComCQRS.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoDeVendasComCQRS.Infra.Repository
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(MainContext dbContext) : base(dbContext) {}

        public bool VerificaSeJaExisteCpf(string cpf)
        {
            return _dbSet.Where(q => q.Cpf == cpf).Any();
        }
        public bool VerificaSeIdExiste(Guid id)
        {
            return _dbSet.Where(q => q.Id == id).Any();
        }
    }
}
