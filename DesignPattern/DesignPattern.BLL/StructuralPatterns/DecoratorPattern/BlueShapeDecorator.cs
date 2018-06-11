using System;
using DesignPattern.Entity.StructuralPatterns.DecoratorPattern;

namespace DesignPattern.BLL.StructuralPatterns.DecoratorPattern
{
    public class BlueShapeDecorator : ShapeDecorator
    {
        public BlueShapeDecorator(IDrawable decoratedShape) : base(decoratedShape)
        {
        }

        public override void Draw()
        {
            var tmpForeground = Console.ForegroundColor;
            var tmpBackground = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            DecoratedShape.Draw();
            Console.ForegroundColor = tmpForeground;
            Console.BackgroundColor = tmpBackground;
        }
    }
}