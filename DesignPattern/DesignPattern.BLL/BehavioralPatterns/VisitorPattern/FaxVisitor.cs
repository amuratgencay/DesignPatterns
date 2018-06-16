using System;
using DesignPattern.Entity.BehavioralPatterns.VisitorPattern;

namespace DesignPattern.BLL.BehavioralPatterns.VisitorPattern
{
    public class FaxVisitor : IVisitor
    {
        public void Visit(Printer printer)
        {
            switch (printer)
            {
                case HP _:
                    Console.WriteLine("\t" + printer + " does not have fax option.");
                    break;
                case Canon _:
                    Console.WriteLine("\t" + printer + " fax...");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(printer), typeof(Printer), null);
            }
        }
    }
}