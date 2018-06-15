using System;
using System.Collections.Generic;

namespace DesignPattern.Entity.BehavioralPatterns.ObserverPattern
{
    public class View : ConsoleWriter
    {
        private readonly List<Element> _observers = new List<Element>();
        private int _count;
        private int _state;

        public View(int left, int top, int cLeft, int cTop) : base(left, top, cLeft, cTop)
        {
            _count = 0;
        }

        public int State
        {
            get => _state;
            set
            {
                Console.WriteLine("\tState change: " + _state);
                _state = value;
                Write(_state.ToString());
                NotifyAllObservers();
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + ++_count);
            }
        }

        public void Attach(Element element)
        {
            _observers.Add(element);
        }

        public void NotifyAllObservers()
        {
            foreach (var observer in _observers)
            {
                observer.ConsoleLeft = ConsoleLeft;
                observer.ConsoleTop = ConsoleTop;
                observer.Render();
            }
        }
    }
}