using System;

using DesignPattern.ConsoleApp.CreationalPatterns.AbstractFactoryPattern;
using DesignPattern.ConsoleApp.CreationalPatterns.BuilderPattern;
using DesignPattern.ConsoleApp.CreationalPatterns.FactoryPattern;
using DesignPattern.ConsoleApp.CreationalPatterns.PrototypePattern;
using DesignPattern.ConsoleApp.CreationalPatterns.SingletonPattern;
using DesignPattern.ConsoleApp.StructuralPatterns.AdapterPattern;


namespace DesignPattern.ConsoleApp
{
    class Program
    {       
        static void Main(string[] args)
        {
            //Creational Patterns
            /*
            FactoryPatternExample.Run();
            AbstractFactoryPatternExample.Run();
            SingletonPatternExample.Run();
            BuilderPatternExample.Run();
            PrototypePatternExample.Run();
            */
            //Structural Patterns
            AdapterPatternExample.Run();

        }
    }
}
