using System;
using DesignPattern.Entity.CreationalPatterns.AbstractFactoryPattern.Fill;

namespace DesignPattern.BLL.CreationalPatterns.AbstractFactoryPattern
{
    public class FillFactory : IFactory<IFill, FillType>
    {
        public IFill Produce(FillType type)
        {
            switch (type)
            {
                case FillType.Red:
                    return new Red();
                case FillType.Green:
                    return new Green();
                case FillType.Blue:
                    return new Blue();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }

}
