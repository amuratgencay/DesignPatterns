using System;
using DesignPattern.BLL.BehavioralPatterns.NullObjectPattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.NullObjectPattern
{
    public static class NullObjectPatternExample
    {
        public static void Run()
        {
            var respository = new CustomerRepository();

            Console.WriteLine("<Null Object Pattern Example>");
            Console.WriteLine();
            respository.PrintList();
            Console.WriteLine();
            Console.WriteLine("\tGetById(2) -> " + respository.GetById(2));
            Console.WriteLine("\tGetById(5) -> " + respository.GetById(5));
            Console.WriteLine();
            Console.WriteLine("</Null Object Pattern Example>");
            Console.WriteLine();
        }
    }
}