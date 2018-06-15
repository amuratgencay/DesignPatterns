using System;

namespace DesignPattern.Entity.CreationalPatterns.FactoryPattern
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

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