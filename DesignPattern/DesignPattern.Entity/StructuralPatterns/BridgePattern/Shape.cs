namespace DesignPattern.Entity.StructuralPatterns.BridgePattern
{
    public abstract class Shape
    {
        protected readonly IDrawable Drawable;

        protected Shape(IDrawable drawable)
        {
            Drawable = drawable;
        }

        public abstract void Draw();
    }
}