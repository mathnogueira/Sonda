using System;

namespace Domain.Exceptions
{
    public class SondaException : Exception
    {
        public SondaException(string msg) : base(msg)
        {
        }

        public SondaException(string msg, Exception cause) : base(msg, cause)
        {

        }
    }
}
