using System;

namespace DesignPattern.Entity.StructuralPatterns.DecoratorPattern
{
    public class Circle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}