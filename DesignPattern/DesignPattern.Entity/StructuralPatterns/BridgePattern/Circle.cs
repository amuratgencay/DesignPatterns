namespace DesignPattern.Entity.StructuralPatterns.BridgePattern
{
    public class Circle : Shape
    {
        public Circle(int x, int y, int radius, IDrawable drawable) : base(drawable)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public override void Draw()
        {
            Drawable.Draw(this);
        }

        public override string ToString()
        {
            return $"Circle[X,Y,R] = ({X}, {Y}), {Radius}";
        }
    }
}