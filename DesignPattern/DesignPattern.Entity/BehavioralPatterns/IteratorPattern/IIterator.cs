namespace DesignPattern.Entity.BehavioralPatterns.IteratorPattern
{
    public interface IIterator<out T>
    {
        bool HasNext();
        T Next();
    }
}