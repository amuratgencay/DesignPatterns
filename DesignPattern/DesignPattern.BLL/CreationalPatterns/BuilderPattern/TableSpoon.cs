using DesignPattern.Entity.CreationalPatterns.BuilderPattern;

namespace DesignPattern.BLL.CreationalPatterns.BuilderPattern
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