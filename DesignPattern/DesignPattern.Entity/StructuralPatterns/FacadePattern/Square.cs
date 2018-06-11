using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Entity.StructuralPatterns.FacadePattern
{
    public class Square : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Square");
        }
    }
}
