using System;

namespace Pilha
{
    public class PilhaCheiaException : Exception
    {
        public PilhaCheiaException()
        {
        }

        public PilhaCheiaException(string message)
            : base(message)
        {
        }

        public PilhaCheiaException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}