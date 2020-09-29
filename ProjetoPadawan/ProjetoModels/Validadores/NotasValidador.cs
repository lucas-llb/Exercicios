using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjetoModels.Validadores
{
    public class NotasValidador
    {
        public Validador validador = new Validador();
        public Validador validadorNotas(Notas notas)
        {
            if (Convert.ToString(notas.Nota) == null)
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo nota é obrigatório");
            }
            if (validaNota(Convert.ToString(notas.Nota)))
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo nota deve estar um intervalo entre 0 e 100.");
            }
            return validador;
        }

        public bool validaNota(string nota)
        {
            var rgx = new Regex(@"^([1-9]?\d|100)$");
            if (rgx.IsMatch(nota))
            {
                return true;
            }
            else return false;
        }
    }
}
