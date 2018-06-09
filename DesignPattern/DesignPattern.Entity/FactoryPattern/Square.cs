using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.FactoryPattern
{
    public class Square : Shape
    {
        public double Size { get; set; }
        
        public Square(double size)
        {
            Size = size;
            
        }
        public override double Area()
        {
            return Size * Size;
        }

        public override string ToString()
        {
            return $"Square[{Size},{Size}] = {Area()}";
        }
    }
}
