﻿using DesignPattern.Entity.CreationalPatterns.BuilderPattern;

namespace DesignPattern.BLL.CreationalPatterns.BuilderPattern
{
    public abstract class Packing : IPacking
    {
        protected double Factor { get; set; }
        public double Amount { get; set; }
        public Food Food { get; set; }

        public double TotalCalories()
        {
            return Amount * (Food.Calorie * Factor / Food.DefaultWeight);
        }

        public override string ToString()
        {
            return $"{Amount} {GetType().Name.ToLower()} {Food.Name} have {TotalCalories().ToString("F")} kcal";
        }
    }
}