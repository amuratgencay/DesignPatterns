using System;
using DesignPattern.BLL.CreationalPatterns.PrototypePattern;

namespace DesignPattern.ConsoleApp.CreationalPatterns.PrototypePattern
{
    public static class PrototypePatternExample
    {
        public static void Run()
        {
            Console.WriteLine("<Prototype Pattern Example>");
            Console.WriteLine();
                FibonacciCache.LoadCache();
                Console.WriteLine("\t" + FibonacciCache.GetFibonacciNumber(3));
                Console.WriteLine("\t" + FibonacciCache.GetFibonacciNumber(5));
                Console.WriteLine("\t" + FibonacciCache.GetFibonacciNumber(7));
            Console.WriteLine();
            Console.WriteLine("</Prototype Pattern Example>");
            Console.WriteLine();
        }
    }
}
