using System;

namespace DesignPattern.Entity.BehavioralPatterns.ObserverPattern
{
    public class ConsoleWriter
    {
        public ConsoleWriter(int left, int top, int cLeft, int cTop)
        {
            Left = left;
            Top = top;
            ConsoleLeft = cLeft;
            ConsoleTop = cTop;
        }

        public int Left { get; set; }
        public int Top { get; set; }
        public int ConsoleLeft { get; set; }
        public int ConsoleTop { get; set; }

        public void Write(string message)
        {
            Console.SetCursorPosition(Left, Top);
            Console.Write(message);
            Console.SetCursorPosition(ConsoleLeft, ConsoleTop);
        }
    }
}