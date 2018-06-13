using System;

namespace DesignPattern.Entity.StructuralPatterns.FlyweightPattern
{
    public class Circle : IDrawable
    {
        public Circle(ConsoleColor color)
        {
            Color = color;
        }

        public ConsoleColor Color { get; set; }

        public void Draw()
        {
            Console.Write("\t");
            Console.ForegroundColor = Color;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Circle");
            Console.ResetColor();        
        }
    }
}