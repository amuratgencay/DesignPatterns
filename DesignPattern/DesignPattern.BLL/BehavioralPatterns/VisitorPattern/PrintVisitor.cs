using System;
using DesignPattern.Entity.BehavioralPatterns.VisitorPattern;

namespace DesignPattern.BLL.BehavioralPatterns.VisitorPattern
{
    public class PrintVisitor : IVisitor
    {
        public void Visit(Printer printer)
        {
            switch (printer)
            {
                case HP _:
                case Canon _:
                    Console.WriteLine("\t" + printer + " print...");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(printer), typeof(Printer), null);
            }
        }
    }
}