using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjetoModels.Validadores
{
    public class UsuarioValidador
    {
        public Validador validador = new Validador();


        public bool ValidaSenha(string password)
        {
            var rgx = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            if (rgx.IsMatch(password))
            {
                return true;
            }
            else return false;
        }
        public bool ValidaUsuario(string username)
        {
            var rgx = new Regex(@"^([a-z]|[A-Z]|[0-9]){5,}$");
            if (rgx.IsMatch(username))
            {
                return true;
            }
            else return false;
        }
        public int ValidaAcesso(string acesso)
        {
            if (acesso == "1 - Administrador")
            {
                return 1;
            }
            if (acesso == "2 - Professor")
            {
                return 2;
            }
            else return 3;
                      
        }
    }
}
