using System;
using DesignPattern.BLL.BehavioralPatterns.CommandPattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.CommandPattern
{
    public static class CommandPatternExample
    {
        public static void Run()
        {
            var calculator = new Calculator();
            Console.WriteLine("<Command Pattern Example>");
            Console.WriteLine();
            Console.WriteLine("\t 5 + 3 = " + calculator.Calculate("5+3"));
            Console.WriteLine("\t 17 - 57 = " + calculator.Calculate("17-57"));
            Console.WriteLine("\t 1.5 * 6 = " + calculator.Calculate("1,5*6"));
            Console.WriteLine("\t 22 / 7 = " + calculator.Calculate("22/7"));
            Console.WriteLine();
            Console.WriteLine("</Command Pattern Example>");
            Console.WriteLine();
        }
    }
}