using System;

namespace task_1
{
    public class Money
    {
        public int WholePart { get; private set; }
        public int FractionalPart { get; private set; }

        public Money(int wholePart, int fractionalPart)
        {
            if (fractionalPart < 0 || fractionalPart > 99)
                throw new ArgumentException("Fractional part must be between 0 and 99.");

            WholePart = wholePart;
            FractionalPart = fractionalPart;
        }

        public void SetValue(int wholePart, int fractionalPart)
        {
            if (fractionalPart < 0 || fractionalPart > 99)
                throw new ArgumentException("Fractional part must be between 0 and 99.");

            WholePart = wholePart;
            FractionalPart = fractionalPart;
        }

        public override string ToString()
        {
            return $"{WholePart}.{FractionalPart:D2}";
        }
    }
}
