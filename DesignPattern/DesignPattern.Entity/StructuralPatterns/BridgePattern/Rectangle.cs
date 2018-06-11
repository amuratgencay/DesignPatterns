using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.StructuralPatterns.BridgePattern
{
    public class Rectangle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height, IDrawable drawable) : base(drawable)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;

        }
        public override void Draw()
        {
            _drawable.Draw(this);
        }
        public override string ToString()
        {
            return $"Rectangle[X,Y,W,H] = ({X}, {Y}), ({Width}, {Height})";
        }
    }
}
