using System;
using System.Threading;
using DesignPattern.Entity.BehavioralPatterns.ObserverPattern;

namespace DesignPattern.ConsoleApp.BehavioralPatterns.ObserverPattern
{
    public static class ObserverPatternExample
    {
        public static void DrawView()
        {
            Console.WriteLine("\t╔═════════════════╗");
            Console.WriteLine("\t║Number:          ║");
            Console.WriteLine("\t╠═════════════════╣");
            Console.WriteLine("\t║Binary:          ║");
            Console.WriteLine("\t╠═════════════════╣");
            Console.WriteLine("\t║Octal:           ║");
            Console.WriteLine("\t╠═════════════════╣");
            Console.WriteLine("\t║Hexa:            ║");
            Console.WriteLine("\t╚═════════════════╝");
        }

        public static void Run()
        {
            Console.WriteLine("<Observer Pattern Example>");
            Console.WriteLine();

            var left = Console.CursorLeft;
            var top = Console.CursorTop + 1;
            DrawView();
            var cLeft = Console.CursorLeft;
            var cTop = Console.CursorTop;

            var view = new View(left + 17, top, cLeft, cTop);
            var hexa = new Hexa(view, left + 17, top + 6, cLeft, cTop);
            var octal = new Octal(view, left + 17, top + 4, cLeft, cTop);
            var binary = new Binary(view, left + 17, top + 2, cLeft, cTop);
            ;


            view.State = 15;
            Thread.Sleep(1000);
            view.State = 10;
            Thread.Sleep(1000);
            view.State = 7;
            Console.WriteLine();
            Console.WriteLine("</Observer Pattern Example>");
        }
    }
}