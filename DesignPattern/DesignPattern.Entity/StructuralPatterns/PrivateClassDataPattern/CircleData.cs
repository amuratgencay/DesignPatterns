using System;

namespace DesignPattern.Entity.StructuralPatterns.PrivateClassDataPattern
{
    public class CircleData : ShapeData
    {
        public CircleData(int x, int y, int r, ConsoleColor color) : base(x, y, color)
        {
            Radius = r;
        }

        public int Radius { get; set; }

        public override string ToString()
        {
            return $"Circle[X,Y,R,Color]: [{X}, {Y}, {Radius}, {Color}]";
        }
    }
}