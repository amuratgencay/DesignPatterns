using System;
using System.Text;
using DesignPattern.ConsoleApp.BehavioralPatterns.ChainofResponsibilityPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.CommandPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.InterpreterPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.IteratorPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.MediatorPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.MementoPattern;
using DesignPattern.ConsoleApp.BehavioralPatterns.NullObjectPattern;
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
                //╔ ╩ ╦ ╠ ═ ╬ ╣ ║ ╗ ╝ ╚
                Console.WriteLine("╔═══════════════════════════════════╦═════════════════╗");
                Console.WriteLine("║          Design Patterns          ║     X. Exit     ║");
                Console.WriteLine("╠═════════════════╦═════════════════╬═════════════════╣");
                Console.WriteLine("║  1. Creational  ║  2. Structural  ║  3. Behavioral  ║");
                Console.WriteLine("╚═════════════════╩═════════════════╩═════════════════╝");
                var choice = char.ToLower(Console.ReadKey().KeyChar);
                Console.Clear();
                var done = false;
                switch (choice)
                {
                    case '1':
                        while (!done)
                        {
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════╦═════════════════════╗");
                            Console.WriteLine("║                                   Creational Design Patterns                          ║       P. Back       ║");
                            Console.WriteLine("╠═════════════════════╦═════════════════════╦═════════════════════╦═════════════════════╬═════════════════════╣");
                            Console.WriteLine("║     1. Factory      ║ 2. Abstract Factory ║    3. Singleton     ║     4. Builder      ║    5. Prototype     ║");
                            Console.WriteLine("╚═════════════════════╩═════════════════════╩═════════════════════╩═════════════════════╩═════════════════════╝");
                            choice = char.ToLower(Console.ReadKey().KeyChar);
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
                                case 'p':
                                    done = true;
                                    break;
                                default:
                                    Console.WriteLine("Choice range (1-5) or P for previous menu. ");
                                    break;
                            }
                        }
                        break;
                    case '2':
                        while (!done)
                        {
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╦═══════════════════════╗");
                            Console.WriteLine("║                         Structural Design Patterns                    ║       P. Back         ║");
                            Console.WriteLine("╠═══════════════════════╦═══════════════════════╦═══════════════════════╬═══════════════════════╣");
                            Console.WriteLine("║      1. Adapter       ║       2. Bridge       ║     3. Decorator      ║      4. Facade        ║");
                            Console.WriteLine("╠═══════════════════════╬═══════════════════════╬═══════════════════════╬═══════════════════════╣");
                            Console.WriteLine("║      5. Facade        ║       6. Proxy        ║     7. Composite      ║ 8. Private Class Data ║");
                            Console.WriteLine("╚═══════════════════════╩═══════════════════════╩═══════════════════════╩═══════════════════════╝");
                            choice = char.ToLower(Console.ReadKey().KeyChar);
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
                                case 'p':
                                    done = true;
                                    break;
                                default:
                                    Console.WriteLine("Choice range (1-8) or P for previous menu. ");
                                    break;
                            }
                        }
                        break;
                    case '3':
                        while (!done)
                        {
                            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════╦════════════════════════════╗");
                            Console.WriteLine("║                          Behavioral Design Patterns                                  ║          P. Back           ║");
                            Console.WriteLine("╠════════════════════════════╦════════════════════════════╦════════════════════════════╬════════════════════════════╣");
                            Console.WriteLine("║ 1. Chain of Responsibility ║         2. Command         ║        3. Interpreter      ║          4. Iterator       ║");
                            Console.WriteLine("╠════════════════════════════╬════════════════════════════╬════════════════════════════╬════════════════════════════╣");
                            Console.WriteLine("║        5. Mediator         ║         6. Memento         ║        7. Observer         ║          8. State          ║");
                            Console.WriteLine("╠════════════════════════════╬════════════════════════════╬════════════════════════════╬════════════════════════════╣");
                            Console.WriteLine("║        9. Strategy         ║         A. Template        ║        B. Visitor          ║       C. Null Object       ║");
                            Console.WriteLine("╚════════════════════════════╩════════════════════════════╩════════════════════════════╩════════════════════════════╝");
                            choice = char.ToLower(Console.ReadKey().KeyChar);
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
                                case 'c':
                                    NullObjectPatternExample.Run();
                                    break;
                                case 'p':
                                    done = true;
                                    break;
                                default:
                                    Console.WriteLine("Choice range (1-9, a-b) or p for previous menu. ");
                                    break;
                            }
                        }
                        break;
                    case 'x': return;
                    default:
                        Console.WriteLine("Choice range (1-3) or X for exit. ");
                        break;
                }
            }

        }
    }
}