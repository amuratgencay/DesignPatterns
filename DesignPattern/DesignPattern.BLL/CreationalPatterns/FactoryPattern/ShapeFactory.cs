using System;
using DesignPattern.Entity.CreationalPatterns.FactoryPattern;

namespace DesignPattern.BLL.CreationalPatterns.FactoryPattern
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(ShapeType shapeType)
        {
            var rnd = new Random((int)DateTime.Now.Ticks);
            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    return new Rectangle(rnd.Next(100), rnd.Next(100));
                case ShapeType.Sqaure:
                    return new Square(rnd.Next(100));
                case ShapeType.Circle:
                    return new Circle(rnd.Next(100));
                default:
                    throw new ArgumentOutOfRangeException(nameof(shapeType), shapeType, null);
            }
        }
    }
}