using System;

namespace Domain.Exceptions
{
    public class SondaMovementException : Exception
    {
        public SondaMovementException(string msg) : base(msg)
        {
        }

        public SondaMovementException(string msg, Exception cause) : base(msg, cause)
        {

        }
    }
}
