using System;
using DesignPattern.BLL.CreationalPatterns.SingletonPattern;


namespace DesignPattern.ConsoleApp.CreationalPatterns.SingletonPattern
{
    public static class SingletonPatternExample
    {
        public static void Run()
        {
            Console.WriteLine("<Singleton Pattern Example>");
            Console.WriteLine();
                MessageLogger.Instance.Start();
                    Console.WriteLine("Message 1");
                    Console.WriteLine("Message 2");
                    Console.WriteLine("Message 3");
                MessageLogger.Instance.Stop();
                MessageLogger.Instance.DisplayLogs();
            Console.WriteLine();
            Console.WriteLine("</Singleton Pattern Example>");
            Console.WriteLine();


            
        }
    }
}
