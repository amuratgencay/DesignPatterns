using System;
using DesignPattern.BLL.BehavioralPatterns.StatePattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.StatePattern
{
    public static class StatePatternExample
    {
        public static void Run()
        {
            var ctx1 = new Context("10011");
            var ctx2 = new Context("11011");
            var ctx3 = new Context("11101");
            Console.WriteLine("<State Pattern Example>");
            Console.WriteLine();
            Console.WriteLine("\t Number of 1 bit count in " + Convert.ToInt32(ctx1.Value, 2) + " binary(" +
                              ctx1.Value + "): " + ctx1.Count());
            Console.WriteLine("\t Number of 1 bit count in " + Convert.ToInt32(ctx2.Value, 2) + " binary(" +
                              ctx2.Value + "): " + ctx2.Count());
            Console.WriteLine("\t Number of 1 bit count in " + Convert.ToInt32(ctx3.Value, 2) + " binary(" +
                              ctx3.Value + "): " + ctx3.Count());
            Console.WriteLine();
            Console.WriteLine("</State Pattern Example>");
            Console.WriteLine();
        }
    }
}