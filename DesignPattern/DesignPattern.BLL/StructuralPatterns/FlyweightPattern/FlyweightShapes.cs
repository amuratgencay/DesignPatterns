using System;
using System.Collections.Generic;

namespace DesignPattern.BLL.StructuralPatterns.FlyweightPattern
{
    public static class FlyweightShapes
    {
        private static readonly List<ConsoleColor> _consoleColors = new List<ConsoleColor>
        {
            ConsoleColor.Red,
            ConsoleColor.Green,
            ConsoleColor.Blue,
            ConsoleColor.Black,
            ConsoleColor.Yellow
        };

        public static ConsoleColor GetRandomColor()
        {
            var rnd = new Random((int) DateTime.Now.Ticks);
            return _consoleColors[rnd.Next(_consoleColors.Count)];
        }
    }
}