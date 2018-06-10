using System;

namespace DesignPattern.Entity.CreationalPatterns.AbstractFactoryPattern.Shape
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;

        }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Circle[{Radius}] = ".PadRight(25) + Area();
        }
    }
}
