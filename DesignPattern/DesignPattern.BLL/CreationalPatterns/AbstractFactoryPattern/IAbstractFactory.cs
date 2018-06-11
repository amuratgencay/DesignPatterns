namespace DesignPattern.BLL.CreationalPatterns.AbstractFactoryPattern
{
    public interface IAbstractFactory<out T, in TEnum>
    {
        IFactory<T, TEnum> GetFactory();
    }
}