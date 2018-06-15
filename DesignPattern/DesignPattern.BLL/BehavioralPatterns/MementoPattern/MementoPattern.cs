using DesignPattern.Entity.BehavioralPatterns.MementoPattern;

namespace DesignPattern.BLL.BehavioralPatterns.MementoPattern
{
    public class MementoPattern<T>
    {
        private readonly Memento<T> _memento = new Memento<T>();


        public void SetValue(T value)
        {
            _memento.SetValue(value);
        }

        public T GetValue()
        {
            return _memento.GetValue();
        }

        public T Undo()
        {
            return _memento.Undo();
        }

        public T Redo()
        {
            return _memento.Redo();
        }
    }
}