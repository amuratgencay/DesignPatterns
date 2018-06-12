using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.StructuralPatterns.FlyweightPattern
{
    public class Circle : IDrawable
    {
        public ConsoleColor Color { get; set; }
        public Circle(ConsoleColor color)
        {
            Color = color;
        }
        public void Draw()
        {
            var tmpForeground = Console.ForegroundColor;
            var tmpBackground = Console.BackgroundColor;
            Console.Write("\t");
            Console.ForegroundColor = Color;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Circle");
            Console.ForegroundColor = tmpForeground;
            Console.BackgroundColor = tmpBackground;
        }
    }
}
