using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.BLL;
using DesignPattern.Entity.FactoryPattern;

namespace DesignPattern.ConsoleApp
{
    class Program
    {
        static void FactoryPatternExample()
        {
            Console.WriteLine(FactoryPattern.CreateShape(ShapeType.Sqaure));
            Console.WriteLine(FactoryPattern.CreateShape(ShapeType.Rectangle));
            Console.WriteLine(FactoryPattern.CreateShape(ShapeType.Circle));
        }
        static void Main(string[] args)
        {
            FactoryPatternExample();
        }
    }
}
