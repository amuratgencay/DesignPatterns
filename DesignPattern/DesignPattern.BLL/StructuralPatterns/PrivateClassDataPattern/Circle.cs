using System;
using DesignPattern.Entity.StructuralPatterns.PrivateClassDataPattern;

namespace DesignPattern.BLL.StructuralPatterns.PrivateClassDataPattern
{
    public class Circle : Shape
    {
        private readonly CircleData _circleData;

        public Circle(int x, int y, int r, ConsoleColor color)
        {
            _circleData = new CircleData(x, y, r, color);
        }

        public override void Draw()
        {
            var tmpForeground = Console.ForegroundColor;
            var tmpBackground = Console.BackgroundColor;
            Console.Write("\t");
            Console.ForegroundColor = _circleData.Color;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(_circleData);
            Console.ForegroundColor = tmpForeground;
            Console.BackgroundColor = tmpBackground;
            Console.Write("\t\t");
            Console.ForegroundColor = _circleData.Color;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Area: " + Area());
            Console.ForegroundColor = tmpForeground;
            Console.BackgroundColor = tmpBackground;
            Console.Write("\t\t");
            Console.ForegroundColor = _circleData.Color;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Circumference: " + Circumference());
            Console.ForegroundColor = tmpForeground;
            Console.BackgroundColor = tmpBackground;
        }

        public override double Area() => Math.PI*_circleData.Radius*_circleData.Radius;
        public override double Circumference() => 2*Math.PI*_circleData.Radius;
    }
}