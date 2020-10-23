using System;
using System.Collections.Generic;
using System.Text;

namespace PadawanApplication
{
    public class ResponseToUser
    {
        public bool Success { get; set; }
        public IEnumerable<string> Messages { get; set; }
        public ResponseToUser(bool success, IEnumerable<string> messages=null)
        {
            Success = success;
            Messages = messages;
        }
    }
}
