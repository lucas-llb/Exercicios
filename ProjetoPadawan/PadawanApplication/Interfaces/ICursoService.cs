using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PadawanApplication.Interfaces
{
    public interface ICursoService
    {
        Task<ResponseToUser> CreateAsync(Cursos curso);
        Task<IEnumerable<Cursos>> GetAllAsync();
        Task<ResponseToUser> DeleteAsync(Guid id);
    }
}
