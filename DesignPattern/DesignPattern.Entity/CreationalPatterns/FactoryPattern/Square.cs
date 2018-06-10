using System;

namespace DesignPattern.Entity.CreationalPatterns.FactoryPattern
{
    public class Square : IShape
    {
        public double Size { get; set; }

        public Square(double size)
        {
            Size = size;

        }
        public double Area()
        {
            return Size * Size;
        }

        public override string ToString()
        {
            return $"Square[{Size}] = ".PadRight(25) + Area();
        }
    }
}
