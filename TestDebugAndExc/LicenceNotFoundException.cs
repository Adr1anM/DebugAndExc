using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDebugAndExc
{
    public class LicenceNotFoundException : Exception
    {
        public LicenceNotFoundException() : base() { }
        public LicenceNotFoundException(string message) : base(message) { }
        public LicenceNotFoundException(string message, Exception innerException) : base(message, innerException) { } 
    }
}
