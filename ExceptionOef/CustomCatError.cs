using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionOef
{
    class CustomCatError : System.ApplicationException
    {
        public CustomCatError()
        { }
        public CustomCatError(string message)
            : base(message) { }
    }
}