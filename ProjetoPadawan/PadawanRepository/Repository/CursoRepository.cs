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
    public class CursoRepository : GenericRepository<Cursos>, ICursoRepository
    {
        public CursoRepository(AlunoContext dbContext, DbSet<Cursos> dbSet) : base(dbContext, dbSet)
        {
        }

        public bool VerificaSeCursoExiste(string nome)
        {
            return _dbSet.Where(q => q.Nome == nome).Any();
        }
    }
}
