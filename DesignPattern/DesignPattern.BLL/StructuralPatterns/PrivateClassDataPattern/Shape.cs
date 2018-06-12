using DesignPattern.Entity.StructuralPatterns.PrivateClassDataPattern;

namespace DesignPattern.BLL.StructuralPatterns.PrivateClassDataPattern
{
    public abstract class Shape : IDrawable, IMeasurable
    {
        public abstract void Draw();
        public abstract double Area();
        public abstract double Circumference();
    }
}