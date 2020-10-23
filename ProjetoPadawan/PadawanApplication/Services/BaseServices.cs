using System;
using System.Collections.Generic;
using System.Text;

namespace PadawanApplication.Services
{
    public class BaseServices
    {
        public ResponseToUser SuccesResult() => new ResponseToUser(true);
        public ResponseToUser ErrorResult(IEnumerable<string> errors) => new ResponseToUser(false, errors);
    }
}
