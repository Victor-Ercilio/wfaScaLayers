﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    [Serializable]
    public class InvalidNameException : ArgumentException
    {
        public InvalidNameException() : base() { }
        public InvalidNameException(string message) : base(message) { }
        public InvalidNameException(string message, Exception inner) : base(message, inner) { }
        
    }
}
