using System;

namespace Pilha
{
    public class PilhaVaziaExceptions : Exception
    {
        public PilhaVaziaExceptions()
        {
        }

        public PilhaVaziaExceptions(string message)
            : base(message)
        {
        }

        public PilhaVaziaExceptions(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
