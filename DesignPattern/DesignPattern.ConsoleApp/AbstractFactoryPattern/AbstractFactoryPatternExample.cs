using System;
using DesignPattern.BLL.AbstractFactoryPattern;
using DesignPattern.Entity.AbstractFactoryPattern;
using DesignPattern.Entity.AbstractFactoryPattern.Fill;
using DesignPattern.Entity.AbstractFactoryPattern.Shape;

namespace DesignPattern.ConsoleApp.AbstractFactoryPattern
{
    public static class AbstractFactoryPatternExample
    {
        public static void Run()
        {
            Console.WriteLine("<Abstract Factory Pattern Example>");
            Console.WriteLine();
            Console.WriteLine("\t" + FactoryProducer.CreateFactory(FactoryType.Shape).CreateShape(ShapeType.Circle));
            Console.WriteLine("\t" + FactoryProducer.CreateFactory(FactoryType.Fill).CreateFill(FillType.Red));
            Console.WriteLine();
            Console.WriteLine("</Abstract Factory Pattern Example>");
            Console.WriteLine();
        }
    }
}
