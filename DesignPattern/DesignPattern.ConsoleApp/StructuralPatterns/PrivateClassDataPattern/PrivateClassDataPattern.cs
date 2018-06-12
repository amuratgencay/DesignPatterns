using System;
using DesignPattern.BLL.StructuralPatterns.PrivateClassDataPattern;
using DesignPattern.Entity.StructuralPatterns.PrivateClassDataPattern;

namespace DesignPattern.ConsoleApp.StructuralPatterns.PrivateClassDataPattern
{
    public static class PrivateClassDataPattern
    {
        public static void Run()
        {
            Console.WriteLine("<Private Class Data Pattern Example>");
            Console.WriteLine();
            ShapeMaker.GetShape(ShapeType.Circle).Draw();
            ShapeMaker.GetShape(ShapeType.Rectangle).Draw();
            Console.WriteLine();
            Console.WriteLine("</Private Class Data Pattern Example>");
            Console.WriteLine();
        }
    }
}