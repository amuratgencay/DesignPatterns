using System;
using DesignPattern.Entity.BuilderPattern;

namespace DesignPattern.BLL.BuilderPattern
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
