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

        public override string ToString()
        {
            return $"Rectangle[{Width},{Height}] = ".PadRight(25) + Area();
        }
    }
}