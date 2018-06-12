using System;

namespace DesignPattern.Entity.StructuralPatterns.PrivateClassDataPattern
{
    public class RectangleData : ShapeData
    {
        public RectangleData(int x, int y, int w, int h, ConsoleColor color) : base(x, y, color)
        {
            Width = w;
            Height = h;
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return $"Rectangle[X,Y,W,H,Color]: [{X}, {Y}, {Width}, {Height}, {Color}]";
        }
    }
}