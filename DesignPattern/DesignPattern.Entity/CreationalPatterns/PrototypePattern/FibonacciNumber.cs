using System;

namespace DesignPattern.Entity.CreationalPatterns.PrototypePattern
{
    public class FibonacciNumber : ICloneable
    {
        public FibonacciNumber(int index, int first, int second)
        {
            Index = index;
            First = first;
            Second = second;
        }

        public int Index { get; set; }
        public int First { get; set; }
        public int Second { get; set; }
        public int Value => First + Second;

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Fibonacci({Index}) = {Value}";
        }
    }
}