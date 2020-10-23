using ProjetoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPadawan.Models
{
    public class Notas : BaseEntity
    {
        public int Nota { get; set; }
        public int AlunoId { get; set; }
        public int MateriaId { get; set; }

        public virtual Materias Materia { get; set; }
        public virtual Alunos Aluno { get; set; }
    }
}
