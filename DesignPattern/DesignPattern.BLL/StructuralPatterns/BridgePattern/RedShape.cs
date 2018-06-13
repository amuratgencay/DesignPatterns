using System;
using DesignPattern.Entity.StructuralPatterns.BridgePattern;

namespace DesignPattern.BLL.StructuralPatterns.BridgePattern
{
    public class RedShape : IDrawable
    {
        public void Draw(Shape shape)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Red: " + shape);
            Console.ResetColor();
        }
    }
}