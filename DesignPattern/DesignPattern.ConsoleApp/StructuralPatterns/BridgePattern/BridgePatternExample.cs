using DesignPattern.BLL.StructuralPatterns.BridgePattern;
using DesignPattern.Entity.StructuralPatterns.BridgePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ConsoleApp.StructuralPatterns.BridgePattern
{
    public static class BridgePatternExample
    {
        public static void Run()
        {
            Shape redCircle = new Circle(100, 100, 10, new RedShape());
            Shape blueRectangle = new Rectangle(100, 100, 10, 5, new BlueShape());

            Console.WriteLine("<Bridge Pattern Example>");
            Console.WriteLine();
                Console.Write("\t");
                redCircle.Draw();
                Console.Write("\t");
                blueRectangle.Draw();
            Console.WriteLine();
            Console.WriteLine("</Bridge Pattern Example>");
            Console.WriteLine();
        }
    }
}
