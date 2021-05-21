using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDeVendasComCQRS.Domain.Commands
{
    public class CommandBase
    {
        public Guid MessageId { get; set; }
    }
}
