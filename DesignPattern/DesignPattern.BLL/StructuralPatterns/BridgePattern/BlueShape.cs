using System;
using DesignPattern.Entity.StructuralPatterns.BridgePattern;

namespace DesignPattern.BLL.StructuralPatterns.BridgePattern
{
    public class BlueShape : IDrawable
    {
        public void Draw(Shape shape)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Blue: " + shape);
            Console.ResetColor();
        }
    }
}