using System;
using DesignPattern.Entity.CreationalPatterns.AbstractFactoryPattern.Fill;
using DesignPattern.Entity.CreationalPatterns.AbstractFactoryPattern.Shape;

namespace DesignPattern.BLL.CreationalPatterns.AbstractFactoryPattern
{
    public class FactoryProducer<T, TEnum> : IAbstractFactory<T, TEnum>
    {
        public IFactory<T, TEnum> GetFactory()
        {
            if (typeof(TEnum) == typeof(ShapeType))
                return (IFactory<T, TEnum>) new ShapeFactory();
            if (typeof(TEnum) == typeof(FillType))
                return (IFactory<T, TEnum>) new FillFactory();
            throw new ArgumentOutOfRangeException(nameof(TEnum), typeof(TEnum), null);
        }
    }
}