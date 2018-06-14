using System;
using System.Collections.Generic;
using DesignPattern.BLL.BehavioralPatterns.InterpreterPattern;
using DesignPattern.Entity.BehavioralPatterns.InterpreterPattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.InterpreterPattern
{
    public static class InterpreterPatternExample
    {
        public static void Run()
        {
            var roman = "MCMXXVIII";
            var context = new Context(roman);
            var tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };
            tree.ForEach(x => x.Interpret(context));

            Console.WriteLine("<Interpreter Pattern Example>");
            Console.WriteLine();
            Console.WriteLine("\t" + roman + " = " + context.Output);
            Console.WriteLine();
            Console.WriteLine("</Interpreter Pattern Example>");
            Console.WriteLine();
        }
    }
}