using DesignPattern.Entity.StructuralPatterns.DecoratorPattern;

namespace DesignPattern.BLL.StructuralPatterns.DecoratorPattern
{
    public abstract class ShapeDecorator : IDrawable
    {
        protected IDrawable DecoratedShape;

        public ShapeDecorator(IDrawable decoratedShape)
        {
            DecoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {
            DecoratedShape.Draw();
        }
    }
}