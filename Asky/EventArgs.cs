using System;

namespace Asky
{
    public class EventArgs<T, TU> : EventArgs
    {
        public EventArgs(T num, TU cont)
        {
            Number = num;
            Content = cont;
        }

        public T Number { get; private set; }
        public TU Content { get; private set; }
    }
}