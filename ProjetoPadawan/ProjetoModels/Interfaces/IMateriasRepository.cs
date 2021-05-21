using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadawanInfra.Interfaces
{
    public interface IMateriasRepository : IGenericRepository<Materias>
    {
        bool VerificaMateriaExiste(string nome);
    }
}
