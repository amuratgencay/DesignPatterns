using System;
using DesignPattern.Entity.StructuralPatterns.PrivateClassDataPattern;

namespace DesignPattern.BLL.StructuralPatterns.PrivateClassDataPattern
{
    public static class ShapeMaker
    {
        public static Shape GetShape(ShapeType type)
        {
            var rnd = new Random((int) DateTime.Now.Ticks);
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle(rnd.Next(100), rnd.Next(100), rnd.Next(100),
                        (ConsoleColor) rnd.Next((int) ConsoleColor.Black, (int) ConsoleColor.White));
                case ShapeType.Rectangle:
                    return new Rectangle(rnd.Next(100), rnd.Next(100), rnd.Next(100), rnd.Next(100),
                        (ConsoleColor) rnd.Next((int) ConsoleColor.Black, (int) ConsoleColor.White));
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}