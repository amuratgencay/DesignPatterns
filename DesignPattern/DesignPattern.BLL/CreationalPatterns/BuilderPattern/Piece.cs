using System;
using DesignPattern.Entity.CreationalPatterns.BuilderPattern;

namespace DesignPattern.BLL.CreationalPatterns.BuilderPattern
{
    public class Piece : Packing
    {
        public Piece(double amount, Food food)
        {
            Amount = amount;
            Food = food;
            Factor = food.DefaultWeight;
        }
    }
}
