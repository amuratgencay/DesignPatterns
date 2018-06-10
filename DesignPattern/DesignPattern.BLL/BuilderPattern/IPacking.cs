using System;
using DesignPattern.Entity.BuilderPattern;

namespace DesignPattern.BLL.BuilderPattern
{
    public interface IPacking
    {
        double Amount { get; set; }
        Food Food { get; set; }
        double TotalCalories();
    }
}
