using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DesignPattern.Entity.CreationalPatterns.FactoryPattern
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public Bitmap GetImage()
        {
            Bitmap bmp = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            g.DrawEllipse(Pens.Black, (float)(50 - Radius / 2), (float)(50 - Radius / 2), (float)Radius, (float)Radius);
            g.Dispose();
            return bmp;
        }

        public override string ToString()
        {
            return $"Circle[{Radius}] = ".PadRight(25) + Area();
        }
    }
}