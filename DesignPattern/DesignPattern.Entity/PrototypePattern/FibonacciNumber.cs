using System;

namespace DesignPattern.Entity.PrototypePattern
{
    public class FibonacciNumber : ICloneable
    {
        public int Index { get; set; }
        public int First { get; set; }
        public int Second { get; set; }

        public int Value => First + Second;

        public FibonacciNumber(int index, int first, int second)
        {
            Index = index;
            First = first;
            Second = second;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return  $"Fibonacci({Index}) = {Value}";
        }
    }
}
