using System;
using DesignPattern.BLL.StructuralPatterns.CompositePattern;

namespace DesignPattern.ConsoleApp.StructuralPatterns.CompositePattern
{
    public static class CompositePatternExample
    {
        public static void Run()
        {
            Console.WriteLine("<Composite Pattern Example>");
            Console.WriteLine();
            ProductGenerator.GenerateProducts().ListCategories();
            Console.WriteLine();
            Console.WriteLine("</Composite Pattern Example>");
            Console.WriteLine();
        }
    }
}