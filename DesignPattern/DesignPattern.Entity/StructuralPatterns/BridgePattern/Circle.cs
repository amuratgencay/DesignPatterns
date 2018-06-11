using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.StructuralPatterns.BridgePattern
{
    public class Circle : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public Circle(int x,int y, int radius, IDrawable drawable) : base(drawable)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        public override void Draw()
        {
            _drawable.Draw(this);
        }
        public override string ToString()
        {
            return $"Circle[X,Y,R] = ({X}, {Y}), {Radius}";
        }
    }
}
