using ProjetoDeVendasComCQRS.Domain.Models;
using System.Collections.Generic;

namespace ProjetoDeVendasComCQRS.Application
{
    public abstract class BaseServices
    {
        public ResponseToUser SuccessResult() => new ResponseToUser(true);
        public ResponseToUser ErrorResult(IEnumerable<string> errors) => new ResponseToUser(false, errors);
    }
}
