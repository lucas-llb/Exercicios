using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModels.Models
{
    public class CursosMaterias
    {
        public Guid CursoId { get; set; }
        public Guid MateriaId { get; set; }
        public virtual Cursos Curso { get; set; }
        public virtual Materias Materia { get; set; }

        //public CursosMaterias()
        //{
        //    Cursos = new HashSet<Cursos>();
        //    Materia = new HashSet<Materias>();
        //}
    }
}
