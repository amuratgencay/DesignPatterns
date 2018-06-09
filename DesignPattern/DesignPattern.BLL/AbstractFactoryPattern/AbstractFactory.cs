using System;
using DesignPattern.Entity.AbstractFactoryPattern.Fill;
using DesignPattern.Entity.AbstractFactoryPattern.Shape;

namespace DesignPattern.BLL.AbstractFactoryPattern
{
    public interface IAbstractFactory
    {
        IShape CreateShape(ShapeType param);
        IFill CreateFill(FillType param);
    }
}
