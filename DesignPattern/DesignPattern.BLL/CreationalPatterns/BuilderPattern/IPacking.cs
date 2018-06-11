using DesignPattern.Entity.CreationalPatterns.BuilderPattern;

namespace DesignPattern.BLL.CreationalPatterns.BuilderPattern
{
    public interface IPacking
    {
        double Amount { get; set; }
        Food Food { get; set; }
        double TotalCalories();
    }
}