using Microsoft.EntityFrameworkCore;
using PadawanInfra.Context;
using PadawanInfra.Interfaces;
using ProjetoModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadawanInfra.Repository
{
    public class UsuarioRepository : GenericRepository<Usuarios>, IUsuarioRepository
    {
        public UsuarioRepository(AlunoContext dbContext, DbSet<Usuarios> dbSet) : base(dbContext, dbSet)
        {
        }
    }
}
