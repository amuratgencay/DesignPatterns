using System;
using DesignPattern.Entity.StructuralPatterns.DecoratorPattern;

namespace DesignPattern.BLL.StructuralPatterns.DecoratorPattern
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IDrawable decoratedShape) : base(decoratedShape)
        {
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            DecoratedShape.Draw();
            Console.ResetColor();
        }
    }
}