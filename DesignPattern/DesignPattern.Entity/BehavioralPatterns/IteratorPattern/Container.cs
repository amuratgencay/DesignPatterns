using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Entity.BehavioralPatterns.IteratorPattern
{
    public class Container<T> : IContainer<T>
    {
        private readonly List<T> _list;

        public Container()
        {
            _list = new List<T>();
        }

        public Container(IEnumerable<T> list)
        {
            _list = list.ToList();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public bool Remove(T item)
        {
            return _list.Remove(item);
        }

        public IIterator<T> GetIterator()
        {
            return new ContainerIterator(_list);
        }

        private class ContainerIterator : IIterator<T>
        {
            private readonly List<T> _list;
            private int _index;

            public ContainerIterator(List<T> list)
            {
                _list = list;
            }

            public bool HasNext()
            {
                return _index < _list.Count;
            }

            public T Next()
            {
                return _list[_index++];
            }
        }
    }
}