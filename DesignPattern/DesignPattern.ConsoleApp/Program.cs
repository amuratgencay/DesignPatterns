using System;
using DesignPattern.ConsoleApp.CreationalPatterns.AbstractFactoryPattern;
using DesignPattern.ConsoleApp.CreationalPatterns.BuilderPattern;
using DesignPattern.ConsoleApp.CreationalPatterns.FactoryPattern;
using DesignPattern.ConsoleApp.CreationalPatterns.PrototypePattern;
using DesignPattern.ConsoleApp.CreationalPatterns.SingletonPattern;
using DesignPattern.ConsoleApp.StructuralPatterns.AdapterPattern;
using DesignPattern.ConsoleApp.StructuralPatterns.BridgePattern;
using DesignPattern.ConsoleApp.StructuralPatterns.DecoratorPattern;
using DesignPattern.ConsoleApp.StructuralPatterns.FacadePattern;

namespace DesignPattern.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Creational Patterns".PadLeft(50, '*').PadRight(80, '*'));
            FactoryPatternExample.Run();
            AbstractFactoryPatternExample.Run();
            SingletonPatternExample.Run();
            BuilderPatternExample.Run();
            PrototypePatternExample.Run();

            Console.WriteLine("Structural Patterns".PadLeft(50,'*').PadRight(80,'*'));
            AdapterPatternExample.Run();
            BridgePatternExample.Run();
            DecoratorPatternExample.Run();
            FacadePatternExample.Run();
        }
    }
}