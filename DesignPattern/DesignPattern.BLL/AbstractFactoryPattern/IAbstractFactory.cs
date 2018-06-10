using System;

namespace DesignPattern.BLL.AbstractFactoryPattern
{
    public interface IAbstractFactory<out T, in TEnum>
    {
        IFactory<T, TEnum> GetFactory();
    }

   
  

}
