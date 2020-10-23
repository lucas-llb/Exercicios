using Microsoft.EntityFrameworkCore;
using PadawanInfra.Context;
using PadawanInfra.Interfaces;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadawanInfra.Repository
{
    public class NotasRepository : GenericRepository<Notas>, INotasRepository
    {
        public NotasRepository(AlunoContext dbContext, DbSet<Notas> dbSet) : base(dbContext, dbSet)
        {
        }
    }
}
