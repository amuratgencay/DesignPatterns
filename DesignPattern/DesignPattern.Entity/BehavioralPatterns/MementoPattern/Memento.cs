using System.Collections.Generic;

namespace DesignPattern.Entity.BehavioralPatterns.MementoPattern
{
    public class Memento<T>
    {
        private readonly List<T> _mementolList = new List<T>();
        private int _index = -1;
        private bool _isLastActionUndo;
        public T State { get; set; }

        public void SetValue(T state)
        {
            State = state;
            _mementolList.Add(State);
            _index++;
            _isLastActionUndo = false;
        }

        public T GetValue()
        {
            return State;
        }

        public T Undo()
        {
            var res = _mementolList[--_index];
            if (res != null) _isLastActionUndo = true;

            if (res != null) State = res;

            return State;
        }

        public T Redo()
        {
            if (_isLastActionUndo)
                State = _mementolList[++_index];
            return State;
        }
    }
}