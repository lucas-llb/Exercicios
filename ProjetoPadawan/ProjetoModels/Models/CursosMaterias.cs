using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModels.Models
{
    public class CursosMaterias
    {
        public int CursoID { get; set; }
        public int MateriaID { get; set; }
        public virtual Cursos Cursos { get; set; }
        public virtual Materias Materia { get; set; }

        //public CursosMaterias()
        //{
        //    Cursos = new HashSet<Cursos>();
        //    Materia = new HashSet<Materias>();
        //}
    }
}
