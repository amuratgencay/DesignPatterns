using System;
using DesignPattern.Entity.CreationalPatterns.BuilderPattern;

namespace DesignPattern.BLL.CreationalPatterns.BuilderPattern
{
    public abstract class Packing : IPacking
    {
        public double Amount { get; set; }
        public Food Food { get; set; }
        protected double Factor { get; set; }

        public double TotalCalories() => Amount * ((Food.Calorie * Factor) / Food.DefaultWeight);

        public override string ToString()
        {
            return $"{Amount} {GetType().Name.ToLower()} {Food.Name} have { TotalCalories().ToString("F") } kcal";
        }
    }
}
