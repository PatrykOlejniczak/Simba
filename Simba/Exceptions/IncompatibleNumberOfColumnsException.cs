using System;

namespace Simba.Exceptions
{
    public class IncompatibleNumberOfColumnsException : ArgumentException
    {
        public IncompatibleNumberOfColumnsException(string paramName)
            : base("Wrong columns number in row.", paramName)
        { }
    }
}