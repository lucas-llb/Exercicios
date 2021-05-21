using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PadawanApplication.Interfaces
{
    public interface IMateriaService
    {
        Task<ResponseToUser> CreateAsync(Materias materia);
        Task<IEnumerable<Materias>> GetAllAsync();
        Task<ResponseToUser> DeleteAsync(Guid id).
    }
}
