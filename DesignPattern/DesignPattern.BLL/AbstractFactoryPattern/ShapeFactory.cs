using System;
using DesignPattern.Entity.AbstractFactoryPattern.Shape;

namespace DesignPattern.BLL.AbstractFactoryPattern
{
    public class ShapeFactory : IFactory<IShape, ShapeType>
    {
        public IShape Produce(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Rectangle:
                    return new Rectangle(10, 15);
                case ShapeType.Sqaure:
                    return new Square(10);
                case ShapeType.Circle:
                    return new Circle(10);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }       
    }

}
