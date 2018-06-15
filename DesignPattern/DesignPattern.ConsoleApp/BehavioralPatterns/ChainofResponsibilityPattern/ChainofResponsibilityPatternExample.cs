using System;
using System.Collections.Generic;
using DesignPattern.BLL.BehavioralPatterns.ChainofResponsibilityPattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.ChainofResponsibilityPattern
{
    public static class ChainofResponsibilityPatternExample
    {
        public static void Run()
        {
            var atm = new ATM(
                new List<Banknote>
                {
                    new Banknote(200, 2),
                    new Banknote(100, 3),
                    new Banknote(50, 4),
                    new Banknote(20, 30),
                    new Banknote(10, 50),
                    new Banknote(5, 60),
                    new Banknote(1, 200)
                });
            var amount = 1375;
            Console.WriteLine("<Chain of Responsibility Pattern Example>");
            Console.WriteLine();
            Console.WriteLine("\tTotal Amount: " + atm.TotalAmount());
            Console.WriteLine("\tRequested Amount: " + amount);
            Console.WriteLine();
            foreach (var item in atm.GetMoney(amount)) Console.WriteLine("\t\t" + item.Count + "x" + item.Amount);
            Console.WriteLine();
            Console.WriteLine("\tTotal Amount: " + atm.TotalAmount());
            Console.WriteLine();
            Console.WriteLine("</Chain of Responsibility Pattern Example>");
            Console.WriteLine();
        }
    }
}