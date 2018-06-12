using DesignPattern.BLL.StructuralPatterns.CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
