using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PadawanApplication.Interfaces
{
    public interface IAlunoService
    {
        Task<ResponseToUser> CreateAsync(Alunos aluno);
        Task<IEnumerable<Alunos>> GetAllAsync();
        Task<ResponseToUser> DeleteAsync(Guid id);
    }
}
