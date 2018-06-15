using System;
using DesignPattern.BLL.BehavioralPatterns.IteratorPattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.IteratorPattern
{
    public class IteratorPatternExample
    {
        public static void Run()
        {
            var repository = new NameRepository();
            var iterator = repository.GetIterator();

            Console.WriteLine("<Iterator Pattern Example>");
            Console.WriteLine();
            while (iterator.HasNext()) Console.WriteLine("\t" + iterator.Next());
            Console.WriteLine();
            Console.WriteLine("</Iterator Pattern Example>");
            Console.WriteLine();
        }
    }
}