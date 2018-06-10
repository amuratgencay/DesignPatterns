using System;

namespace DesignPattern.BLL.CreationalPatterns.AbstractFactoryPattern
{
    public interface IFactory<out T, in TEnum> 
    {
        T Produce(TEnum type);
    }
}