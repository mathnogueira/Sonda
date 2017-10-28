using System;

namespace Domain.Exceptions
{
    class SondaMovementException : Exception
    {
        public SondaMovementException(string msg) : base(msg)
        {
        }
    }
}
