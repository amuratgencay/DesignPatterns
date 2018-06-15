using System;
using DesignPattern.BLL.BehavioralPatterns.MementoPattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.MementoPattern
{
    public static class MementoPatternExample
    {
        public static void Run()
        {
            var memento = new MementoPattern<string>();
            memento.SetValue("State #1");
            memento.SetValue("State #2");
            memento.SetValue("State #3");
            memento.SetValue("State #4");


            Console.WriteLine("<Memento Pattern Example>");
            Console.WriteLine();


            Console.WriteLine("\tState #1");
            Console.WriteLine("\tState #2");
            Console.WriteLine("\tState #3");
            Console.WriteLine("\tState #4");
            Console.WriteLine();


            Console.WriteLine("\tCurrent State: " + memento.GetValue());
            memento.Undo();
            Console.WriteLine("\tUndo -> State: " + memento.GetValue());
            memento.Undo();
            Console.WriteLine("\tUndo -> State: " + memento.GetValue());
            memento.Redo();
            Console.WriteLine("\tRedo -> State: " + memento.GetValue());
            memento.Redo();
            Console.WriteLine("\tRedo -> State: " + memento.GetValue());

            Console.WriteLine();
            Console.WriteLine("</Memento Pattern Example>");
            Console.WriteLine();
        }
    }
}