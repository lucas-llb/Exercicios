using System.Collections.Generic;

namespace ProjetoDeVendasComCQRS.Domain.Models
{
    public class ResponseToUser
    {
        public bool Success { get; set; }
        public IEnumerable<string> Messages { get; set; }

        public ResponseToUser(bool success, IEnumerable<string> messages = null)
        {
            Success = success;
            Messages = messages;
        }
    }
}
