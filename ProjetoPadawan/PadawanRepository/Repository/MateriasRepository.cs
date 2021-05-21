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
    public class MateriasRepository : GenericRepository<Materias>, IMateriasRepository
    {
        public MateriasRepository(AlunoContext dbContext, DbSet<Materias> dbSet) : base(dbContext, dbSet)
        {
        }
        public bool VerificaMateriaExiste(string nome)
        {
            return _dbSet.Where(q => q.Nome == nome).Any();
        }
    }
}
