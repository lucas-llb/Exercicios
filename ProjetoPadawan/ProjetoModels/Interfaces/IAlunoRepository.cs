using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PadawanInfra.Interfaces
{
    public interface IAlunoRepository : IGenericRepository<Alunos>
    {
        bool VerificaCpfExiste(string cpf);
    }
}
