namespace DesignPattern.Entity.StructuralPatterns.BridgePattern
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height, IDrawable drawable) : base(drawable)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            Drawable.Draw(this);
        }

        public override string ToString()
        {
            return $"Rectangle[X,Y,W,H] = ({X}, {Y}), ({Width}, {Height})";
        }
    }
}