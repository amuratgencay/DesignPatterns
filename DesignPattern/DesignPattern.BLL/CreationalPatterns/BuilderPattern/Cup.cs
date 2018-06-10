using System;
using DesignPattern.Entity.CreationalPatterns.BuilderPattern;

namespace DesignPattern.BLL.CreationalPatterns.BuilderPattern
{
    public class Cup : Packing
    {
        public Cup(double amount, Food food)
        {
            Amount = amount;
            Food = food;
            Factor = 200;
        }
    }
}
