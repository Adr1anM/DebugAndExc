using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDebugAndExc
{
    public class InvalidDriverAgeException : Exception
    {
        public InvalidDriverAgeException() : base() { }
        public InvalidDriverAgeException(string message) : base(message) { }
        public InvalidDriverAgeException(string message, Exception innerException) : base(message, innerException) { }
    }
}
