using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    [Serializable]
    public class InvalidSiglaException : ArgumentException
    {
        public InvalidSiglaException() : base() { }
        public InvalidSiglaException(string message) : base(message) { }
        public InvalidSiglaException(string message, Exception inner) : base(message, inner) { }
    }
}
