using System;
using DesignPattern.BLL.StructuralPatterns.FlyweightPattern;

namespace DesignPattern.ConsoleApp.StructuralPatterns.FlyweightPattern
{
    public static class FlyweightPatternExample
    {
        public static void Run()
        {
            Console.WriteLine("<Flyweight Pattern Example>");
            Console.WriteLine();
            for (var i = 0; i < 20; ++i)
            {
                var circle = ShapeFactory.GetShape(FlyweightShapes.GetRandomColor());
                circle.Draw();
            }
            Console.WriteLine();
            Console.WriteLine("</Flyweight Pattern Example>");
            Console.WriteLine();
        }
    }
}