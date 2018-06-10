using System;
using DesignPattern.Entity.BuilderPattern;

namespace DesignPattern.BLL.BuilderPattern
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
