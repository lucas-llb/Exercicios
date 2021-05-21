using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadawanInfra.Interfaces
{
    public interface ICursoRepository : IGenericRepository<Cursos>
    {
        bool VerificaSeCursoExiste(string nome);
    }
}
