using System;
using DesignPattern.ConsoleApp.AbstractFactoryPattern;
using DesignPattern.ConsoleApp.BuilderPattern;
using DesignPattern.ConsoleApp.FactoryPattern;
using DesignPattern.ConsoleApp.PrototypePattern;
using DesignPattern.ConsoleApp.SingletonPattern;


namespace DesignPattern.ConsoleApp
{
    class Program
    {       
        static void Main(string[] args)
        {
            FactoryPatternExample.Run();
            AbstractFactoryPatternExample.Run();
            SingletonPatternExample.Run();
            BuilderPatternExample.Run();
            PrototypePatternExample.Run();
        }
    }
}
