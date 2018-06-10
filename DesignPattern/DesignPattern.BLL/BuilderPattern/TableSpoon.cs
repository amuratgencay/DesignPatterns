using System;
using DesignPattern.Entity.BuilderPattern;

namespace DesignPattern.BLL.BuilderPattern
{
    public class TableSpoon : Packing
    {
        public TableSpoon(double amount, Food food)
        {
            Amount = amount;
            Food = food;
            Factor = 25;
        }
    }
}
