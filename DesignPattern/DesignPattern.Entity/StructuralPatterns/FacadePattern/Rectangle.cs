﻿using System;

namespace DesignPattern.Entity.StructuralPatterns.FacadePattern
{
    public class Rectangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}