using System;
using DesignPattern.Entity.AbstractFactoryPattern;

namespace DesignPattern.BLL.AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static IAbstractFactory CreateFactory(FactoryType param)
        {
            switch (param)
            {
                case FactoryType.Shape:
                    return new ShapeFactory();
                case FactoryType.Fill:
                    return new FillFactory();
                default:
                    throw new ArgumentOutOfRangeException(nameof(param), param, null);
            }

        }
    }
}
