using System;
using DesignPattern.BLL.StructuralPatterns.DecoratorPattern;
using DesignPattern.Entity.StructuralPatterns.DecoratorPattern;

namespace DesignPattern.ConsoleApp.StructuralPatterns.DecoratorPattern
{
    public static class DecoratorPatternExample
    {
        public static void Run()
        {
            IDrawable redCircle = new RedShapeDecorator(new Circle());
            IDrawable blueRectangle = new BlueShapeDecorator(new Rectangle());

            Console.WriteLine("<Decorator Pattern Example>");
            Console.WriteLine();
            Console.Write("\t");
            redCircle.Draw();
            Console.Write("\t");
            blueRectangle.Draw();
            Console.WriteLine();
            Console.WriteLine("</Decorator Pattern Example>");
            Console.WriteLine();
        }
    }
}