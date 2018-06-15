using System;
using DesignPattern.ConsoleApp.BehavioralPatterns.ChainofResponsibilityPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.CommandPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.InterpreterPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.IteratorPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.MediatorPattern;
using DesignPattern.ConsoleApp.CreationalPatterns.AbstractFactoryPattern;
using DesignPattern.ConsoleApp.CreationalPatterns.BuilderPattern;
using DesignPattern.ConsoleApp.CreationalPatterns.FactoryPattern;
using DesignPattern.ConsoleApp.CreationalPatterns.PrototypePattern;
using DesignPattern.ConsoleApp.CreationalPatterns.SingletonPattern;
using DesignPattern.ConsoleApp.StructuralPatterns.AdapterPattern;
using DesignPattern.ConsoleApp.StructuralPatterns.BridgePattern;
using DesignPattern.ConsoleApp.StructuralPatterns.CompositePattern;
using DesignPattern.ConsoleApp.StructuralPatterns.DecoratorPattern;
using DesignPattern.ConsoleApp.StructuralPatterns.FacadePattern;
using DesignPattern.ConsoleApp.StructuralPatterns.FlyweightPattern;
using DesignPattern.ConsoleApp.StructuralPatterns.PrivateClassDataPattern;

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

            Console.WriteLine("Structural Patterns".PadLeft(50, '*').PadRight(80, '*'));
            AdapterPatternExample.Run();
            BridgePatternExample.Run();
            DecoratorPatternExample.Run();
            FacadePatternExample.Run();
            FlyweightPatternExample.Run();
            ProxyPatternExample.Run();
            CompositePatternExample.Run();
            PrivateClassDataPattern.Run();

            Console.WriteLine("Behavioral Patterns".PadLeft(50, '*').PadRight(80, '*'));
            ChainofResponsibilityPatternExample.Run();
            CommandPatternExample.Run();
            InterpreterPatternExample.Run();
            IteratorPatternExample.Run();
            MediatorPatternExample.Run();
        }
    }
}