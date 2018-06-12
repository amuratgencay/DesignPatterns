using System;

namespace DesignPattern.Entity.StructuralPatterns.FacadePattern
{
    public class Square : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Square");
        }
    }
}