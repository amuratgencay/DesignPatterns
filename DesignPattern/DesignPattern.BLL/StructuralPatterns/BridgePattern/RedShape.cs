using DesignPattern.Entity.StructuralPatterns.BridgePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BLL.StructuralPatterns.BridgePattern
{
    public class RedShape : IDrawable
    {
        public void Draw(Shape shape)
        {
            var tmp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(shape);
            Console.ForegroundColor = tmp;
        }
    }
}
