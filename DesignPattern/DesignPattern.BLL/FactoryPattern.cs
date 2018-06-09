using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Entity.FactoryPattern;

namespace DesignPattern.BLL
{
    public class FactoryPattern
    {
        public static Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    return new Rectangle(10,10);
                case ShapeType.Sqaure:
                    return new Square(10);
                case ShapeType.Circle:
                    return  new Circle(10);
                default:
                    throw new ArgumentOutOfRangeException(nameof(shapeType), shapeType, null);
            }            
        }
    }
}
