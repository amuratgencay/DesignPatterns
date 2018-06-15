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
            Console.Write("\t");
            Console.ForegroundColor = _circleData.Color;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(_circleData);
            Console.ResetColor();
            Console.Write("\t\t");
            Console.ForegroundColor = _circleData.Color;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Area: " + Area());
            Console.ResetColor();
            Console.Write("\t\t");
            Console.ForegroundColor = _circleData.Color;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Circumference: " + Circumference());
            Console.ResetColor();
        }

        public override double Area()
        {
            return Math.PI * _circleData.Radius * _circleData.Radius;
        }

        public override double Circumference()
        {
            return 2 * Math.PI * _circleData.Radius;
        }
    }
}