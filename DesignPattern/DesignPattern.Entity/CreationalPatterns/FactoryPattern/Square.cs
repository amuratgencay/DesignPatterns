using System.Drawing;
using System.Drawing.Drawing2D;

namespace DesignPattern.Entity.CreationalPatterns.FactoryPattern
{
    public class Square : IShape
    {
        public Square(double size)
        {
            Size = size;
        }

        public double Size { get; set; }

        public double Area()
        {
            return Size * Size;
        }

        public Bitmap GetImage()
        {
            Bitmap bmp = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, (float)(50 - Size / 2), (float)(50 - Size / 2), (float)Size, (float)Size);
            g.Dispose();
            return bmp;
        }

        public override string ToString()
        {
            return $"Square[{Size}] = ".PadRight(25) + Area();
        }
    }
}