using System;
using DesignPattern.Entity.StructuralPatterns.PrivateClassDataPattern;

namespace DesignPattern.BLL.StructuralPatterns.PrivateClassDataPattern
{
    public class Rectangle : Shape
    {
        private readonly RectangleData _rectangleData;

        public Rectangle(int x, int y, int w, int h, ConsoleColor color)
        {
            _rectangleData = new RectangleData(x, y, w, h, color);
        }

        public override void Draw()
        {
            var tmpForeground = Console.ForegroundColor;
            var tmpBackground = Console.BackgroundColor;
            Console.Write("\t");
            Console.ForegroundColor = _rectangleData.Color;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(_rectangleData);
            Console.ForegroundColor = tmpForeground;
            Console.BackgroundColor = tmpBackground;
            Console.Write("\t\t");
            Console.ForegroundColor = _rectangleData.Color;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Area: " + Area());
            Console.ForegroundColor = tmpForeground;
            Console.BackgroundColor = tmpBackground;
            Console.Write("\t\t");
            Console.ForegroundColor = _rectangleData.Color;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Circumference: " + Circumference());
            Console.ForegroundColor = tmpForeground;
            Console.BackgroundColor = tmpBackground;
        }

        public override double Area() => _rectangleData.Width*_rectangleData.Height;
        public override double Circumference() => 2*(_rectangleData.Height + _rectangleData.Width);
    }
}