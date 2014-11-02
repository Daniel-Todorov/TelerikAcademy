using System;

namespace _03.RangeException
{
    class InvalidRangeException<T> : ApplicationException
    {
        public T Start { get; set; }
        public T End { get; set; }

        public override string ToString()
        {
            string result = null;

            result = string.Format("The value is not in the range [{0} ... {1}]", this.Start, this.End);

            return result;
        }

        public InvalidRangeException(T start, T end)
            : base()
        {
            this.Start = start;
            this.End = end;
        }
    }
}
