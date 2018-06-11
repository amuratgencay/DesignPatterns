using System;

namespace DesignPattern.Entity.StructuralPatterns.FacadePattern
{
    public class Circle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}