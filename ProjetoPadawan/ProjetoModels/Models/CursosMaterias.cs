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
        public Cursos Cursos { get; set; }
        public Materias Materia { get; set; }

    }
}
