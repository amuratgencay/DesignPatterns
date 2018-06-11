using DesignPattern.Entity.StructuralPatterns.FacadePattern;

namespace DesignPattern.BLL.StructuralPatterns.FacadePattern
{
    public class ShapeMaker
    {
        private readonly IDrawable _circle;
        private readonly IDrawable _rectangle;
        private readonly IDrawable _square;

        public ShapeMaker()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }

        public void DrawCircle()
        {
            _circle.Draw();
        }

        public void DrawRectangle()
        {
            _rectangle.Draw();
        }

        public void DrawSquare()
        {
            _square.Draw();
        }
    }
}