using System;
using DesignPattern.BLL.CreationalPatterns.FactoryPattern;
using DesignPattern.Entity.CreationalPatterns.FactoryPattern;

namespace DesignPattern.ConsoleApp.CreationalPatterns.FactoryPattern
{
    public static class FactoryPatternExample
    {
        public static void Run()
        {
            Console.WriteLine("<Factory Pattern Example>");
            Console.WriteLine();
                Console.WriteLine("\t" + ShapeFactory.CreateShape(ShapeType.Sqaure));
                Console.WriteLine("\t" + ShapeFactory.CreateShape(ShapeType.Rectangle));
                Console.WriteLine("\t" + ShapeFactory.CreateShape(ShapeType.Circle));
            Console.WriteLine();
            Console.WriteLine("</Factory Pattern Example>");
            Console.WriteLine();
        }
    }
}
