using System;
using DesignPattern.BLL.BehavioralPatterns.CommandPattern;
using DesignPattern.Entity.BehavioralPatterns.CommandPattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.CommandPattern
{
    public static class CommandPatternExample
    {
        public static void Run()
        {
            var calculator = new Calculator();
            var number = new Number(10);
            calculator.AddOperation(new Sum(number, 17));
            calculator.AddOperation(new Sub(number, 37));
            calculator.AddOperation(new Mul(number, -0.8));
            calculator.AddOperation(new Div(number, 2));
            Console.WriteLine("<Command Pattern Example>");
            Console.WriteLine();
            Console.WriteLine("\t" + number);
            calculator.Calculate();
            Console.WriteLine();
            Console.WriteLine("</Command Pattern Example>");
            Console.WriteLine();
        }
    }
}