using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BLL.StructuralPatterns.FlyweightPattern
{
    public static class FlyweightShapes
    {
        private static readonly List<ConsoleColor> _consoleColors = new List<ConsoleColor>() { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Black, ConsoleColor.Yellow };

        public static ConsoleColor GetRandomColor()
        {
            var rnd = new Random((int)DateTime.Now.Ticks);
            return _consoleColors[(int)rnd.Next(_consoleColors.Count)];
        }


    }
}
