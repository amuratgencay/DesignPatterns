using System;
using DesignPattern.Entity.AbstractFactoryPattern.Fill;
using DesignPattern.Entity.AbstractFactoryPattern.Shape;

namespace DesignPattern.BLL.AbstractFactoryPattern
{
    public class FillFactory : IAbstractFactory
    {
        IShape IAbstractFactory.CreateShape(ShapeType param)
        {
            throw new NotImplementedException();
        }

        public IFill CreateFill(FillType param)
        {
            switch (param)
            {
                case FillType.Red:
                    return new Red();
                case FillType.Green:
                    return new Green();
                case FillType.Blue:
                    return new Blue();
                default:
                    throw new ArgumentOutOfRangeException(nameof(param), param, null);
            }
        }
    }
}
