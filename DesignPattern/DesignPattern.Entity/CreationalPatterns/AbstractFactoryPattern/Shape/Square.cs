namespace DesignPattern.Entity.CreationalPatterns.AbstractFactoryPattern.Shape
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
            return Size*Size;
        }

        public override string ToString()
        {
            return $"Square[{Size}] = ".PadRight(25) + Area();
        }
    }
}