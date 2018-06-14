namespace DesignPattern.Entity.BehavioralPatterns.IteratorPattern
{
    public interface IContainer<T>
    {
        void Add(T item);
        bool Remove(T item);
        IIterator<T> GetIterator();
    }
}