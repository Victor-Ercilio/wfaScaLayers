using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class InvalidOperationMatriculaTemNotas : Exception
    {
        public InvalidOperationMatriculaTemNotas() : base() { }
        public InvalidOperationMatriculaTemNotas(string message) : base(message) { }
        public InvalidOperationMatriculaTemNotas(string message, Exception inner) : base(message, inner) { }
    }
}
