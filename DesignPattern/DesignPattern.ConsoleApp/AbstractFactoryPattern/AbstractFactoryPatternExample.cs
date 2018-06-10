using System;
using DesignPattern.BLL.AbstractFactoryPattern;
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
            Console.WriteLine("\t" + new FactoryProducer<IShape, ShapeType>().GetFactory().Produce(ShapeType.Circle));
            Console.WriteLine("\t" + new FactoryProducer<IFill, FillType>().GetFactory().Produce(FillType.Red));
            Console.WriteLine();
            Console.WriteLine("</Abstract Factory Pattern Example>");
            Console.WriteLine();
        }
    }
}
