using System;

namespace DesignPattern.BLL.AbstractFactoryPattern
{
    public interface IFactory<out T, in TEnum> 
    {
        T Produce(TEnum type);
    }
}