using System;
using DesignPattern.BLL.BehavioralPatterns.StrategyPattern;
using DesignPattern.Entity.BehavioralPatterns.StrategyPattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.StrategyPattern
{
    public static class StrategyPatternExample
    {
        public static void Run()
        {
            var count = 0;

            Console.WriteLine("<State Pattern Example>");
            Console.WriteLine();

            var s = new PrimeStrategy(new IterativeStrategy());
            var res = s.Execute(1, 1000000, ref count);
            Console.WriteLine("Iterative Strategy");
            Console.WriteLine($"\t 1-1000000 prime count:{count} elapsed time: {res.Ticks}");

            s = new PrimeStrategy(new ControlledStrategy());
            res = s.Execute(1, 1000000, ref count);
            Console.WriteLine("Controlled Strategy");
            Console.WriteLine($"\t 1-1000000 prime count:{count} elapsed time: {res.Ticks}");

            s = new PrimeStrategy(new ComplexStrategy());
            res = s.Execute(1, 1000000, ref count);
            Console.WriteLine("Complex Strategy");
            Console.WriteLine($"\t 1-1000000 prime count:{count} elapsed time: {res.Ticks}");

            Console.WriteLine();
            Console.WriteLine("</State Pattern Example>");
            Console.WriteLine();
        }
    }
}