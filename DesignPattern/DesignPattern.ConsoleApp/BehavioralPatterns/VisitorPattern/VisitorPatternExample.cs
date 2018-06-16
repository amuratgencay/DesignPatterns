using System;
using DesignPattern.BLL.BehavioralPatterns.VisitorPattern;
using DesignPattern.Entity.BehavioralPatterns.VisitorPattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.VisitorPattern
{
    public static class VisitorPatternExample
    {
        public static void Run()
        {
            var hp = new HP("HP", "HP LaserJet Pro MFP M28a");
            var canon = new Canon("Canon", "Laser Fax L150");
            Console.WriteLine("<Visitor Pattern Example>");
            Console.WriteLine();
            hp.Accept(new PrintVisitor());
            canon.Accept(new PrintVisitor());

            hp.Accept(new FaxVisitor());
            canon.Accept(new FaxVisitor());
            Console.WriteLine();
            Console.WriteLine("</Visitor Pattern Example>");
            Console.WriteLine();
        }
    }
}