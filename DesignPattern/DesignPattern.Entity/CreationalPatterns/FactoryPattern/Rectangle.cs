using System.Drawing;
using System.Drawing.Drawing2D;

namespace DesignPattern.Entity.CreationalPatterns.FactoryPattern
{
    public class Rectangle : IShape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }

        public Bitmap GetImage()
        {
            Bitmap bmp = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, (float)(50 - Width / 2), (float)(50 - Height / 2), (float)Width, (float)Height);
            g.Dispose();
            return bmp;
        }

        public override string ToString()
        {
            return $"Rectangle[{Width},{Height}] = ".PadRight(25) + Area();
        }
    }
}