using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.FactoryPattern
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;            
        }
        public override double Area()
        {
            return Width*Height;
        }

        public override string ToString()
        {
            return $"Rectangle[{Width},{Height}] = {Area()}";
        }
    }
}
