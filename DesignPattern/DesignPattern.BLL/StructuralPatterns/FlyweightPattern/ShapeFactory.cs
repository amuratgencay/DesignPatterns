using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Entity.StructuralPatterns.FlyweightPattern;

namespace DesignPattern.BLL.StructuralPatterns.FlyweightPattern
{
    public static class ShapeFactory 
    {
        private static readonly Dictionary<ConsoleColor, IDrawable> _drawableDictionary = new Dictionary<ConsoleColor, IDrawable>();
        public static IDrawable GetShape(ConsoleColor color)
        {
            if (!_drawableDictionary.ContainsKey(color))
            {
                Console.WriteLine( color + " created");
                _drawableDictionary.Add(color, new Circle(color));
            }            
            return _drawableDictionary[color];
        }
    }
}
