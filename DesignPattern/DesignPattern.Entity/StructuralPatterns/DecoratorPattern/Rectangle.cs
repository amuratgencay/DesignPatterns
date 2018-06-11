using System;

namespace DesignPattern.Entity.StructuralPatterns.DecoratorPattern
{
    public class Rectangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}