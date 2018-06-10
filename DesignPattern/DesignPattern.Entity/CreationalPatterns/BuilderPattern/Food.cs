using System;

namespace DesignPattern.Entity.CreationalPatterns.BuilderPattern
{    
    public class Food
    {
        public string Name { get; set; }
        public double Calorie { get; set; }
        public double DefaultWeight { get; set; }
        public Food(string name, double calorie, double defaultWeight)
        {
            Name = name;
            Calorie = calorie;
            DefaultWeight = defaultWeight;
        }
    }
}
