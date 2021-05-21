using Microsoft.EntityFrameworkCore;
using PadawanInfra.Context;
using PadawanInfra.Interfaces;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PadawanInfra.Repository
{
    public class AlunoRepository : GenericRepository<Alunos>, IAlunoRepository
    {
        public AlunoRepository(AlunoContext dbContext, DbSet<Alunos> dbSet) : base(dbContext, dbSet)
        {
        }
        public bool VerificaCpfExiste(string cpf)
        {
            return _dbSet.Where(q => q.Cpf == cpf).Any();
        }
    }
}
