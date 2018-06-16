using System;
using DesignPattern.ConsoleApp.BehavioralPatterns.ChainofResponsibilityPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.CommandPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.InterpreterPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.IteratorPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.MediatorPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.MementoPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.ObserverPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.StatePattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.StrategyPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.TemplatePattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.VisitorPattern;
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
            while (true)
            {
                Console.WriteLine("1.Creational Patterns");
                Console.WriteLine("2.Structural Patterns");
                Console.WriteLine("3.Behavioral Patterns");
                Console.WriteLine("Press q for exit.");
                var choice = Console.ReadKey().KeyChar;
                Console.Clear();
                var done = false;
                switch (choice)
                {
                    case '1':
                        while (!done)
                        {
                            Console.WriteLine("1. FactoryPatternExample");
                            Console.WriteLine("2. AbstractFactoryPatternExample");
                            Console.WriteLine("3. SingletonPatternExample");
                            Console.WriteLine("4. BuilderPatternExample");
                            Console.WriteLine("5. PrototypePatternExample");
                            Console.WriteLine("Press q for exit.");
                            choice = Console.ReadKey().KeyChar;
                            Console.Clear();
                            switch (choice)
                            {
                                case '1':
                                    FactoryPatternExample.Run();
                                    break;
                                case '2':
                                    AbstractFactoryPatternExample.Run();
                                    break;
                                case '3':
                                    SingletonPatternExample.Run();
                                    break;
                                case '4':
                                    BuilderPatternExample.Run();
                                    break;
                                case '5':
                                    PrototypePatternExample.Run();
                                    break;
                                case 'q':
                                    done = true;
                                    break;
                                default:
                                    Console.WriteLine("Choice range (1-5) or q for previous menu. ");
                                    break;
                            }
                        }
                        break;
                    case '2':
                        while (!done)
                        {
                            Console.WriteLine("1. AdapterPatternExample");
                            Console.WriteLine("2. BridgePatternExample");
                            Console.WriteLine("3. DecoratorPatternExample");
                            Console.WriteLine("4. FacadePatternExample");
                            Console.WriteLine("5. FlyweightPatternExample");
                            Console.WriteLine("6. ProxyPatternExample");
                            Console.WriteLine("7. CompositePatternExample");
                            Console.WriteLine("8. PrivateClassDataPattern");
                            Console.WriteLine("Press q for exit.");
                            choice = Console.ReadKey().KeyChar;
                            Console.Clear();
                            switch (choice)
                            {
                                case '1':
                                    AdapterPatternExample.Run();
                                    break;
                                case '2':
                                    BridgePatternExample.Run();
                                    break;
                                case '3':
                                    DecoratorPatternExample.Run();
                                    break;
                                case '4':
                                    FacadePatternExample.Run();
                                    break;
                                case '5':
                                    FlyweightPatternExample.Run();
                                    break;
                                case '6':
                                    ProxyPatternExample.Run();
                                    break;
                                case '7':
                                    CompositePatternExample.Run();
                                    break;
                                case '8':
                                    PrivateClassDataPattern.Run();
                                    break;
                                case 'q':
                                    done = true;
                                    break;
                                default:
                                    Console.WriteLine("Choice range (1-8) or q for previous menu. ");
                                    break;
                            }
                        }
                        break;
                    case '3':
                        while (!done)
                        {
                            Console.WriteLine("1. ChainofResponsibilityPatternExample");
                            Console.WriteLine("2. CommandPatternExample");
                            Console.WriteLine("3. InterpreterPatternExample");
                            Console.WriteLine("4. IteratorPatternExample");
                            Console.WriteLine("5. MediatorPatternExample");
                            Console.WriteLine("6. MementoPatternExample");
                            Console.WriteLine("7. ObserverPatternExample");
                            Console.WriteLine("8. StatePatternExample");
                            Console.WriteLine("9. StrategyPatternExample");
                            Console.WriteLine("a. TemplatePatternExample");
                            Console.WriteLine("b. VisitorPatternExample");
                            Console.WriteLine("Press q for exit.");
                            choice = Console.ReadKey().KeyChar;
                            Console.Clear();
                            switch (choice)
                            {
                                case '1':
                                    ChainofResponsibilityPatternExample.Run();
                                    break;
                                case '2':
                                    CommandPatternExample.Run();
                                    break;
                                case '3':
                                    InterpreterPatternExample.Run();
                                    break;
                                case '4':
                                    IteratorPatternExample.Run();
                                    break;
                                case '5':
                                    MediatorPatternExample.Run();
                                    break;
                                case '6':
                                    MementoPatternExample.Run();
                                    break;
                                case '7':
                                    ObserverPatternExample.Run();
                                    break;
                                case '8':
                                    StatePatternExample.Run();
                                    break;
                                case '9':
                                    StrategyPatternExample.Run();
                                    break;
                                case 'a':
                                    TemplatePatternExample.Run();
                                    break;
                                case 'b':
                                    VisitorPatternExample.Run();
                                    break;
                                case 'q':
                                    done = true;
                                    break;
                                default:
                                    Console.WriteLine("Choice range (1-9, a-b) or q for previous menu. ");
                                    break;
                            }
                        }
                        break;
                    case 'q': return;
                    default:
                        Console.WriteLine("Choice range (1-3) or q for exit. ");
                        break;
                }
            }

        }
    }
}