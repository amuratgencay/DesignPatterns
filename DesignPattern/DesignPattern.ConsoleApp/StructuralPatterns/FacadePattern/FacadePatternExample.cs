using System;
using DesignPattern.BLL.StructuralPatterns.FacadePattern;

namespace DesignPattern.ConsoleApp.StructuralPatterns.FacadePattern
{
    public static class FacadePatternExample
    {
        public static void Run()
        {
            var shapeMaker = new ShapeMaker();
            Console.WriteLine("<Facade Pattern Example>");
            Console.WriteLine();
            Console.Write("\t");
            shapeMaker.DrawCircle();
            Console.Write("\t");
            shapeMaker.DrawRectangle();
            Console.Write("\t");
            shapeMaker.DrawSquare();
            Console.WriteLine();
            Console.WriteLine("</Facade Pattern Example>");
            Console.WriteLine();
        }
    }
}