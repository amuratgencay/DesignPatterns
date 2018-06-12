using System;

namespace DesignPattern.Entity.StructuralPatterns.PrivateClassDataPattern
{
    public abstract class ShapeData
    {
        public ShapeData(int x, int y, ConsoleColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; set; }
    }
}