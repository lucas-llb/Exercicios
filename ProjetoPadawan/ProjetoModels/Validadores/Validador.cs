using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModels
{
    public class Validador
    {
        public bool IsValid { get; set; }
        public List<string> Erro { get; set; }

        public Validador()
        {
            Erro = new List<string>();
            IsValid = true;
        }
    }
}
