using DesignPattern.BLL.StructuralPatterns.FlyweightPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ConsoleApp.StructuralPatterns.FlyweightPattern
{
    public static class FlyweightPatternExample
    {
        public static void Run()
        {
            Console.WriteLine("<Flyweight Pattern Example>");
            Console.WriteLine();
            for (int i = 0; i < 20; ++i)
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
